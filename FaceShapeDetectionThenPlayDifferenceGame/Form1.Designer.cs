namespace FaceShapeDetectionThenPlayDifferenceGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_bt_open_cam = new System.Windows.Forms.RadioButton();
            this.rd_bt_choose_image = new System.Windows.Forms.RadioButton();
            this.txt_bx_img_path = new System.Windows.Forms.TextBox();
            this.bt_choose_img = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.shapeBTN = new System.Windows.Forms.RadioButton();
            this.faceBTN = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.Time = new System.Windows.Forms.Label();
            this.catched = new System.Windows.Forms.Label();
            this.slash = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblFindDiff = new System.Windows.Forms.Label();
            this.lblMaxDiff = new System.Windows.Forms.Label();
            this.red4Ply = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageCopy = new Emgu.CV.UI.ImageBox();
            this.imageOriginal = new Emgu.CV.UI.ImageBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.PictureBox();
            this.faceBOX = new Emgu.CV.UI.ImageBox();
            this.gameBTN = new System.Windows.Forms.Button();
            this.wellDoneLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_bt_open_cam);
            this.groupBox1.Controls.Add(this.rd_bt_choose_image);
            this.groupBox1.Location = new System.Drawing.Point(13, 442);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 47);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Option:";
            // 
            // rd_bt_open_cam
            // 
            this.rd_bt_open_cam.AutoSize = true;
            this.rd_bt_open_cam.Location = new System.Drawing.Point(99, 20);
            this.rd_bt_open_cam.Name = "rd_bt_open_cam";
            this.rd_bt_open_cam.Size = new System.Drawing.Size(72, 17);
            this.rd_bt_open_cam.TabIndex = 1;
            this.rd_bt_open_cam.Text = "Web Cam";
            this.rd_bt_open_cam.UseVisualStyleBackColor = true;
            this.rd_bt_open_cam.CheckedChanged += new System.EventHandler(this.rd_bt_open_cam_CheckedChanged);
            // 
            // rd_bt_choose_image
            // 
            this.rd_bt_choose_image.AutoSize = true;
            this.rd_bt_choose_image.Checked = true;
            this.rd_bt_choose_image.Location = new System.Drawing.Point(7, 20);
            this.rd_bt_choose_image.Name = "rd_bt_choose_image";
            this.rd_bt_choose_image.Size = new System.Drawing.Size(93, 17);
            this.rd_bt_choose_image.TabIndex = 0;
            this.rd_bt_choose_image.TabStop = true;
            this.rd_bt_choose_image.Text = "Choose Image";
            this.rd_bt_choose_image.UseVisualStyleBackColor = true;
            this.rd_bt_choose_image.CheckedChanged += new System.EventHandler(this.rd_bt_choose_image_CheckedChanged);
            // 
            // txt_bx_img_path
            // 
            this.txt_bx_img_path.Location = new System.Drawing.Point(271, 442);
            this.txt_bx_img_path.Name = "txt_bx_img_path";
            this.txt_bx_img_path.Size = new System.Drawing.Size(210, 20);
            this.txt_bx_img_path.TabIndex = 4;
            // 
            // bt_choose_img
            // 
            this.bt_choose_img.Location = new System.Drawing.Point(334, 466);
            this.bt_choose_img.Name = "bt_choose_img";
            this.bt_choose_img.Size = new System.Drawing.Size(75, 23);
            this.bt_choose_img.TabIndex = 5;
            this.bt_choose_img.Text = "Add";
            this.bt_choose_img.UseVisualStyleBackColor = true;
            this.bt_choose_img.Click += new System.EventHandler(this.bt_choose_img_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.shapeBTN);
            this.groupBox2.Controls.Add(this.faceBTN);
            this.groupBox2.Location = new System.Drawing.Point(820, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 97);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "What 2  Do";
            // 
            // shapeBTN
            // 
            this.shapeBTN.AutoSize = true;
            this.shapeBTN.Location = new System.Drawing.Point(6, 43);
            this.shapeBTN.Name = "shapeBTN";
            this.shapeBTN.Size = new System.Drawing.Size(105, 17);
            this.shapeBTN.TabIndex = 11;
            this.shapeBTN.TabStop = true;
            this.shapeBTN.Text = "Shape Detection";
            this.shapeBTN.UseVisualStyleBackColor = true;
            // 
            // faceBTN
            // 
            this.faceBTN.AutoSize = true;
            this.faceBTN.Checked = true;
            this.faceBTN.Location = new System.Drawing.Point(6, 19);
            this.faceBTN.Name = "faceBTN";
            this.faceBTN.Size = new System.Drawing.Size(98, 17);
            this.faceBTN.TabIndex = 10;
            this.faceBTN.TabStop = true;
            this.faceBTN.Text = "Face Detection";
            this.faceBTN.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51F));
            this.tableLayoutPanel1.Controls.Add(this.imageBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageBox3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(48, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 303F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(728, 303);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // imageBox2
            // 
            this.imageBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox2.Location = new System.Drawing.Point(3, 3);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(350, 297);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // imageBox3
            // 
            this.imageBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox3.Location = new System.Drawing.Point(359, 3);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(366, 297);
            this.imageBox3.TabIndex = 2;
            this.imageBox3.TabStop = false;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Time.Location = new System.Drawing.Point(827, 203);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(69, 21);
            this.Time.TabIndex = 19;
            this.Time.Text = "Time :";
            this.Time.Visible = false;
            // 
            // catched
            // 
            this.catched.AutoSize = true;
            this.catched.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catched.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.catched.Location = new System.Drawing.Point(816, 278);
            this.catched.Name = "catched";
            this.catched.Size = new System.Drawing.Size(99, 24);
            this.catched.TabIndex = 20;
            this.catched.Text = "Catched : ";
            this.catched.Visible = false;
            // 
            // slash
            // 
            this.slash.AutoSize = true;
            this.slash.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slash.Location = new System.Drawing.Point(962, 276);
            this.slash.Name = "slash";
            this.slash.Size = new System.Drawing.Size(23, 27);
            this.slash.TabIndex = 21;
            this.slash.Text = "/";
            this.slash.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(899, 200);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(62, 24);
            this.lblTime.TabIndex = 22;
            this.lblTime.Text = "0000";
            this.lblTime.Visible = false;
            // 
            // lblFindDiff
            // 
            this.lblFindDiff.AutoSize = true;
            this.lblFindDiff.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindDiff.Location = new System.Drawing.Point(939, 279);
            this.lblFindDiff.Name = "lblFindDiff";
            this.lblFindDiff.Size = new System.Drawing.Size(22, 24);
            this.lblFindDiff.TabIndex = 23;
            this.lblFindDiff.Text = "0";
            this.lblFindDiff.Visible = false;
            // 
            // lblMaxDiff
            // 
            this.lblMaxDiff.AutoSize = true;
            this.lblMaxDiff.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxDiff.Location = new System.Drawing.Point(977, 278);
            this.lblMaxDiff.Name = "lblMaxDiff";
            this.lblMaxDiff.Size = new System.Drawing.Size(22, 21);
            this.lblMaxDiff.TabIndex = 24;
            this.lblMaxDiff.Text = "5";
            this.lblMaxDiff.Visible = false;
            // 
            // red4Ply
            // 
            this.red4Ply.AutoSize = true;
            this.red4Ply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.red4Ply.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.red4Ply.Location = new System.Drawing.Point(823, 25);
            this.red4Ply.Name = "red4Ply";
            this.red4Ply.Size = new System.Drawing.Size(181, 24);
            this.red4Ply.TabIndex = 27;
            this.red4Ply.Text = "Not allwoed 2 play";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageCopy
            // 
            this.imageCopy.BackColor = System.Drawing.Color.Transparent;
            this.imageCopy.Enabled = false;
            this.imageCopy.Location = new System.Drawing.Point(400, 2);
            this.imageCopy.Name = "imageCopy";
            this.imageCopy.Size = new System.Drawing.Size(324, 414);
            this.imageCopy.TabIndex = 29;
            this.imageCopy.TabStop = false;
            this.imageCopy.Visible = false;
            this.imageCopy.WaitOnLoad = true;
            this.imageCopy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imageCopy_MouseClick);
            // 
            // imageOriginal
            // 
            this.imageOriginal.BackColor = System.Drawing.Color.Transparent;
            this.imageOriginal.Enabled = false;
            this.imageOriginal.Location = new System.Drawing.Point(20, 2);
            this.imageOriginal.Name = "imageOriginal";
            this.imageOriginal.Size = new System.Drawing.Size(324, 414);
            this.imageOriginal.TabIndex = 28;
            this.imageOriginal.TabStop = false;
            this.imageOriginal.Visible = false;
            this.imageOriginal.WaitOnLoad = true;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::FaceShapeDetectionThenPlayDifferenceGame.Properties.Resources.OFF;
            this.btnClose.Location = new System.Drawing.Point(913, 358);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 131);
            this.btnClose.TabIndex = 26;
            this.btnClose.TabStop = false;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseDown);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            this.btnClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseMove);
            this.btnClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseUp);
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = global::FaceShapeDetectionThenPlayDifferenceGame.Properties.Resources.ON;
            this.btnStart.Location = new System.Drawing.Point(793, 358);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(118, 121);
            this.btnStart.TabIndex = 25;
            this.btnStart.TabStop = false;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStart_MouseDown);
            this.btnStart.MouseLeave += new System.EventHandler(this.btnStart_MouseLeave);
            this.btnStart.MouseHover += new System.EventHandler(this.btnStart_MouseHover);
            this.btnStart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnStart_MouseMove);
            this.btnStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStart_MouseUp);
            // 
            // faceBOX
            // 
            this.faceBOX.Location = new System.Drawing.Point(13, 2);
            this.faceBOX.Name = "faceBOX";
            this.faceBOX.Size = new System.Drawing.Size(774, 424);
            this.faceBOX.TabIndex = 14;
            this.faceBOX.TabStop = false;
            // 
            // gameBTN
            // 
            this.gameBTN.BackColor = System.Drawing.Color.Maroon;
            this.gameBTN.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameBTN.ForeColor = System.Drawing.Color.Snow;
            this.gameBTN.Location = new System.Drawing.Point(869, 53);
            this.gameBTN.Name = "gameBTN";
            this.gameBTN.Size = new System.Drawing.Size(92, 29);
            this.gameBTN.TabIndex = 12;
            this.gameBTN.Text = "click here";
            this.gameBTN.UseVisualStyleBackColor = false;
            this.gameBTN.Visible = false;
            this.gameBTN.Click += new System.EventHandler(this.gameBTN_Click);
            // 
            // wellDoneLbl
            // 
            this.wellDoneLbl.AutoSize = true;
            this.wellDoneLbl.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wellDoneLbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.wellDoneLbl.Location = new System.Drawing.Point(816, 317);
            this.wellDoneLbl.Name = "wellDoneLbl";
            this.wellDoneLbl.Size = new System.Drawing.Size(113, 21);
            this.wellDoneLbl.TabIndex = 30;
            this.wellDoneLbl.Text = "Well Done ";
            this.wellDoneLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 506);
            this.Controls.Add(this.wellDoneLbl);
            this.Controls.Add(this.gameBTN);
            this.Controls.Add(this.imageCopy);
            this.Controls.Add(this.imageOriginal);
            this.Controls.Add(this.red4Ply);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblMaxDiff);
            this.Controls.Add(this.lblFindDiff);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.slash);
            this.Controls.Add(this.catched);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.faceBOX);
            this.Controls.Add(this.bt_choose_img);
            this.Controls.Add(this.txt_bx_img_path);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Face Detection Program";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceBOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_bt_open_cam;
        private System.Windows.Forms.RadioButton rd_bt_choose_image;
        private System.Windows.Forms.TextBox txt_bx_img_path;
        private System.Windows.Forms.Button bt_choose_img;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Emgu.CV.UI.ImageBox faceBOX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton shapeBTN;
        private System.Windows.Forms.RadioButton faceBTN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private Emgu.CV.UI.ImageBox imageBox3;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label catched;
        private System.Windows.Forms.Label slash;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblFindDiff;
        private System.Windows.Forms.Label lblMaxDiff;
        private System.Windows.Forms.PictureBox btnStart;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label red4Ply;
        private Emgu.CV.UI.ImageBox imageOriginal;
        private Emgu.CV.UI.ImageBox imageCopy;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button gameBTN;
        private System.Windows.Forms.Label wellDoneLbl;
    }
}

