using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Rider
{
    public static class ImageEditor
    {
        public static Image Merge(List<Image> images, int spacing)
        {
            if (images == null || images.Count == 0)
                throw new ArgumentException("No images to merge.");

            int width = 0;
            int height = spacing * (images.Count - 1);

            foreach (var image in images)
            {
                width = Math.Max(width, image.Width);
                height += image.Height;
            }

            Bitmap mergedImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(mergedImage))
            {
                g.Clear(Color.White);
                int yOffset = 0;

                foreach (var image in images)
                {
                    g.DrawImage(image, 0, yOffset);
                    yOffset += image.Height + spacing;
                }
            }

            return mergedImage;
        }


        // Image extensions methods
        public static Image? Rotate(this Image? image, float angle)
        {
            if (image is null)
                return null;

            Bitmap rotatedBmp = new(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedBmp))
            {
                g.TranslateTransform((float)image.Width / 2, (float)image.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-(float)image.Width / 2, -(float)image.Height / 2);
                g.DrawImage(image, new Point(0, 0));
            }

            return rotatedBmp;
        }
        public static Image Resize(this Image image, float width, float height) {

            Bitmap resizedImage = new((int)width, (int)height);
            resizedImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }

            return resizedImage;
        }
    }
}
