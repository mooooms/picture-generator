using ImageGenerationLib;
using ImageGenerationLib.Algs;

namespace PicturesGUI
{
    public partial class PictureGenerate : Form
    {

        public PictureGenerate() => InitializeComponent();

        Bitmap _bitmap;
        private void clear_button_Click(object sender, EventArgs e)
        {
            picture.Image = null;
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "файлы изображений (*.bmp)|*.bmp";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _bitmap.Save(saveFileDialog.FileName);
            }
        }
        private void размерКартинкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoisePictureForm  cpf = new ChoisePictureForm();
           
            if (cpf.ShowDialog() == DialogResult.OK)
            {
                var gen = cpf.alg_choise_obj;
                Generate(gen);
            }
        }

        private void Generate(AlgChoiseObj gen)
        {
            Generator generator = new Generator(gen.Width, gen.Height);
            IPicturesGenerationAlg alg;
            switch (gen.Alg)
            {
                case PicturesGUI.alg.Градиент: alg = new GradientBasedPicture(); break;
                case PicturesGUI.alg.Квадраты: alg = new SquareBasedPicture(); break;
                case PicturesGUI.alg.Шум: alg = new NoiseBasedPicture(); break;
                default: return;
            }
            generator.SetAlg(alg);
            _bitmap = generator.Generate(gen.Length);
            picture.Image = _bitmap;
        }
    }
}
   