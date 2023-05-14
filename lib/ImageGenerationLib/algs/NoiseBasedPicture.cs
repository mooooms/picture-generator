using System.Drawing;

namespace ImageGenerationLib.Algs
{
    public class NoiseBasedPicture : IPicturesGenerationAlg
    {
        private int _length;
        private Bitmap _bitmap;
        public Bitmap Generate(Bitmap bitmap, int length)
        {
            _length = length;
            _bitmap = bitmap;
            GenerateBitmap();
            return _bitmap;
        }
        private void GenerateBitmap()
        {
            Random random = new Random();

            for (int y = 0; y < _bitmap.Height; y ++)
            {
                for (int x = 0; x < _bitmap.Width; x ++)
                {
                    var color = Color.FromArgb(random.Next(225), random.Next(225), random.Next(225), random.Next(225));
                    _bitmap.SetPixel(x, y, color);
                }
            }
        }
    }
}
