using ImageGenerationLib.Algs;
using System.Drawing;

namespace ImageGenerationLib
{
    public class Generator
    {
        private int _width, _height;
        private IPicturesGenerationAlg _algorithm;
        public Generator(int width, int height)
        {
            _width = width;
            _height = height;
        }
        public void SetAlg(IPicturesGenerationAlg alg)=> _algorithm=alg;
        
        public Bitmap Generate()
        {
            Bitmap bitmap = new Bitmap(_width, _height);
            _algorithm.Generate(bitmap);
            return bitmap;
        }
        public Bitmap Generate(int len)
        {
            Bitmap bitmap = new Bitmap(_width, _height);
            _algorithm.Generate(bitmap, len);
            return bitmap;
        }
    }
}