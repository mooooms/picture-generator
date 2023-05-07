using System.Drawing;

namespace ImageGenerationLib.Algs
{
    internal struct PointWithColor
    {
        public PointWithColor(int x, int y, Color color)
        {
            this.X = x;
            this.Y = y;
            this.Color = color;
        }
        public int X;
        public int Y;
        public Color Color;
    }
}
