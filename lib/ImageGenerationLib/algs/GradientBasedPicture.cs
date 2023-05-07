using System.Drawing;

namespace ImageGenerationLib.Algs
{
    public class GradientBasedPicture : IPicturesGenerationAlg
    {
        Random random = new Random();
        int _width, _height;
        public Bitmap Generate(Bitmap bitmap, int length = 0)
        {
            _width = bitmap.Width;
            _height = bitmap.Height;
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color color = GetColor(random, y, x);
                    bitmap.SetPixel(x, y, color);
                }
            }
            return bitmap;
        }

        private Color GetColor(Random random, int y, int x)
        {
            byte r = (byte)random.Next(255 * x / _width);
            byte g = (byte)random.Next(255 * y / _height);
            byte b = (byte)random.Next(255 - 255 * x / _width);
            Color color = Color.FromArgb(r, g, b);
            return color;
        }
    }
}
