using System;
namespace PicturesGUI
{
    public partial class Main : Form
    {
        public Main()=> InitializeComponent();

        private void Generate_Button_Click(object sender, EventArgs e)
        {
            PictureGenerate gpf = new PictureGenerate();
        }
        private void Processing_Button_Click(object sender, EventArgs e)
        {
            ProcessingForm pf = new ProcessingForm();
            pf.ShowDialog();

        }
    }
}
