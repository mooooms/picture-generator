using ImageProcessingLib;

namespace PicturesGUI
{
    public partial class ProcessingForm : Form
    {
        public ProcessingForm()=>InitializeComponent();

        private void Save_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "текстовые файлы (*.rtf)|*.rtf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) PhotoBox.SaveFile(saveFileDialog.FileName);
        }
       
        private async void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "файлы изображений (*.jpg;*.bmp;*.png)|*.jpg;*.bmp;*.png";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImageProcessingLib.BitmapToASCII bitmapToASCII = new BitmapToASCII();
                Bitmap bitmap = new Bitmap(openFileDialog.FileName);
                var res = await bitmapToASCII.Processing(bitmap, textBox1.Text);
                PhotoBox.Text = res;
                res = null;
                bitmap.Dispose();
            }
        }    
    }
}
