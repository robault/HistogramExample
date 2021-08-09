namespace HistogramExample
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
            this.label1 = new System.Windows.Forms.Label();
            this.imagePathTextBox = new System.Windows.Forms.TextBox();
            this.imagePathButton = new System.Windows.Forms.Button();
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.greenRadioButton = new System.Windows.Forms.RadioButton();
            this.blueRadioButton = new System.Windows.Forms.RadioButton();
            this.luminosityRadioButton = new System.Windows.Forms.RadioButton();
            this.histogramPictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.channelColorPictureBox = new System.Windows.Forms.PictureBox();
            this.colorValueLabel = new System.Windows.Forms.Label();
            this.fullRGBRadioButton = new System.Windows.Forms.RadioButton();
            this.redPictureBox = new System.Windows.Forms.PictureBox();
            this.greenPictureBox = new System.Windows.Forms.PictureBox();
            this.bluePictureBox = new System.Windows.Forms.PictureBox();
            this.whitePictureBox = new System.Windows.Forms.PictureBox();
            this.blackPictureBox = new System.Windows.Forms.PictureBox();
            this.blackAndWhitePictureBox = new System.Windows.Forms.PictureBox();
            this.cascadePictureBox1 = new System.Windows.Forms.PictureBox();
            this.cascadePictureBox2 = new System.Windows.Forms.PictureBox();
            this.cascadePictureBox3 = new System.Windows.Forms.PictureBox();
            this.cascadePictureBox4 = new System.Windows.Forms.PictureBox();
            this.cascadePictureBox5 = new System.Windows.Forms.PictureBox();
            this.cascadePictureBox6 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cascadePictureBox7 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cascadePictureBox8 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cascadePictureBox9 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.procTimeLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.imageSizeLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.croppedImagePictureBox = new System.Windows.Forms.PictureBox();
            this.cascadeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whitePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackAndWhitePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cascadePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cascadePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cascadePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cascadePictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cascadePictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cascadePictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cascadePictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cascadePictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cascadePictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.croppedImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose in image:";
            // 
            // imagePathTextBox
            // 
            this.imagePathTextBox.Location = new System.Drawing.Point(15, 25);
            this.imagePathTextBox.Name = "imagePathTextBox";
            this.imagePathTextBox.Size = new System.Drawing.Size(400, 20);
            this.imagePathTextBox.TabIndex = 1;
            // 
            // imagePathButton
            // 
            this.imagePathButton.Location = new System.Drawing.Point(421, 25);
            this.imagePathButton.Name = "imagePathButton";
            this.imagePathButton.Size = new System.Drawing.Size(25, 20);
            this.imagePathButton.TabIndex = 2;
            this.imagePathButton.Text = "...";
            this.imagePathButton.UseVisualStyleBackColor = true;
            this.imagePathButton.Click += new System.EventHandler(this.imagePathButton_Click);
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalPictureBox.Location = new System.Drawing.Point(15, 77);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(256, 256);
            this.originalPictureBox.TabIndex = 3;
            this.originalPictureBox.TabStop = false;
            this.originalPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.originalPictureBox_Paint);
            this.originalPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.originalPictureBox_MouseDown);
            this.originalPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.originalPictureBox_MouseMove);
            this.originalPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.originalPictureBox_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Original Image:";
            // 
            // redRadioButton
            // 
            this.redRadioButton.AutoSize = true;
            this.redRadioButton.Location = new System.Drawing.Point(305, 77);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(45, 17);
            this.redRadioButton.TabIndex = 5;
            this.redRadioButton.TabStop = true;
            this.redRadioButton.Text = "Red";
            this.redRadioButton.UseVisualStyleBackColor = true;
            this.redRadioButton.CheckedChanged += new System.EventHandler(this.redRadioButton_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Histogram:";
            // 
            // greenRadioButton
            // 
            this.greenRadioButton.AutoSize = true;
            this.greenRadioButton.Location = new System.Drawing.Point(305, 100);
            this.greenRadioButton.Name = "greenRadioButton";
            this.greenRadioButton.Size = new System.Drawing.Size(54, 17);
            this.greenRadioButton.TabIndex = 7;
            this.greenRadioButton.TabStop = true;
            this.greenRadioButton.Text = "Green";
            this.greenRadioButton.UseVisualStyleBackColor = true;
            this.greenRadioButton.CheckedChanged += new System.EventHandler(this.greenRadioButton_CheckedChanged);
            // 
            // blueRadioButton
            // 
            this.blueRadioButton.AutoSize = true;
            this.blueRadioButton.Location = new System.Drawing.Point(305, 123);
            this.blueRadioButton.Name = "blueRadioButton";
            this.blueRadioButton.Size = new System.Drawing.Size(46, 17);
            this.blueRadioButton.TabIndex = 8;
            this.blueRadioButton.TabStop = true;
            this.blueRadioButton.Text = "Blue";
            this.blueRadioButton.UseVisualStyleBackColor = true;
            this.blueRadioButton.CheckedChanged += new System.EventHandler(this.blueRadioButton_CheckedChanged);
            // 
            // luminosityRadioButton
            // 
            this.luminosityRadioButton.AutoSize = true;
            this.luminosityRadioButton.Location = new System.Drawing.Point(305, 146);
            this.luminosityRadioButton.Name = "luminosityRadioButton";
            this.luminosityRadioButton.Size = new System.Drawing.Size(74, 17);
            this.luminosityRadioButton.TabIndex = 9;
            this.luminosityRadioButton.TabStop = true;
            this.luminosityRadioButton.Text = "Luminosity";
            this.luminosityRadioButton.UseVisualStyleBackColor = true;
            this.luminosityRadioButton.CheckedChanged += new System.EventHandler(this.luminosityRadioButton_CheckedChanged);
            // 
            // histogramPictureBox
            // 
            this.histogramPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.histogramPictureBox.Location = new System.Drawing.Point(402, 77);
            this.histogramPictureBox.Name = "histogramPictureBox";
            this.histogramPictureBox.Size = new System.Drawing.Size(256, 256);
            this.histogramPictureBox.TabIndex = 10;
            this.histogramPictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Average Color:";
            // 
            // channelColorPictureBox
            // 
            this.channelColorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.channelColorPictureBox.Location = new System.Drawing.Point(605, 50);
            this.channelColorPictureBox.Name = "channelColorPictureBox";
            this.channelColorPictureBox.Size = new System.Drawing.Size(24, 24);
            this.channelColorPictureBox.TabIndex = 12;
            this.channelColorPictureBox.TabStop = false;
            // 
            // colorValueLabel
            // 
            this.colorValueLabel.AutoSize = true;
            this.colorValueLabel.Location = new System.Drawing.Point(635, 58);
            this.colorValueLabel.Name = "colorValueLabel";
            this.colorValueLabel.Size = new System.Drawing.Size(10, 13);
            this.colorValueLabel.TabIndex = 13;
            this.colorValueLabel.Text = ".";
            // 
            // fullRGBRadioButton
            // 
            this.fullRGBRadioButton.AutoSize = true;
            this.fullRGBRadioButton.Location = new System.Drawing.Point(305, 169);
            this.fullRGBRadioButton.Name = "fullRGBRadioButton";
            this.fullRGBRadioButton.Size = new System.Drawing.Size(67, 17);
            this.fullRGBRadioButton.TabIndex = 14;
            this.fullRGBRadioButton.TabStop = true;
            this.fullRGBRadioButton.Text = "Full RGB";
            this.fullRGBRadioButton.UseVisualStyleBackColor = true;
            this.fullRGBRadioButton.CheckedChanged += new System.EventHandler(this.fullRGBRadioButton_CheckedChanged);
            // 
            // redPictureBox
            // 
            this.redPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redPictureBox.Location = new System.Drawing.Point(15, 356);
            this.redPictureBox.Name = "redPictureBox";
            this.redPictureBox.Size = new System.Drawing.Size(200, 200);
            this.redPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redPictureBox.TabIndex = 15;
            this.redPictureBox.TabStop = false;
            // 
            // greenPictureBox
            // 
            this.greenPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greenPictureBox.Location = new System.Drawing.Point(236, 356);
            this.greenPictureBox.Name = "greenPictureBox";
            this.greenPictureBox.Size = new System.Drawing.Size(200, 200);
            this.greenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greenPictureBox.TabIndex = 16;
            this.greenPictureBox.TabStop = false;
            // 
            // bluePictureBox
            // 
            this.bluePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bluePictureBox.Location = new System.Drawing.Point(458, 356);
            this.bluePictureBox.Name = "bluePictureBox";
            this.bluePictureBox.Size = new System.Drawing.Size(200, 200);
            this.bluePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bluePictureBox.TabIndex = 17;
            this.bluePictureBox.TabStop = false;
            // 
            // whitePictureBox
            // 
            this.whitePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.whitePictureBox.Location = new System.Drawing.Point(458, 570);
            this.whitePictureBox.Name = "whitePictureBox";
            this.whitePictureBox.Size = new System.Drawing.Size(200, 200);
            this.whitePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.whitePictureBox.TabIndex = 20;
            this.whitePictureBox.TabStop = false;
            // 
            // blackPictureBox
            // 
            this.blackPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blackPictureBox.Location = new System.Drawing.Point(236, 570);
            this.blackPictureBox.Name = "blackPictureBox";
            this.blackPictureBox.Size = new System.Drawing.Size(200, 200);
            this.blackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blackPictureBox.TabIndex = 19;
            this.blackPictureBox.TabStop = false;
            // 
            // blackAndWhitePictureBox
            // 
            this.blackAndWhitePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blackAndWhitePictureBox.Location = new System.Drawing.Point(15, 570);
            this.blackAndWhitePictureBox.Name = "blackAndWhitePictureBox";
            this.blackAndWhitePictureBox.Size = new System.Drawing.Size(200, 200);
            this.blackAndWhitePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blackAndWhitePictureBox.TabIndex = 18;
            this.blackAndWhitePictureBox.TabStop = false;
            // 
            // cascadePictureBox1
            // 
            this.cascadePictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cascadePictureBox1.Location = new System.Drawing.Point(683, 25);
            this.cascadePictureBox1.Name = "cascadePictureBox1";
            this.cascadePictureBox1.Size = new System.Drawing.Size(100, 100);
            this.cascadePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cascadePictureBox1.TabIndex = 21;
            this.cascadePictureBox1.TabStop = false;
            // 
            // cascadePictureBox2
            // 
            this.cascadePictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cascadePictureBox2.Location = new System.Drawing.Point(683, 146);
            this.cascadePictureBox2.Name = "cascadePictureBox2";
            this.cascadePictureBox2.Size = new System.Drawing.Size(100, 100);
            this.cascadePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cascadePictureBox2.TabIndex = 22;
            this.cascadePictureBox2.TabStop = false;
            // 
            // cascadePictureBox3
            // 
            this.cascadePictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cascadePictureBox3.Location = new System.Drawing.Point(683, 265);
            this.cascadePictureBox3.Name = "cascadePictureBox3";
            this.cascadePictureBox3.Size = new System.Drawing.Size(100, 100);
            this.cascadePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cascadePictureBox3.TabIndex = 23;
            this.cascadePictureBox3.TabStop = false;
            // 
            // cascadePictureBox4
            // 
            this.cascadePictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cascadePictureBox4.Location = new System.Drawing.Point(683, 384);
            this.cascadePictureBox4.Name = "cascadePictureBox4";
            this.cascadePictureBox4.Size = new System.Drawing.Size(100, 100);
            this.cascadePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cascadePictureBox4.TabIndex = 24;
            this.cascadePictureBox4.TabStop = false;
            // 
            // cascadePictureBox5
            // 
            this.cascadePictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cascadePictureBox5.Location = new System.Drawing.Point(683, 503);
            this.cascadePictureBox5.Name = "cascadePictureBox5";
            this.cascadePictureBox5.Size = new System.Drawing.Size(100, 100);
            this.cascadePictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cascadePictureBox5.TabIndex = 25;
            this.cascadePictureBox5.TabStop = false;
            // 
            // cascadePictureBox6
            // 
            this.cascadePictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cascadePictureBox6.Location = new System.Drawing.Point(683, 622);
            this.cascadePictureBox6.Name = "cascadePictureBox6";
            this.cascadePictureBox6.Size = new System.Drawing.Size(100, 100);
            this.cascadePictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cascadePictureBox6.TabIndex = 26;
            this.cascadePictureBox6.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(680, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "100%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(680, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "75%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(680, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "50%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(680, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "25%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(680, 487);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "12.5%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(680, 606);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "6.25%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(786, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "4.6875%";
            // 
            // cascadePictureBox7
            // 
            this.cascadePictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cascadePictureBox7.Location = new System.Drawing.Point(789, 25);
            this.cascadePictureBox7.Name = "cascadePictureBox7";
            this.cascadePictureBox7.Size = new System.Drawing.Size(100, 100);
            this.cascadePictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cascadePictureBox7.TabIndex = 33;
            this.cascadePictureBox7.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(786, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "3.515625%";
            // 
            // cascadePictureBox8
            // 
            this.cascadePictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cascadePictureBox8.Location = new System.Drawing.Point(789, 146);
            this.cascadePictureBox8.Name = "cascadePictureBox8";
            this.cascadePictureBox8.Size = new System.Drawing.Size(100, 100);
            this.cascadePictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cascadePictureBox8.TabIndex = 35;
            this.cascadePictureBox8.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(786, 249);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "2.63671875%";
            // 
            // cascadePictureBox9
            // 
            this.cascadePictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cascadePictureBox9.Location = new System.Drawing.Point(789, 265);
            this.cascadePictureBox9.Name = "cascadePictureBox9";
            this.cascadePictureBox9.Size = new System.Drawing.Size(100, 100);
            this.cascadePictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cascadePictureBox9.TabIndex = 37;
            this.cascadePictureBox9.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(277, 220);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Time (ms):";
            // 
            // procTimeLabel
            // 
            this.procTimeLabel.AutoSize = true;
            this.procTimeLabel.Location = new System.Drawing.Point(368, 220);
            this.procTimeLabel.Name = "procTimeLabel";
            this.procTimeLabel.Size = new System.Drawing.Size(13, 13);
            this.procTimeLabel.TabIndex = 40;
            this.procTimeLabel.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(277, 249);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Size:";
            // 
            // imageSizeLabel
            // 
            this.imageSizeLabel.AutoSize = true;
            this.imageSizeLabel.Location = new System.Drawing.Point(318, 249);
            this.imageSizeLabel.Name = "imageSizeLabel";
            this.imageSizeLabel.Size = new System.Drawing.Size(54, 13);
            this.imageSizeLabel.TabIndex = 42;
            this.imageSizeLabel.Text = "160 x 120";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(906, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Selected Image:";
            // 
            // croppedImagePictureBox
            // 
            this.croppedImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.croppedImagePictureBox.Location = new System.Drawing.Point(909, 25);
            this.croppedImagePictureBox.Name = "croppedImagePictureBox";
            this.croppedImagePictureBox.Size = new System.Drawing.Size(200, 200);
            this.croppedImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.croppedImagePictureBox.TabIndex = 44;
            this.croppedImagePictureBox.TabStop = false;
            // 
            // cascadeButton
            // 
            this.cascadeButton.Location = new System.Drawing.Point(1034, 231);
            this.cascadeButton.Name = "cascadeButton";
            this.cascadeButton.Size = new System.Drawing.Size(75, 23);
            this.cascadeButton.TabIndex = 45;
            this.cascadeButton.Text = "Cascade";
            this.cascadeButton.UseVisualStyleBackColor = true;
            this.cascadeButton.Click += new System.EventHandler(this.cascadeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 782);
            this.Controls.Add(this.cascadeButton);
            this.Controls.Add(this.croppedImagePictureBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.imageSizeLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.procTimeLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cascadePictureBox9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cascadePictureBox8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cascadePictureBox7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cascadePictureBox6);
            this.Controls.Add(this.cascadePictureBox5);
            this.Controls.Add(this.cascadePictureBox4);
            this.Controls.Add(this.cascadePictureBox3);
            this.Controls.Add(this.cascadePictureBox2);
            this.Controls.Add(this.cascadePictureBox1);
            this.Controls.Add(this.whitePictureBox);
            this.Controls.Add(this.blackPictureBox);
            this.Controls.Add(this.blackAndWhitePictureBox);
            this.Controls.Add(this.bluePictureBox);
            this.Controls.Add(this.greenPictureBox);
            this.Controls.Add(this.redPictureBox);
            this.Controls.Add(this.fullRGBRadioButton);
            this.Controls.Add(this.colorValueLabel);
            this.Controls.Add(this.channelColorPictureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.histogramPictureBox);
            this.Controls.Add(this.luminosityRadioButton);
            this.Controls.Add(this.blueRadioButton);
            this.Controls.Add(this.greenRadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.redRadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.originalPictureBox);
            this.Controls.Add(this.imagePathButton);
            this.Controls.Add(this.imagePathTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Histogram Example";
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whitePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackAndWhitePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cascadePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cascadePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cascadePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cascadePictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cascadePictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cascadePictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cascadePictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cascadePictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cascadePictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.croppedImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imagePathTextBox;
        private System.Windows.Forms.Button imagePathButton;
        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton redRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton greenRadioButton;
        private System.Windows.Forms.RadioButton blueRadioButton;
        private System.Windows.Forms.RadioButton luminosityRadioButton;
        private System.Windows.Forms.PictureBox histogramPictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox channelColorPictureBox;
        private System.Windows.Forms.Label colorValueLabel;
        private System.Windows.Forms.RadioButton fullRGBRadioButton;
        private System.Windows.Forms.PictureBox redPictureBox;
        private System.Windows.Forms.PictureBox greenPictureBox;
        private System.Windows.Forms.PictureBox bluePictureBox;
        private System.Windows.Forms.PictureBox whitePictureBox;
        private System.Windows.Forms.PictureBox blackPictureBox;
        private System.Windows.Forms.PictureBox blackAndWhitePictureBox;
        private System.Windows.Forms.PictureBox cascadePictureBox1;
        private System.Windows.Forms.PictureBox cascadePictureBox2;
        private System.Windows.Forms.PictureBox cascadePictureBox3;
        private System.Windows.Forms.PictureBox cascadePictureBox4;
        private System.Windows.Forms.PictureBox cascadePictureBox5;
        private System.Windows.Forms.PictureBox cascadePictureBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox cascadePictureBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox cascadePictureBox8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox cascadePictureBox9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label procTimeLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label imageSizeLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox croppedImagePictureBox;
        private System.Windows.Forms.Button cascadeButton;
    }
}

