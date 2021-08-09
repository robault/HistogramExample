using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace HistogramExample
{
    class Pixel
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public Pixel(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public bool DoesMatch(int red, int green, int blue)
        {
            if (Red == red &&
                Green == green &&
                Blue == blue)
                return true;
            else
                return false;
        }
    }

    class Histogram
    {
        public int[] Red { get; set; }
        public int[] Green { get; set; }
        public int[] Blue { get; set; }
        public int[] Luminosity { get; set; }
        public int[] RGB { get; set; }

        public Bitmap RedHistogram { get; set; }
        public Bitmap GreenHistogram { get; set; }
        public Bitmap BlueHistogram { get; set; }
        public Bitmap LuminosityHistogram { get; set; }
        public Bitmap RGBHistogram { get; set; }

        public int[] RedHistogramData { get; set; }
        public int[] GreenHistogramData { get; set; }
        public int[] BlueHistogramData { get; set; }
        public int[] RGBHistogramData { get; set; }

        public int RedAVG { get; set; }
        public int GreenAVG { get; set; }
        public int BlueAVG { get; set; }

        public Bitmap RedChannelImage { get; set; }
        public Bitmap GreenChannelImage { get; set; }
        public Bitmap BlueChannelImage { get; set; }

        public Bitmap BlackChannelImage { get; set; }
        public Bitmap WhiteChannelImage { get; set; }
        public Bitmap BlackAndWhiteImage { get; set; }

        public Bitmap OriginalImage { get; set; }

        public List<KeyValuePair<Pixel, int>> Pixels { get; set; }

        public Histogram(Bitmap bitmap, System.Drawing.Color color)
        {
            OriginalImage = bitmap;

            InitializeChannelData();
            Load(bitmap);

            RedHistogram = HistogramImage(Red, color);
            GreenHistogram = HistogramImage(Green, color);
            BlueHistogram = HistogramImage(Blue, color);
            LuminosityHistogram = HistogramImage(Luminosity, color);
            RGBHistogram = HistogramImage(RGB, color);
        }

        private void InitializeChannelData()
        {
            Red = new int[256];
            Green = new int[256];
            Blue = new int[256];
            Luminosity = new int[256];
            RGB = new int[256];

            //set the initial values for the arrays
            for (int i = 0; i < 256; i++)
            {
                Red[i] = 0;
                Green[i] = 0;
                Blue[i] = 0;
                Luminosity[i] = 0;
                RGB[i] = 0;
            }
        }

        private void Load(Bitmap bitmap)
        {
            if (bitmap == null)
                throw new ArgumentException("The image passed in cannot be null.");

            //setup the channel bitmaps
            RedChannelImage = new Bitmap(bitmap);
            GreenChannelImage = new Bitmap(bitmap);
            BlueChannelImage = new Bitmap(bitmap);

            BlackChannelImage = new Bitmap(bitmap);
            WhiteChannelImage = new Bitmap(bitmap);
            BlackAndWhiteImage = new Bitmap(bitmap);

            //get the pixel array data so we can loop through it
            BitmapData bitmapData = bitmap.LockBits(new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            
            BitmapData redBitmapData = RedChannelImage.LockBits(new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData greenBitmapData = GreenChannelImage.LockBits(new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData blueBitmapData = BlueChannelImage.LockBits(new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            
            BitmapData blackBitmapData = BlackChannelImage.LockBits(new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData whiteBitmapData = WhiteChannelImage.LockBits(new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData blackAndWhiteBitmapData = BlackAndWhiteImage.LockBits(new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            //average color var [r, g, b]
            int[] totals = new int[] { 0, 0, 0 };

            unsafe
            {
                //setup the starting pixel in the bitmap data and the width of that data in the array
                byte* scanLinePixel = (byte*)bitmapData.Scan0;
                int bitmapStride = bitmapData.Stride - bitmapData.Width * 3;

                byte* redScanLinePixel = (byte*)redBitmapData.Scan0;
                byte* greenScanLinePixel = (byte*)greenBitmapData.Scan0;
                byte* blueScanLinePixel = (byte*)blueBitmapData.Scan0;

                byte* blackScanLinePixel = (byte*)blackBitmapData.Scan0;
                byte* whiteScanLinePixel = (byte*)whiteBitmapData.Scan0;
                byte* blackAndWhiteScanLinePixel = (byte*)blackAndWhiteBitmapData.Scan0;

                Pixels = new List<KeyValuePair<Pixel, int>>();

                //loop though the data from top to bottom then within each line from left to right
                for (int height = 0; height < bitmapData.Height; height++)
                {
                    for (int width = 0; width < bitmapData.Width; width++)
                    {
                        //get the values of our pixel channels
                        int mean = (int)(0.114 * scanLinePixel[0] + 0.587 * scanLinePixel[1] + 0.299 * scanLinePixel[2]);
                        int rgbAverage = (scanLinePixel[0] + scanLinePixel[1] + scanLinePixel[2]) / 3;
                        int red = scanLinePixel[2];
                        int green = scanLinePixel[1];
                        int blue = scanLinePixel[0];

                        //Pixels list
                        Pixel pixel = new Pixel(red, green, blue);

                        //go through our list (took 36 seconds to do this...NOT counting the internal processing)
                        //for (int i = 0; i < Pixels.Count; i++)
                        //{

                        //        //KeyValuePair<Pixel, int> pixelCount = Pixels[i];

                        //        ////if the current pixel matches one we already have
                        //        //if (pixel.DoesMatch(pixelCount.Key.Red, pixelCount.Key.Green, pixelCount.Key.Blue))
                        //        //{
                        //        //    ////incriment the count
                        //        //    //int count = pixelCount.Value;
                        //        //    //Pixels.Remove(pixelCount);
                        //        //    //Pixels.Add(new KeyValuePair<Pixel, int>(pixel, count + 1));
                        //        //}
                        //        //else
                        //        //{
                        //        //    //otherwise add it to the list
                        //        //    //Pixels.Add(new KeyValuePair<Pixel, int>(pixel, 1));
                        //        //}
                        //    }

                        //    //foreach (KeyValuePair<Pixel, int> pixelCount in Pixels)
                        //    //{
                        //    //    //if the current pixel matches one we already have
                        //    //    if (pixel.DoesMatch(pixelCount.Key.Red, pixelCount.Key.Green, pixelCount.Key.Blue))
                        //    //    {
                        //    //        //incriment the count
                        //    //        int count = pixelCount.Value;
                        //    //        Pixels.Remove(pixelCount);
                        //    //        Pixels.Add(new KeyValuePair<Pixel, int>(pixel, count + 1));
                        //    //    }
                        //    //    else
                        //    //    {
                        //    //        //otherwise add it to the list
                        //    //        Pixels.Add(new KeyValuePair<Pixel, int>(pixel, 1));
                        //    //    }

                        //}
                        
                        Pixels.Add(new KeyValuePair<Pixel, int>(pixel, 1));

                        //incriment the position within the array if that pixel value (=position) is found, not sure I explained that right...
                        Luminosity[mean]++;
                        Red[red]++;
                        Green[green]++;
                        Blue[blue]++;
                        RGB[rgbAverage]++;

                        //add value to totals so we can average later
                        totals[0] += red;
                        totals[1] += green;
                        totals[2] += blue;

                        //set values for our channel bitmaps
                        redScanLinePixel[0] = scanLinePixel[0];
                        redScanLinePixel[1] = 0;
                        redScanLinePixel[2] = 0;

                        greenScanLinePixel[0] = 0;
                        greenScanLinePixel[1] = scanLinePixel[1];
                        greenScanLinePixel[2] = 0;

                        blueScanLinePixel[0] = 0;
                        blueScanLinePixel[1] = 0;
                        blueScanLinePixel[2] = scanLinePixel[2];

                        //b&w
                        int pixelAVG = Convert.ToInt32((red + green + blue) / 3);
                        //this cuts it at 50%
                        if (pixelAVG > 127) //a white pixel
                        {
                            blackScanLinePixel[0] = 255;
                            blackScanLinePixel[1] = 255;
                            blackScanLinePixel[2] = 255;

                            whiteScanLinePixel[0] = 0;
                            whiteScanLinePixel[1] = 0;
                            whiteScanLinePixel[2] = 0;
                        }
                        else //a black pixel
                        {
                            blackScanLinePixel[0] = 0;
                            blackScanLinePixel[1] = 0;
                            blackScanLinePixel[2] = 0;

                            whiteScanLinePixel[0] = 255;
                            whiteScanLinePixel[1] = 255;
                            whiteScanLinePixel[2] = 255;
                        }

                        //sets our greyscale image (ie: black and white)
                        blackAndWhiteScanLinePixel[0] = 
                            blackAndWhiteScanLinePixel[1] = 
                            blackAndWhiteScanLinePixel[2] =
                                (byte)(.299 * red + .587 * green + .114 * blue); 

                        //next pixel to the right
                        scanLinePixel += 3;
                        redScanLinePixel += 3;
                        greenScanLinePixel += 3;
                        blueScanLinePixel += 3;
                        blackScanLinePixel += 3;
                        whiteScanLinePixel += 3;
                        blackAndWhiteScanLinePixel += 3;
                    }

                    //next line down
                    scanLinePixel += bitmapStride;
                    redScanLinePixel += bitmapStride;
                    greenScanLinePixel += bitmapStride;
                    blueScanLinePixel += bitmapStride;
                    blackScanLinePixel += bitmapStride;
                    whiteScanLinePixel += bitmapStride;
                    blackAndWhiteScanLinePixel += bitmapStride;
                }
            }
            bitmap.UnlockBits(bitmapData);
            RedChannelImage.UnlockBits(redBitmapData);
            GreenChannelImage.UnlockBits(greenBitmapData);
            BlueChannelImage.UnlockBits(blueBitmapData);
            BlackChannelImage.UnlockBits(blackBitmapData);
            WhiteChannelImage.UnlockBits(whiteBitmapData);
            BlackAndWhiteImage.UnlockBits(blackAndWhiteBitmapData);

            //set the average color calculations
            int size = bitmap.Width * bitmap.Height;
            RedAVG = totals[0] / size;
            GreenAVG = totals[1] / size;
            BlueAVG = totals[2] / size;

            RedHistogramData = Red;
            GreenHistogramData = Green;
            BlueHistogramData = Blue;
            RGBHistogramData = RGB;
        }

        private Bitmap HistogramImage(int[] channel, System.Drawing.Color color)
        {
            if (channel == null)
                throw new ArgumentException("The int array 'channel' cannot be null. Be sure to call the method CreateHistogram before calling this method.");

            //set the size to 256 for the possible values of 0 to 255 of pixel data
            Bitmap bitmap = new Bitmap(256, 256);

            //find the max value within the channel
            int maxValue = 0;

            foreach (int value in channel)
            {
                if (value > maxValue)
                    maxValue = value;
            }

            //get the ratio to normalize with
            double ratio = 256.0 / maxValue;

            //setup the image we draw to
            Graphics graphics = Graphics.FromImage(bitmap);
            Pen pen = new Pen(color, 1); //pixel width of "1"

            //loop through the passed in array and clamp the values within the bounds of our image/array of 256 (height)
            for (int i = 0; i < 256; i++)
            {
                int channelValue = channel[i];
                double clampedValue = 0;

                //normalize (or "clamp") the value by multiplying the value by the ration created by dividing the desired max of 256 by the maximum value we found in the array
                if (maxValue > 0)
                    clampedValue = channelValue * ratio;

                //set the values for the line we draw
                Point bottom = new Point(i, 0);
                Point top = new Point(i, Convert.ToInt32(clampedValue));

                //draw it
                graphics.DrawLine(pen, bottom, top);
            }
            
            //draw out our new image 
            graphics.DrawImage(bitmap, new Rectangle(0, 0, 256, 256));

            //flip it
            Image image = bitmap;
            image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            bitmap = new Bitmap(image);

            return bitmap;
        }

        public Color[] ThreeMostProminantColors()
        {
            Color[] colors = new Color[] {Color.Black, Color.Black, Color.Black};
            
            #region Notes
            
            //var topThree = RGBHistogramData.OrderByDescending(i => i).Take(3);

            //normalize histograms or just loop through them?
            //get top 3 but will they all be in the same position? does it matter?
            
            //loop/step every X number and record the average, keep track of 3 averages and if a higher is found replace the lowest of the 
            //3 with the new higher average, then you have the 3 most common of each color channel
            //the problem still exists where the channels don't match up

            //int[] redCommon = new int[] {0, 0, 0};
            //int[] greenCommon = new int[] { 0, 0, 0 };
            //int[] blueCommon = new int[] { 0, 0, 0 };

            //for (int i = 0; i < Red.Length; i++)
            //{
            //    int redValue = Red[i];
            //    int leastSoFar = redCommon.Min<int>();

            //    //if we found one greater than the least on we have so far
            //    if (redValue > leastSoFar)
            //    {
            //        //find the least
            //        for (int j = 0; j < redCommon.Length; j++)
            //        {
            //            if (redCommon[j] == leastSoFar)
            //            {
            //                //and replace it
            //                redCommon[j] = redValue;
            //                break; //stop after first on replaced
            //            }
            //        }
            //    }
            //}

            //colors[0] = Color.FromArgb(redCommon[0], 0, 0);

            //

            //i could loop through the grb histo and find the 3 most common then loop through the pixels and find the positions of the 3 most common
            //based on the indeces of the most common colors in the full histo...

            //NO NO NO

            //int[] mostCommonPixels = new int[] { 0, 0, 0 };

            //for (int i = 0; i < RGBHistogramData.Length; i++)
            //{
            //    int value = RGBHistogramData[i];
            //    int leastSoFar = mostCommonPixels.Min<int>();

            //    //if we found one greater than the least on we have so far
            //    if (value > leastSoFar)
            //    {
            //        //find the least
            //        for (int j = 0; j < mostCommonPixels.Length; j++)
            //        {
            //            if (mostCommonPixels[j] == leastSoFar)
            //            {
            //                //and replace it
            //                mostCommonPixels[j] = value;
            //                break; //stop after first on replaced
            //            }
            //        }
            //    }
            //}

            //YES YES YES

            #endregion

            //get the pixel array data so we can loop through it
            BitmapData bitmapData = OriginalImage.LockBits(new System.Drawing.Rectangle(0, 0, OriginalImage.Width, OriginalImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            
            unsafe
            {
                //setup the starting pixel in the bitmap data and the width of that data in the array
                byte* scanLinePixel = (byte*)bitmapData.Scan0;
                int bitmapStride = bitmapData.Stride - bitmapData.Width * 3;
                                
                //loop though the data from top to bottom then within each line from left to right
                for (int height = 0; height < bitmapData.Height; height++)
                {
                    for (int width = 0; width < bitmapData.Width; width++)
                    {
                        //get the values of our pixel channels
                        int red = scanLinePixel[2];
                        int green = scanLinePixel[1];
                        int blue = scanLinePixel[0];

                        //next pixel to the right
                        scanLinePixel += 3;
                    }

                    //next line down
                    scanLinePixel += bitmapStride;
                }
            }
            
            OriginalImage.UnlockBits(bitmapData);

            return colors;
        }
    }

    public static class Imaging
    {
        public static bool IsNull(object parameter)
        {
            bool isNull = true;

            if (parameter != null)
                isNull = false;

            return isNull;
        }

        public class ConvolutionMatrix
        {
            public int TopLeft = 0, TopMid = 0, TopRight = 0;
            public int MidLeft = 0, Pixel = 1, MidRight = 0;
            public int BottomLeft = 0, BottomMid = 0, BottomRight = 0;
            public int Factor = 1;
            public int Offset = 0;
            public void SetAll(int value)
            {
                TopLeft = TopMid = TopRight = MidLeft = Pixel = MidRight = BottomLeft = BottomMid = BottomRight = value;
            }
        }

        private static Bitmap Conv3x3(Bitmap bitmap, ConvolutionMatrix matrix)
        {
            // Avoid divide by zero errors
            if (0 == matrix.Factor) return null;

            Bitmap bSrc = (Bitmap)bitmap.Clone();

            // GDI+ still lies to us - the return format is BGR, NOT RGB.
            BitmapData bmData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmData.Stride;
            int stride2 = stride * 2;
            System.IntPtr Scan0 = bmData.Scan0;
            System.IntPtr SrcScan0 = bmSrc.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                byte* pSrc = (byte*)(void*)SrcScan0;

                int nOffset = stride - bitmap.Width * 3;
                int nWidth = bitmap.Width - 2;
                int nHeight = bitmap.Height - 2;

                int nPixel;

                for (int y = 0; y < nHeight; ++y)
                {
                    for (int x = 0; x < nWidth; ++x)
                    {
                        nPixel = ((((pSrc[2] * matrix.TopLeft) + (pSrc[5] * matrix.TopMid) + (pSrc[8] * matrix.TopRight) +
                            (pSrc[2 + stride] * matrix.MidLeft) + (pSrc[5 + stride] * matrix.Pixel) + (pSrc[8 + stride] * matrix.MidRight) +
                            (pSrc[2 + stride2] * matrix.BottomLeft) + (pSrc[5 + stride2] * matrix.BottomMid) + (pSrc[8 + stride2] * matrix.BottomRight)) / matrix.Factor) + matrix.Offset);

                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;

                        p[5 + stride] = (byte)nPixel;

                        nPixel = ((((pSrc[1] * matrix.TopLeft) + (pSrc[4] * matrix.TopMid) + (pSrc[7] * matrix.TopRight) +
                            (pSrc[1 + stride] * matrix.MidLeft) + (pSrc[4 + stride] * matrix.Pixel) + (pSrc[7 + stride] * matrix.MidRight) +
                            (pSrc[1 + stride2] * matrix.BottomLeft) + (pSrc[4 + stride2] * matrix.BottomMid) + (pSrc[7 + stride2] * matrix.BottomRight)) / matrix.Factor) + matrix.Offset);

                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;

                        p[4 + stride] = (byte)nPixel;

                        nPixel = ((((pSrc[0] * matrix.TopLeft) + (pSrc[3] * matrix.TopMid) + (pSrc[6] * matrix.TopRight) +
                            (pSrc[0 + stride] * matrix.MidLeft) + (pSrc[3 + stride] * matrix.Pixel) + (pSrc[6 + stride] * matrix.MidRight) +
                            (pSrc[0 + stride2] * matrix.BottomLeft) + (pSrc[3 + stride2] * matrix.BottomMid) + (pSrc[6 + stride2] * matrix.BottomRight)) / matrix.Factor) + matrix.Offset);

                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;

                        p[3 + stride] = (byte)nPixel;

                        p += 3;
                        pSrc += 3;
                    }
                    p += nOffset;
                    pSrc += nOffset;
                }
            }

            bitmap.UnlockBits(bmData);
            bSrc.UnlockBits(bmSrc);

            return bitmap;
        }

        public static Bitmap GrayScale(Bitmap bitmap)
        {
            if (IsNull(bitmap))
                throw new ArgumentException("Bitmap cannot be null.");

            try
            {
                // GDI+ still lies to us - the return format is BGR, NOT RGB.
                BitmapData bmData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                int stride = bmData.Stride;
                System.IntPtr Scan0 = bmData.Scan0;

                unsafe
                {
                    byte* p = (byte*)(void*)Scan0;

                    int nOffset = stride - bitmap.Width * 3;

                    byte red, green, blue;
                    int nWidth = bitmap.Width;
                    int nHeight = bitmap.Height;

                    for (int y = 0; y < nHeight; ++y)
                    {
                        for (int x = 0; x < nWidth; ++x)
                        {
                            blue = p[0];
                            green = p[1];
                            red = p[2];

                            p[0] = p[1] = p[2] = (byte)(.299 * red + .587 * green + .114 * blue);

                            p += 3;
                        }
                        p += nOffset;
                    }
                }

                bitmap.UnlockBits(bmData);
            }
            catch
            {
                throw;
            }

            GC.Collect();

            return bitmap;
        }

        public static Bitmap GaussianBlur(Bitmap bitmap, byte blur)
        {
            if (IsNull(bitmap))
                throw new ArgumentException("Bitmap cannot be null.");

            try
            {
                ConvolutionMatrix m = new ConvolutionMatrix();
                m.SetAll(1);
                m.Pixel = blur;
                m.TopMid = m.MidLeft = m.MidRight = m.BottomMid = 2;
                m.Factor = blur + 12;

                bitmap = Conv3x3(bitmap, m);
            }
            catch
            {
                throw;
            }

            GC.Collect();

            return bitmap;
        }           

        public static Bitmap Resize(Bitmap bitmap, int width, int height, bool useBilinear)
        {
            if (IsNull(bitmap))
                throw new ArgumentException("Bitmap cannot be null.");

            Bitmap bTemp = (Bitmap)bitmap.Clone();
            bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            //bitmap = new Bitmap(width, height, bTemp.PixelFormat);

            double nXFactor = (double)bTemp.Width / (double)width;
            double nYFactor = (double)bTemp.Height / (double)height;

            try
            {
                if (useBilinear)
                {
                    double fraction_x, fraction_y, one_minus_x, one_minus_y;
                    int ceil_x, ceil_y, floor_x, floor_y;
                    Color c1 = new Color();
                    Color c2 = new Color();
                    Color c3 = new Color();
                    Color c4 = new Color();
                    byte red, green, blue;

                    byte b1, b2;

                    int nWidth = bitmap.Width;
                    int nHeight = bitmap.Height;

                    for (int x = 0; x < nWidth; ++x)
                        for (int y = 0; y < nHeight; ++y)
                        {
                            // Setup

                            floor_x = (int)Math.Floor(x * nXFactor);
                            floor_y = (int)Math.Floor(y * nYFactor);
                            ceil_x = floor_x + 1;
                            if (ceil_x >= bTemp.Width) ceil_x = floor_x;
                            ceil_y = floor_y + 1;
                            if (ceil_y >= bTemp.Height) ceil_y = floor_y;
                            fraction_x = x * nXFactor - floor_x;
                            fraction_y = y * nYFactor - floor_y;
                            one_minus_x = 1.0 - fraction_x;
                            one_minus_y = 1.0 - fraction_y;

                            c1 = bTemp.GetPixel(floor_x, floor_y);
                            c2 = bTemp.GetPixel(ceil_x, floor_y);
                            c3 = bTemp.GetPixel(floor_x, ceil_y);
                            c4 = bTemp.GetPixel(ceil_x, ceil_y);

                            // Blue
                            b1 = (byte)(one_minus_x * c1.B + fraction_x * c2.B);

                            b2 = (byte)(one_minus_x * c3.B + fraction_x * c4.B);

                            blue = (byte)(one_minus_y * (double)(b1) + fraction_y * (double)(b2));

                            // Green
                            b1 = (byte)(one_minus_x * c1.G + fraction_x * c2.G);

                            b2 = (byte)(one_minus_x * c3.G + fraction_x * c4.G);

                            green = (byte)(one_minus_y * (double)(b1) + fraction_y * (double)(b2));

                            // Red
                            b1 = (byte)(one_minus_x * c1.R + fraction_x * c2.R);

                            b2 = (byte)(one_minus_x * c3.R + fraction_x * c4.R);

                            red = (byte)(one_minus_y * (double)(b1) + fraction_y * (double)(b2));

                            bitmap.SetPixel(x, y, System.Drawing.Color.FromArgb(255, red, green, blue));
                        }
                }
                else
                {
                    for (int x = 0; x < bitmap.Width; ++x)
                        for (int y = 0; y < bitmap.Height; ++y)
                            bitmap.SetPixel(x, y, bTemp.GetPixel((int)(Math.Floor(x * nXFactor)), (int)(Math.Floor(y * nYFactor))));
                }
            }
            catch
            {
                throw;
            }

            GC.Collect();

            return bitmap;

        }

        public static Bitmap Crop(Bitmap bitmap, Rectangle rectangle)
        {
            if (IsNull(bitmap))
                throw new ArgumentException("Bitmap cannot be null.");

            try
            {
                Bitmap croppedBitmap = (Bitmap)bitmap.Clone();

                //constrain passed in size to the dimensions of the bitmap
                if (rectangle.Left + rectangle.Width > bitmap.Width)
                    rectangle.Width = bitmap.Width - rectangle.Width;

                if (rectangle.Top + rectangle.Height > bitmap.Height)
                    rectangle.Height = bitmap.Height - rectangle.Height;

                //crop
                bitmap = (Bitmap)croppedBitmap.Clone(rectangle, bitmap.PixelFormat);
            }
            catch
            {
                throw;
            }

            GC.Collect();

            return bitmap;
        }

        public static Bitmap Crop2(Bitmap myBitmap, int nX, int nY, int nW, int nH)
        {
            if (nX < 0 || nX >= nW || nW > myBitmap.Width || nY < 0 || nY >= nH || nH > myBitmap.Height)
                throw new ArgumentException();
            Rectangle compressionRectangle = new Rectangle(nX, nY, nW, nH);
            return myBitmap.Clone(compressionRectangle, System.Drawing.Imaging.PixelFormat.DontCare);
        }

        // https://stackoverflow.com/questions/3115076/adjust-the-contrast-of-an-image-in-c-sharp-efficiently
        public static Bitmap Contrast(Bitmap Image, float Value)
        {
            Value = (100.0f + Value) / 100.0f;
            Value *= Value;
            Bitmap NewBitmap = (Bitmap)Image.Clone();
            BitmapData data = NewBitmap.LockBits(new Rectangle(0, 0, NewBitmap.Width, NewBitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
            int Height = NewBitmap.Height;
            int Width = NewBitmap.Width;

            unsafe
            {
                for (int y = 0; y < Height; ++y)
                {
                    byte* row = (byte*)data.Scan0 + (y * data.Stride);
                    int columnOffset = 0;
                    for (int x = 0; x < Width; ++x)
                    {
                        byte B = row[columnOffset];
                        byte G = row[columnOffset + 1];
                        byte R = row[columnOffset + 2];

                        float Red = R / 255.0f;
                        float Green = G / 255.0f;
                        float Blue = B / 255.0f;
                        Red = (((Red - 0.5f) * Value) + 0.5f) * 255.0f;
                        Green = (((Green - 0.5f) * Value) + 0.5f) * 255.0f;
                        Blue = (((Blue - 0.5f) * Value) + 0.5f) * 255.0f;

                        int iR = (int)Red;
                        iR = iR > 255 ? 255 : iR;
                        iR = iR < 0 ? 0 : iR;
                        int iG = (int)Green;
                        iG = iG > 255 ? 255 : iG;
                        iG = iG < 0 ? 0 : iG;
                        int iB = (int)Blue;
                        iB = iB > 255 ? 255 : iB;
                        iB = iB < 0 ? 0 : iB;

                        row[columnOffset] = (byte)iB;
                        row[columnOffset + 1] = (byte)iG;
                        row[columnOffset + 2] = (byte)iR;

                        columnOffset += 4;
                    }
                }
            }

            NewBitmap.UnlockBits(data);

            return NewBitmap;
        }
    }
}
