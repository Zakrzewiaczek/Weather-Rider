using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Rider
{
    public class ImageMerger
    {
        private static Image MergeImages(List<Image> images, int spacing)
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
    }
}
