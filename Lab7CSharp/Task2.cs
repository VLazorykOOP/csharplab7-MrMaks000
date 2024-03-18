using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void Task2_Load(object sender, EventArgs e)
        {

        }    

        private Bitmap ToGrayScale(Bitmap original)
        {
            Bitmap grayScale = new Bitmap(original.Width, original.Height);

            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    Color pixel = original.GetPixel(i, j);
                    int grayValue = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);
                    Color grayPixel = Color.FromArgb(grayValue, grayValue, grayValue);
                    grayScale.SetPixel(i, j, grayPixel);
                }
            }

            return grayScale;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap originalImage = new Bitmap(openFileDialog.FileName);
                Bitmap grayScaleImage = ToGrayScale(originalImage);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = grayScaleImage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(saveFileDialog.FileName);
                }
            }
            else
            {
                MessageBox.Show("Спочатку завантажте зображення.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
