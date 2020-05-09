using System;
using System.Windows.Forms;

namespace Z11_1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonP1_Click(object sender, EventArgs e)
        {
            textBox1P1.Text = "";
            textBox2P1.Text = "";
            textBox3P1.Text = "";
            Point point1 = new Point();
            textBox1P1.Text = point1.Print();
            point1.X = (int)numericUpDownXP1.Value;
            point1.Y = (int)numericUpDownYP1.Value;
            textBox2P1.Text = point1.Print();
            int x = (int)numericUpDownVXP1.Value;
            int y = (int)numericUpDownVYP1.Value;
            point1.Moving(x, y);
            textBox3P1.Text = point1.Print();
        }

        private void buttonP2_Click(object sender, EventArgs e)
        {
            textBox1P2.Text = "";
            textBox2P2.Text = "";
            textBox3P2.Text = "";
            int x = (int)numericUpDownXP2.Value;
            int y = (int)numericUpDownYP2.Value;
            Point point2 = new Point(x, y);
            textBox1P2.Text = point2.Print();
            int scal = (int)numericUpDownScal.Value;
            point2.ScalX = scal;
            point2.ScalY = scal;
            textBox2P2.Text = point2.Print();
            textBox3P2.Text = $"Расстояние от точки до начала координат: {point2.Distance()}";
        }
    }
}
