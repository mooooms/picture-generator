using System.Drawing;

namespace ImageGenerationLib.Algs
{
    public interface IPicturesGenerationAlg
    {
        public Bitmap Generate(Bitmap bitmap, int length=0);
    }
}
