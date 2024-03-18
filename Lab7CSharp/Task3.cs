using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Task3 : Form
    {
        private Graphics graphics;
        private PictureBox pictureBox;

        public Task3()
        {
            InitializeComponent();
            InitializePictureBox();
            graphics = pictureBox.CreateGraphics();
        }

        private void Task3_Load(object sender, EventArgs e)
        {

        }

        private void InitializePictureBox()
        {
            pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.BackColor = Color.White;
            Controls.Add(pictureBox);
        }

        private void DrawShape(int x, int y, int width, int height, Color color, string shapeType)
        {
            Shape shape = null;
            switch (shapeType)
            {
                case "Pentagon":
                    shape = new Pentagon(x, y, width, height, color);
                    break;
                case "Rectangle":
                    shape = new Rectangle(x, y, width, height, color);
                    break;
                case "Triangle":
                    shape = new Triangle(x, y, width, height, color);
                    break;
                case "Rhombus":
                    shape = new Rhombus(x, y, width, height, color);
                    break;
                default:
                    MessageBox.Show("Invalid shape type!");
                    return;
            }

            shape.Draw(graphics);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtX.Text);
            int y = Convert.ToInt32(txtY.Text);
            int width = Convert.ToInt32(txtWidth.Text);
            int height = Convert.ToInt32(txtHeight.Text);
            Color color = Color.FromName(comboBoxColor.SelectedItem.ToString());
            string shapeType = comboBoxShape.SelectedItem.ToString();

            DrawShape(x, y, width, height, color, shapeType);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
