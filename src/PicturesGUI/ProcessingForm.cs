
using System.Drawing;

namespace PicturesGUI
{
    public partial class ProcessingForm : Form
    {
        public ProcessingForm()=>InitializeComponent();

        private void Save_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "текстовые файлы (*.rtf)|*.rtf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                PhotoBox.SaveFile(saveFileDialog.FileName);
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Processing();
        }
        async void Processing()
        {
            await Task.Run(() =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "файлы изображений (*.jpg;*.bmp;*.png)|*.jpg;*.bmp;*.png";
                string s = string.Empty;
                string t = textBox1.Text;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = new Bitmap(openFileDialog.FileName);

                    for (int y = 0; y < bitmap.Height; y++)
                    {
                        for (int x = 0; x < bitmap.Width; x++)
                        {
                            var px = bitmap.GetPixel(x, y);
                            if (px.B < 200 && px.R < 200 && px.G < 200) s += t;
                            else s += " ";

                        }
                        s += "\n";
                    }
                    PhotoBox.Text = s;
                }
            });
        }
    }
}
