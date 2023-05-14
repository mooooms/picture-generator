using ImageGenerationLib;
using ImageGenerationLib.Algs;

namespace PicturesGUI
{
    public partial class Form1 : Form
    {

        public Form1() => InitializeComponent();

        Bitmap _bitmap;
        private void clear_button_Click(object sender, EventArgs e)
        {
            picture.Image = null;
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


        private void MenuGradient_Click(object sender, EventArgs e)
        {
            Generator gen = new Generator(picture.Width, picture.Height);
            gen.SetAlg(new GradientBasedPicture());
            _bitmap = gen.Generate();
            picture.Image = _bitmap;

        }
        private void MenuSquare_Click(object sender, EventArgs e)
        {
            Generator gen = new Generator(picture.Width, picture.Height);
            gen.SetAlg(new SquareBasedPicture());
            _bitmap = gen.Generate(50);
            picture.Image = _bitmap;
        }
        private void Noise_Button_Click(object sender, EventArgs e)
        {
            Generator gen = new Generator(picture.Width, picture.Height);
            gen.SetAlg(new NoiseBasedPicture());
            _bitmap = gen.Generate();
            picture.Image = _bitmap;
        }
    }
}
   