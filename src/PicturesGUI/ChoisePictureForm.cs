
using ImageGenerationLib.Algs;

namespace PicturesGUI
{
    public partial class ChoisePictureForm : Form
    {
        public AlgChoiseObj alg_choise_obj { get; }
        public ChoisePictureForm()
        {
            InitializeComponent();
            alg_choise_obj = new AlgChoiseObj();
            TypePictureText.DataSource = Enum.GetValues(typeof(alg));
            TypePictureText.SelectedItem = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            alg_choise_obj.Alg = (alg)TypePictureText.SelectedItem;
            alg_choise_obj.Width = (int)WidthPictureText.Value;
            alg_choise_obj.Height = (int)HeightPictureText.Value;
            if ((alg)TypePictureText.SelectedItem == alg.Квадраты)
            {
                alg_choise_obj.Length= (int)LengthFiguresPictureText.Value;
            }
        }
 
        private void TypePictureText_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypePictureText.Items.Count==1)
            {
                LengthFiguresPictureText.Visible = false;
            }
            else
            {
                LengthFiguresPictureText.Visible = true;
            }
        }
      
    }
}
