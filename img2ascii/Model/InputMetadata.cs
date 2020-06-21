using System;
using System.Drawing;

namespace img2ascii.Model
{
    public class InputMetadata
    {
        public Bitmap Bitmap { get; private set; }

        public Int32 Width { get; private set; }

        public Int32 Height { get; private set; }

        public Single AspectRatio { get; private set; }

        public InputMetadata(Image image)
        {
            Bitmap = new Bitmap(image);

            Width = image.Width;
            Height = image.Height;
            AspectRatio = ((Single) image.Width) / ((Single) image.Height);
        }
    }
}
