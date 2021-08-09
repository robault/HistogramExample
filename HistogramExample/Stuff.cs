using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HistogramExample
{
    class Stuff
    {
        /// <summary>
        /// Returns double array containing the size compensation multipliers used to resize an image. 
        /// Size compensation allows for object recognition with variance to the object proximity to 
        /// the capture device.
        /// </summary>
        public double[] SizeCompensationMultipliers
        {
            get
            {
                double[] scm = new double[5];
                scm.SetValue(1.0, 0);
                scm.SetValue(.8, 0);
                scm.SetValue(.6, 0);
                scm.SetValue(.4, 0);
                scm.SetValue(.2, 0);
                return scm;
            }
        }

        /// <summary>
        /// Returns a double representing an images ratio. ex: 240 x 320 = .75
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public double ImageRatio(Bitmap bitmap)
        {
            double ratio = bitmap.Width / bitmap.Height;
            return ratio;
        }

        public class ObjectToTrack
        {
            public Bitmap ObjectToTrackImage { get; set; }
            public Rectangle ObjectToTrackBounds { get; set; }

            public int[] RedHistogram { get; set; }
            public int[] GreenHistogram { get; set; }
            public int[] BlueHistogram { get; set; }
            public int[] FullHistogram { get; set; }

            public int DominantRed { get; set; }
            public int DominantGreen { get; set; }
            public int DominantBlue { get; set; }

            public int StandardDeviation { get; set; }

            public Rectangle RegionOfInterest(int padding)
            {
                Rectangle roi = new Rectangle();
                roi.X = ObjectToTrackBounds.X - padding;
                roi.Y = ObjectToTrackBounds.Y - padding;
                roi.Width = ObjectToTrackBounds.Width + padding + padding;
                roi.Height = ObjectToTrackBounds.Height + padding + padding;
                return roi;
            }

            public ObjectToTrack(Bitmap bitmap, Rectangle objectToTrackBounds)
            {
                if (bitmap == null)
                    throw new ArgumentNullException("bitmap", "You must pass in a Bitmap to instantiate an object to track.");
                if (objectToTrackBounds == null)
                    throw new ArgumentNullException("objectToTrackBounds", "You must pass in the Rectangle of the bitmap you pass in to instantiate an object to track.");

                ObjectToTrackImage = bitmap;
                ObjectToTrackBounds = objectToTrackBounds;
            }
        }
    }
}
