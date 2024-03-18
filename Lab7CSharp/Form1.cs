using System;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double seconds = DateTime.Now.TimeOfDay.TotalSeconds;
            labelResult.Text = seconds.ToString("0.0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string binarySeconds = Convert.ToString((long)DateTime.Now.TimeOfDay.TotalSeconds, 2);
            labelResult.Text = binarySeconds;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string hexSeconds = ((long)DateTime.Now.TimeOfDay.TotalSeconds).ToString("X");
            labelResult.Text = hexSeconds;
        }
    }
}

