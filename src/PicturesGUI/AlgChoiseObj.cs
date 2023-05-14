
namespace PicturesGUI
{
    public enum alg
    {
        Градиент,
        Квадраты,
        Шум
    }

   public class AlgChoiseObj
    {
        public alg Alg { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
    }
}
