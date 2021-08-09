using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HistogramExample
{
    public partial class Form1 : Form
    {
        Histogram histogram;

        private Bitmap GetChannelAverageImage(int red, int green, int blue)
        {
            Bitmap bitmap = new Bitmap(24, 24);
            Graphics graphics = Graphics.FromImage(bitmap);
            Color color = Color.FromArgb(red, green, blue);
            Pen pen = new Pen(color, 24);
            graphics.DrawRectangle(pen, 0, 0, 24, 24);
            return bitmap;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void imagePathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();

            DateTime start = DateTime.Now;

            imagePathTextBox.Text = dialog.FileName;

            Bitmap bitmap = new Bitmap(160, 120);

            if (dialog.FileName != null && dialog.FileName.Length > 3)
            {
                bitmap = new Bitmap(dialog.FileName);
                Bitmap clone = new Bitmap(bitmap.Width, bitmap.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
                using (Graphics gr = Graphics.FromImage(clone))
                {
                    gr.DrawImage(bitmap, new Rectangle(0, 0, clone.Width, clone.Height));
                    clone = Imaging.Resize(bitmap, 256, 256, false); //resizing so the drag selection will work...
                    originalPictureBox.Image = clone;

                    histogram = new Histogram(clone, Color.Black);
                }
            }

            redRadioButton.Checked = false;
            greenRadioButton.Checked = false;
            blueRadioButton.Checked = false;
            luminosityRadioButton.Checked = false;
            fullRGBRadioButton.Checked = false;

            channelColorPictureBox.Image = null;
            histogramPictureBox.Image = null;
            colorValueLabel.Text = ".";

            redPictureBox.Image = histogram.RedChannelImage;
            greenPictureBox.Image = histogram.GreenChannelImage;
            bluePictureBox.Image = histogram.BlueChannelImage;

            blackAndWhitePictureBox.Image = histogram.BlackAndWhiteImage;
            blackPictureBox.Image = histogram.BlackChannelImage;
            whitePictureBox.Image = histogram.WhiteChannelImage;

            //100%
            Bitmap image = new Bitmap(originalPictureBox.Image);
            Bitmap cascade = image;
            cascade = Imaging.GrayScale(cascade);
            cascade = Imaging.GaussianBlur(cascade, 255);

            cascadePictureBox1.Image = cascade;

            //75%
            cascade = Imaging.Resize(image, Convert.ToInt32(.75 * image.Width), Convert.ToInt32(.75 * image.Width), false);
            cascadePictureBox2.Image = cascade;

            //50%
            cascade = Imaging.Resize(image, Convert.ToInt32(.5 * image.Width), Convert.ToInt32(.5 * image.Width), false);
            cascadePictureBox3.Image = cascade;

            //25%
            cascade = Imaging.Resize(image, Convert.ToInt32(.25 * image.Width), Convert.ToInt32(.25 * image.Width), false);
            cascadePictureBox4.Image = cascade;

            //12.5%
            cascade = Imaging.Resize(image, Convert.ToInt32(.125 * image.Width), Convert.ToInt32(.125 * image.Width), false);
            cascadePictureBox5.Image = cascade;

            //6.5%
            cascade = Imaging.Resize(image, Convert.ToInt32(.065 * image.Width), Convert.ToInt32(.065 * image.Width), false);
            cascadePictureBox6.Image = cascade;

            //4.6875%
            cascade = Imaging.Resize(image, Convert.ToInt32(.046875 * image.Width), Convert.ToInt32(.046875 * image.Width), false);
            cascadePictureBox7.Image = cascade;

            //3.515625%
            cascade = Imaging.Resize(image, Convert.ToInt32(.03515625 * image.Width), Convert.ToInt32(.03515625 * image.Width), false);
            cascadePictureBox8.Image = cascade;

            //2.63671875%
            cascade = Imaging.Resize(image, Convert.ToInt32(.0263671875 * image.Width), Convert.ToInt32(.0263671875 * image.Width), false);
            cascadePictureBox9.Image = cascade;

            DateTime end= DateTime.Now;

            int milliseconds = Convert.ToInt32((end - start).TotalMilliseconds);
            procTimeLabel.Text = milliseconds.ToString();

            imageSizeLabel.Text = bitmap.Width.ToString() + " x " + bitmap.Height.ToString();
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            histogramPictureBox.Image = histogram.RedHistogram;
            channelColorPictureBox.Image = GetChannelAverageImage(histogram.RedAVG, 0, 0);
            colorValueLabel.Text = histogram.RedAVG.ToString();
        }

        private void greenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            histogramPictureBox.Image = histogram.GreenHistogram;
            channelColorPictureBox.Image = GetChannelAverageImage(0, histogram.GreenAVG, 0);
            colorValueLabel.Text = histogram.GreenAVG.ToString();
        }

        private void blueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            histogramPictureBox.Image = histogram.BlueHistogram;
            channelColorPictureBox.Image = GetChannelAverageImage(0, 0, histogram.BlueAVG);
            colorValueLabel.Text = histogram.BlueAVG.ToString();
        }

        private void luminosityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            histogramPictureBox.Image = histogram.LuminosityHistogram;
            channelColorPictureBox.Image = null;
            colorValueLabel.Text = ".";
        }
        
        private void fullRGBRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            histogramPictureBox.Image = histogram.RGBHistogram;

            Histogram avgHist = new Histogram((Bitmap)croppedImagePictureBox.Image, Color.White);

            channelColorPictureBox.Image = GetChannelAverageImage(avgHist.RedAVG, avgHist.GreenAVG, avgHist.BlueAVG);
            colorValueLabel.Text = ".";
        }

        bool selecting = false;
        Rectangle selection = new Rectangle();
        int x = 0;
        int y = 0;
        int width = 0;
        int height = 0;
        Bitmap originalImage;

        private void originalPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                originalImage = new Bitmap(originalPictureBox.Image);
                selecting = true;
                //selection = new Rectangle(new Point(e.X, e.Y), new Size(1,1));
                x = e.X;
                y = e.Y;
            }
        }

        private void originalPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                selecting = false;
                //selection = new Rectangle(new Point(e.X, e.Y), new Size());
                CropImage();
                originalPictureBox.Image = originalImage;
            }
        }

        private void originalPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (selecting)
            {
                //selection.Width = e.X - selection.X;
                //selection.Height = e.Y - selection.Y;
                width = e.X - x;
                height = e.Y - y;
                originalPictureBox.Refresh();
            }

        }

        private void originalPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (selecting)
            {
                Pen pen = Pens.GreenYellow;
                e.Graphics.DrawRectangle(pen, new Rectangle(x, y, width, height));
            }
        }

        private void CropImage()
        {
            //croppedImagePictureBox.Image = Imaging.Crop(originalImage, new Rectangle(x, y, width, height));
            //croppedImagePictureBox.Image = Imaging.Crop2(new Bitmap(originalPictureBox.Image), x, y, width, height);
            // hack!
            if (width == 0)
            {
                width = 200;
            }
            if (height == 0)
            {
                height = 200;
            }
            try
            {
                croppedImagePictureBox.Image = Imaging.Crop(originalImage, new Rectangle(x, y, width, height));
            } catch
            {
                try
                {
                    croppedImagePictureBox.Image = Imaging.Crop2(new Bitmap(originalPictureBox.Image), x, y, width, height);
                } catch
                {
                    croppedImagePictureBox.Image = originalPictureBox.Image;
                }
            }
        }

        private void cascadeButton_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;

            redRadioButton.Checked = false;
            greenRadioButton.Checked = false;
            blueRadioButton.Checked = false;
            luminosityRadioButton.Checked = false;
            fullRGBRadioButton.Checked = false;

            channelColorPictureBox.Image = null;
            histogramPictureBox.Image = null;
            colorValueLabel.Text = ".";

            //100%
            Bitmap image = new Bitmap(croppedImagePictureBox.Image);
            Bitmap cascade = image;
            cascade = Imaging.GrayScale(cascade);
            cascade = Imaging.GaussianBlur(cascade, 255);

            cascadePictureBox1.Image = cascade;

            int errSize = 48;
            Bitmap errorImage = new Bitmap(errSize, errSize);
            Pen redPen = new Pen(Color.Red);
            Graphics graphics = Graphics.FromImage(errorImage);
            graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, errSize, errSize));
            graphics.DrawLine(redPen, new Point(0, 0), new Point(errSize, errSize));
            graphics.DrawLine(redPen, new Point(errSize, 0), new Point(0, errSize));
            graphics.DrawImage(errorImage, new Rectangle(0, 0, errSize, errSize));

            cascadePictureBox2.Image = null;
            cascadePictureBox3.Image = null;
            cascadePictureBox4.Image = null;
            cascadePictureBox5.Image = null;
            cascadePictureBox6.Image = null;
            cascadePictureBox7.Image = null;
            cascadePictureBox8.Image = null;
            cascadePictureBox9.Image = null;

            try
            {
                //75%
                cascade = Imaging.Resize(image, Convert.ToInt32(.75 * image.Width), Convert.ToInt32(.75 * image.Width), false);
                cascadePictureBox2.Image = cascade;
            }
            catch
            {
                cascadePictureBox2.Image = errorImage;
            }
            try
            {
                //50%
                cascade = Imaging.Resize(image, Convert.ToInt32(.5 * image.Width), Convert.ToInt32(.5 * image.Width), false);
                cascadePictureBox3.Image = cascade;
            }
            catch
            {
                cascadePictureBox3.Image = errorImage;
            }
            try
            {
                //25%
                cascade = Imaging.Resize(image, Convert.ToInt32(.25 * image.Width), Convert.ToInt32(.25 * image.Width), false);
                cascadePictureBox4.Image = cascade;
            }
            catch
            {
                cascadePictureBox4.Image = errorImage;
            }
            try
            {
                //12.5%
                cascade = Imaging.Resize(image, Convert.ToInt32(.125 * image.Width), Convert.ToInt32(.125 * image.Width), false);
                cascadePictureBox5.Image = cascade;
            }
            catch
            {
                cascadePictureBox5.Image = errorImage;
            }
            try
            {
                //6.5%
                cascade = Imaging.Resize(image, Convert.ToInt32(.065 * image.Width), Convert.ToInt32(.065 * image.Width), false);
                cascadePictureBox6.Image = cascade;
            }
            catch
            {
                cascadePictureBox6.Image = errorImage;
            }
            try
            {
                //4.6875%
                cascade = Imaging.Resize(image, Convert.ToInt32(.046875 * image.Width), Convert.ToInt32(.046875 * image.Width), false);
                cascadePictureBox7.Image = cascade;
            }
            catch
            {
                cascadePictureBox7.Image = errorImage;
            }
            try
            {
                //3.515625%
                cascade = Imaging.Resize(image, Convert.ToInt32(.03515625 * image.Width), Convert.ToInt32(.03515625 * image.Width), false);
                cascadePictureBox8.Image = cascade;
            }
            catch
            {
                cascadePictureBox8.Image = errorImage;
            }
            try
            {
                //2.63671875%
                cascade = Imaging.Resize(image, Convert.ToInt32(.0263671875 * image.Width), Convert.ToInt32(.0263671875 * image.Width), false);
                cascadePictureBox9.Image = cascade;
            }
            catch
            {
                cascadePictureBox9.Image = errorImage;
            }
            
            DateTime end = DateTime.Now;

            int milliseconds = Convert.ToInt32((end - start).TotalMilliseconds);
            procTimeLabel.Text = milliseconds.ToString();

            imageSizeLabel.Text = image.Width.ToString() + " x " + image.Height.ToString();

            fullRGBRadioButton.Checked = true;
        }
    }
}
