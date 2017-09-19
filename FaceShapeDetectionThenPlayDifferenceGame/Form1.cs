using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.Util;
using System.IO;

namespace FaceShapeDetectionThenPlayDifferenceGame
{
    public partial class Form1 : Form
    {

        int ready4Play = 0;
        int ready4Play2 = 0;
        int game = 0;

        private Capture capture_cam = null;
        bool capture_in_progress = true;
        private HaarCascade haar_obj = null;
        MCvAvgComp[] detected_faces = null;
        Image<Bgr, byte> original_img;
        Image<Gray, byte> original_gray;
        double scale = 1.36;
        int min_neighbor = 2;
        int win_size = 25;

        int form_width, form_height;
        int table_width, table_height;
        bool capture_In_Progress = true;
        Image<Bgr, byte> original_Image = null;
        Image<Bgr, byte> smoothed_Image, detected_Image;
        Image<Gray, byte> gray_Image, cannay_Image;


        /// ////////  game 

        Image<Bgr, Byte> image1;//originalImage
        Image<Bgr, Byte> image2;//BopyImage
        Image<Bgr, Byte> Difference; //Difference between the two Image

        double ContourThresh = 100; //stores alpha for thread access
        int Threshold = 60; //stores threshold for thread access
        int i = 0, selected = 0;
        int[,] distination = new int[5, 9];
        //List<Contour<Point>> contoursList = new List<Contour<Point>>();



        public Form1()
        {
            InitializeComponent();
            haar_obj = new HaarCascade(@"haarcascade_frontalface_default.xml");

            ///// game 

            image1 = new Image<Bgr, byte>(@"D:\GitHubGeneral\FaceShapeDetectionThenPlayDifferenceGame\FaceShapeDetectionThenPlayDifferenceGame\Resources\Image\copy5.bmp");
            image2 = new Image<Bgr, byte>(@"D:\GitHubGeneral\FaceShapeDetectionThenPlayDifferenceGame\FaceShapeDetectionThenPlayDifferenceGame\Resources\Image\original5.bmp");



            imageOriginal.Image = image1;
            imageCopy.Image = image2;
            Difference = image1.AbsDiff(image2);

            Difference = Difference.ThresholdBinary(new Bgr(Threshold, Threshold, Threshold), new Bgr(255, 255, 255)); //if value > 60 set to 255, 0 otherwise 

            #region Draw the contours of difference
            //this is tasken from the ShapeDetection Example


            using (MemStorage storage = new MemStorage()) //allocate storage for contour approximation
                //detect the contours and loop through each of them

                for (Contour<Point> contours = Difference.Convert<Gray, Byte>().FindContours(
                      Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE,
                      Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST, storage);
                   contours != null;
                   contours = contours.HNext)
                {
                    //Create a contour for the current variable for us to work with
                    Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.05, storage);


                    //Draw the detected contour on the image
                    if (currentContour.Area > ContourThresh) //only consider contours with area greater than 100 as default then take from form control
                    {

                        //contoursList.Add(currentContour);
                        distination[i, 0] = currentContour.BoundingRectangle.X;
                        distination[i, 1] = currentContour.BoundingRectangle.Y;
                        distination[i, 2] = currentContour.BoundingRectangle.Width;
                        distination[i, 3] = currentContour.BoundingRectangle.Height;
                        distination[i, 4] = currentContour.BoundingRectangle.Top;
                        distination[i, 5] = currentContour.BoundingRectangle.Bottom;
                        distination[i, 6] = currentContour.BoundingRectangle.Left;
                        distination[i, 7] = currentContour.BoundingRectangle.Right;
                        distination[i, 8] = 0;


                        /*  Rectangle rec = new Rectangle(distination[i, 0], distination[i, 1], distination[i, 2], distination[i, 3]);
                          image2.Draw(rec, new Bgr(Color.Red), 3);*/
                        i++;

                        //   image2.Draw(currentContour.BoundingRectangle, new Bgr(Color.Red), 2);

                    }
                }
            #endregion
        }




