using ImageGenerationLib;
using ImageGenerationLib.Algs;

namespace PicturesGUI
{
    public partial class Form1 : Form
    {

        public Form1()=> InitializeComponent();

        Bitmap _bitmap;
        private void generate_Click(object sender, EventArgs e)
        {
            Generator gen = new Generator(picture.Width, picture.Height);
            Random random = new Random();
            //добавить возможность выбора
            if (random.Next(2) == 1)
            {
                gen.SetAlg(new GradientBasedPicture());
                _bitmap = gen.Generate();
            }
            else
            {
                gen.SetAlg(new SquareBasedPicture());
                _bitmap = gen.Generate(50);
            }
           
            picture.Image = _bitmap;
        }

        private void save_Click(object sender, EventArgs e)
        {
           SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "файлы изображений (*.bmp)"; 
           if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _bitmap.Save(saveFileDialog.FileName);
            }
        }
    }
}