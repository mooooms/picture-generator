using System.Drawing;

namespace ImageGenerationLib.Algs
{
    public class SquareBasedPicture : IPicturesGenerationAlg
    {
        private int _squere_length;
        private Bitmap _bitmap;
        public Bitmap Generate(Bitmap bitmap, int length)
        {
            _squere_length = length;
            _bitmap = bitmap;
            GenerateBitmap();
            return _bitmap;
        }

        private void GenerateBitmap()
        {
            Random random = new Random();
           
            for (int y = 0; y < _bitmap.Height; y += _squere_length)
            {
                for (int x = 0; x < _bitmap.Width; x += _squere_length)
                {
                    var color = Color.FromArgb(random.Next(225), random.Next(225), random.Next(225), random.Next(225));
                    SetSquareColor(new PointWithColor(x, y, color));
                }
            }
        }

        private void SetSquareColor(PointWithColor point)
        {
            for (int horizontal_offset = 0; horizontal_offset < _squere_length; horizontal_offset++)
            {
                if (point.X + horizontal_offset >= _bitmap.Width) break;
                SetVerticalAxisColor(point, horizontal_offset);
            }
        }

        private void SetVerticalAxisColor(PointWithColor point, int horizontal_offset)
        {
            for (int vertical_offset = 0; vertical_offset < _squere_length; vertical_offset++)
            {
                if (point.Y + vertical_offset >= _bitmap.Height) break;
                _bitmap.SetPixel(point.X + horizontal_offset, point.Y + vertical_offset, point.Color);
            }
        }
    }
}