        private void rd_bt_choose_image_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_bt_choose_image.Checked && capture_in_progress)
            {
                Application.Idle -= processFunction;
                capture_in_progress = false;
            }
            original_img = null;
            original_gray = null;
            //  imageBox2 = imageBox3 = null;
            bt_choose_img.Visible = true;
            txt_bx_img_path.Visible = true;
        }

        private void rd_bt_open_cam_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_bt_open_cam.Checked)
            {
                capture_in_progress = true;
                capture_cam = new Capture();
            }
            original_img = null;
            original_gray = null;
            bt_choose_img.Visible = false;
            txt_bx_img_path.Visible = false;
            Application.Idle += processFunction;
        }

        private void bt_choose_img_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                txt_bx_img_path.Text = openFileDialog1.FileName;
            }
            processFunction(new object(), new EventArgs());
        }

        private void processFunction(object obj, EventArgs e)
        {

            if (shapeBTN.Checked)
            {

                ready4Play++;
                faceBOX.Visible = false;
                if (rd_bt_choose_image.Checked)
                {
                    original_Image = new Image<Bgr, byte>(openFileDialog1.FileName);
                }
                else if (rd_bt_open_cam.Checked)
                {
                    original_Image = capture_cam.QueryFrame();
                }

                smoothed_Image = original_Image.PyrDown().PyrUp();
                smoothed_Image._SmoothGaussian(3);


                Gray gray_Cannay_threshold = new Gray(160);
                Gray gray_Circle_Cannay_threshold = new Gray(100);
                Gray gray_threshold_Linking = new Gray(80);

                gray_Image = original_Image.Convert<Gray, byte>();
                cannay_Image = gray_Image.Canny(gray_Cannay_threshold, gray_threshold_Linking);

                detected_Image = original_Image.CopyBlank();

                double db_Accum_res = 2.0;
                double min_distance_between_circles = gray_Image.Height / 4;
                int min_radius = 10;
                int max_radius = 4000;
                CircleF[] circles = gray_Image.HoughCircles(gray_Cannay_threshold, gray_Circle_Cannay_threshold, db_Accum_res, min_distance_between_circles, min_radius, max_radius)[0];

                foreach (CircleF circle in circles)
                {
                    detected_Image.Draw(circle, new Bgr(Color.Red), 2);
                }

                double db_line_res = 1.0;
                double db_line_angle_res = 4.0 * (Math.PI / 180.0);
                int line_threshold = 20;
                double min_line_width = 30.0;
                double max_line_height = 10.0;

                LineSegment2D[] lines = cannay_Image.HoughLinesBinary(db_line_res, db_line_angle_res, line_threshold, min_line_width, max_line_height)[0];

                foreach (LineSegment2D line in lines)
                {
                    detected_Image.Draw(line, new Bgr(Color.Green), 2);
                }

                Contour<Point> contours = cannay_Image.FindContours();
                List<Triangle2DF> triangles = new List<Triangle2DF>();
                List<MCvBox2D> rectangles = new List<MCvBox2D>();
                List<Contour<Point>> polygon = new List<Contour<Point>>();

                while (contours != null)
                {
                    Contour<Point> contour = contours.ApproxPoly(10.0);
                    if (contour.Area > 250.0)
                    {
                        if (contour.Total == 3)
                        {
                            Point[] points = contour.ToArray();
                            triangles.Add(new Triangle2DF(points[0], points[1], points[2]));
                        }
                        else if (contour.Total >= 4 && contour.Total <= 6)
                        {
                            Point[] points = contour.ToArray();
                            bool isRect = true;
                            if (contour.Total == 4)
                            {
                                LineSegment2D[] edges = PointCollection.PolyLine(points, true);
                                for (int i = 0; i < edges.Length; i++)
                                {
                                    double angle = Math.Abs(edges[(i + 1) % edges.Length].GetExteriorAngleDegree(edges[i]));
                                    if (angle < 80 || angle > 100)
                                        isRect = false;
                                }
                            }
                            else
                                isRect = false;
                            if (isRect)
                                rectangles.Add(contour.GetMinAreaRect());
                            else
                                polygon.Add(contour);

                        }
                    }
                    contours = contours.HNext;
                }
                foreach (Triangle2DF triangle in triangles)
                {
                    detected_Image.Draw(triangle, new Bgr(Color.Yellow), 2);

                }
                foreach (MCvBox2D rect in rectangles)
                {
                    detected_Image.Draw(rect, new Bgr(Color.Purple), 2);

                }
                foreach (Contour<Point> poly in polygon)
                {
                    detected_Image.Draw(poly, new Bgr(Color.Orange), 2);

                }

                //if (rd_bt_choose_image.Checked)
                //{
                imageBox2.Image = original_Image;
                imageBox3.Image = detected_Image;
                //}
            }


            ////////////////////////////////////////////////////////////////////////

            if (faceBTN.Checked)
            {
                ready4Play2++;

                if (imageBox2.Visible == true || imageBox2.Visible == true || imageBox3.Visible == true)
                {
                    imageBox2.Visible = false;
                    imageBox3.Visible = false;
                    tableLayoutPanel1.Visible = false;
                }

                faceBOX.Visible = true;

                if (rd_bt_choose_image.Checked)
                {
                    original_img = new Image<Bgr, byte>(txt_bx_img_path.Text);

                }
                else if (rd_bt_open_cam.Checked)
                {
                    original_img = capture_cam.QueryFrame();
                }





                original_gray = original_img.Convert<Gray, byte>();

                detected_faces = haar_obj.Detect(original_gray, scale, min_neighbor, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(win_size, win_size), new Size(win_size, win_size));
                //MessageBox.Show(detected_faces.Length.ToString());

                if (detected_faces.Length > 0)
                {
                    Bitmap input = original_gray.ToBitmap();
                    Bitmap extracted_face;
                    Graphics face_canva;
                    foreach (MCvAvgComp face in detected_faces)
                    {
                        original_img.Draw(face.rect, new Bgr(Color.Red), 3);
                        extracted_face = new Bitmap(face.rect.Width, face.rect.Height);
                        face_canva = Graphics.FromImage(extracted_face);
                        face_canva.DrawImage(input, 0, 0, face.rect, GraphicsUnit.Pixel);

                    }
                }

                faceBOX.Image = original_img.Resize(faceBOX.Width, faceBOX.Height, INTER.CV_INTER_LINEAR);


            }




            if (ready4Play > 0 && ready4Play2 > 0 )
            {
                gameBTN.Visible = true;
                
            }



        }


        private void btnClose_MouseDown(object sender, MouseEventArgs e)
        {

            btnClose.BackgroundImage = Image.FromFile(@"D:\GitHubGeneral\FaceShapeDetectionThenPlayDifferenceGame\FaceShapeDetectionThenPlayDifferenceGame\Resources\OFF.png");
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Image.FromFile(@"D:\GitHubGeneral\FaceShapeDetectionThenPlayDifferenceGame\FaceShapeDetectionThenPlayDifferenceGame\Resources\exitHover.png");
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Image.FromFile(@"D:\GitHubGeneral\FaceShapeDetectionThenPlayDifferenceGame\FaceShapeDetectionThenPlayDifferenceGame\Resources\exit.png");
        }

        private void btnClose_MouseUp(object sender, MouseEventArgs e)
        {
            btnClose.BackgroundImage = Image.FromFile(@"D:\GitHubGeneral\FaceShapeDetectionThenPlayDifferenceGame\FaceShapeDetectionThenPlayDifferenceGame\Resources\exit.png");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseMove(object sender, MouseEventArgs e)
        {
            btnClose.BackgroundImage = Image.FromFile(@"D:\GitHubGeneral\FaceShapeDetectionThenPlayDifferenceGame\FaceShapeDetectionThenPlayDifferenceGame\Resources\exitHover.png");
        }






        private void btnStart_MouseDown(object sender, MouseEventArgs e)
        {
            btnStart.BackgroundImage = Image.FromFile(@"D:\GitHubGeneral\FaceShapeDetectionThenPlayDifferenceGame\FaceShapeDetectionThenPlayDifferenceGame\Resources\startON.png");
        }

        private void btnStart_MouseHover(object sender, EventArgs e)
        {
            btnStart.BackgroundImage = Image.FromFile(@"D:\GitHubGeneral\FaceShapeDetectionThenPlayDifferenceGame\FaceShapeDetectionThenPlayDifferenceGame\Resources\startHoveer.png");
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.BackgroundImage = Image.FromFile(@"D:\GitHubGeneral\FaceShapeDetectionThenPlayDifferenceGame\FaceShapeDetectionThenPlayDifferenceGame\Resources\startHoveer.png");
        }

        private void btnStart_MouseMove(object sender, MouseEventArgs e)
        {
            btnStart.BackgroundImage = Image.FromFile(@"D:\GitHubGeneral\FaceShapeDetectionThenPlayDifferenceGame\FaceShapeDetectionThenPlayDifferenceGame\Resources\startHoveer.png");
        }

        private void btnStart_MouseUp(object sender, MouseEventArgs e)
        {
            btnStart.BackgroundImage = Image.FromFile(@"D:\GitHubGeneral\FaceShapeDetectionThenPlayDifferenceGame\FaceShapeDetectionThenPlayDifferenceGame\Resources\start.png");
        }
       
        private int _ticks = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_ticks > 0)
            {
                _ticks--;
            }
            lblTime.Text = _ticks.ToString();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            lblMaxDiff.Text = "5";
            imageCopy.Enabled = true;
            gameBTN.Visible = false;
        }




        private void imageCopy_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("this is a click");
            for (int i = 0; i < 5; i++)
            {
                if (e.X >= distination[i, 6] && e.X <= distination[i, 7] && e.Y >= distination[i, 4] && e.Y <= distination[i, 5])
                {
                    Console.WriteLine("e.x: " + e.X + " e.y: " + e.Y + "  dist i 0 : " + distination[i, 0] + "  dist i 1 : " + distination[i, 1]
                        + "  dist i 2 : " + distination[i, 2] + "  dist i 3 : " + distination[i, 3] + "  dist i 4 : " + distination[i, 4] + "  dist i 5 : " + distination[i, 5]
                        + "  dist i 6 : " + distination[i, 6] + "  dist i 7 : " + distination[i, 7]);

                    Rectangle rec = new Rectangle(distination[i, 0], distination[i, 1], distination[i, 2], distination[i, 3]);
                    image1.Draw(rec, new Bgr(Color.Red), 2);
                    if (distination[i, 8] == 0)
                    {
                        distination[i, 8] = 1;
                        selected++;
                    }

                    imageOriginal.Image = image1;
                }
            }


            lblFindDiff.Text = selected.ToString();
            if (selected == 5)
            {
                wellDoneLbl.Visible = true;
            }
        }

        private void gameBTN_Click(object sender, EventArgs e)
        {
            red4Ply.Text = "Now U can play the Game ^_^";
            faceBOX.Visible = false;
            imageBox2.Visible = false;
            imageBox3.Visible = false;
            Time.Visible = true;
            lblTime.Visible = true;
            catched.Visible = true;
            lblFindDiff.Visible = true;
            slash.Visible = true;
            btnStart.Visible = true;
            btnClose.Visible = true;
            imageOriginal.Visible = true;
            imageCopy.Visible = true;
            lblMaxDiff.Visible = true;
        }

      


     


        







    }
}
