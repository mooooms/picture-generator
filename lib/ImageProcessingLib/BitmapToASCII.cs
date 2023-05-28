using System.Drawing;
using System.Text;

namespace ImageProcessingLib
{
    public class BitmapToASCII
    {
        public async Task<string> Processing<T>(Bitmap bitmap, T char_replace)
        {
            return await Task.Run(() =>
            {
                StringBuilder s = new();
                for (int y = 0; y < bitmap.Height; y++)
                {
                    for (int x = 0; x < bitmap.Width; x++)
                    {
                        var px = bitmap.GetPixel(x, y);
                        if (px.B < 200 && px.R < 200 && px.G < 200) s.Append(char_replace.ToString());
                        else s.Append(" ");
                    }
                    s.Append("\n");
                }
                return s.ToString();
            });
        }
    }
}