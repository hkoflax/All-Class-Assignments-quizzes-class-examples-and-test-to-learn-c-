using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace MyPhotoLibrary
{
    public class PhotoSize
    {
        public static void ResizeAll(string[] listOfFiles)
        {
            for (int x = 0; x < listOfFiles.Length; x++)
            {
                if (listOfFiles[x].Contains(".jpg"))
                {
                    Image image = Image.FromFile(listOfFiles[x]);
                    if (image.Width != 599)/*image.Height!=599*/
                    {
                        using (var newImage = ScaleImage(image, 599))
                        {
                            image.Dispose();
                            File.Delete(listOfFiles[x]);
                            newImage.Save(listOfFiles[x], ImageFormat.Jpeg);
                            image.Dispose();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Image already have width of 599");
                    }
                }
            }
        }
        public static Image ScaleImage(Image image, int maxHeight)
        {
            //Double ratio = (double)(image.Width) / (double)(image.Height);
            //var newWidth = (int)(maxHeight * ratio);

            //var newImage = new Bitmap(newWidth, maxHeight);
            var newImage = new Bitmap(599, 599);

            //using (var graphics = Graphics.FromImage(newImage))
            //    graphics.DrawImage(image, 0, 0, newWidth, maxHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, 599, 599);

            return newImage;
        }
    }
}
