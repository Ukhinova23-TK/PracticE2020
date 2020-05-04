using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z02_1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Image imgfield = Image.FromFile(@"D:\Колледж\ПП ПМ01\Z02_1_WF\Z02_1_WF\Field.jpg");
            pictureBoxField.Image = imgfield;
            pictureBoxField.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button_Click(object sender, EventArgs e)
        {
            double x = (double)numericUpDownX.Value;
            double y = (double)numericUpDownY.Value;
            if (x > 40 || x < -40 || y > 40 || y < -40)
            {
                textBoxAnswer.Text = "Точка в области";
            }
            else if (((x == 40 || x == -40) && (y >= -40 || y <= 40)) || ((y == 40 || y == -40) && (x >= -40 || x <= 40)))
            {
                textBoxAnswer.Text = "Точка на границе области";
            }
            else
            {
                textBoxAnswer.Text = "Точка вне области";
            }
        }
    }
}
