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
            saveFileDialog.Filter = "ôàéëû èçîáğàæåíèé (*.bmp)|*.bmp";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _bitmap.Save(saveFileDialog.FileName);
            }
        }
        private void ğàçìåğÊàğòèíêèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoisePictureForm cpf = new ChoisePictureForm();

            if (cpf.ShowDialog() == DialogResult.OK)
            {
                var gen = cpf.alg_choise_obj;
                Generate(gen);
            }
        }

        private async void Generate(AlgChoiseObj gen)
        {
            Generator generator = new Generator(gen.Width, gen.Height);
            IPicturesGenerationAlg alg;
            switch (gen.Alg)
            {
                case PicturesGUI.alg.Ãğàäèåíò: alg = new GradientBasedPicture(); break;
                case PicturesGUI.alg.Êâàäğàòû: alg = new SquareBasedPicture(); break;
                case PicturesGUI.alg.Øóì: alg = new NoiseBasedPicture(); break;
                default: return;
            }
            generator.SetAlg(alg);
            _bitmap = await Task.Run(() => generator.Generate(gen.Length));
            picture.Image = _bitmap;
        }
    }
}
