using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z01_1_WF_02_05_2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            double x1, x2, x3, y1, y2, y3;
            double A, B, C;
            double p, S;
            x1 = (double)numericUpDownX1.Value;
            x2 = (double)numericUpDownX2.Value;
            x3 = (double)numericUpDownX3.Value;
            y1 = (double)numericUpDownY1.Value;
            y2 = (double)numericUpDownY2.Value;
            y3 = (double)numericUpDownY3.Value;
            A = Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)));
            B = Math.Sqrt((Math.Pow(x3 - x2, 2)) + (Math.Pow(y3 - y2, 2)));
            C = Math.Sqrt((Math.Pow(x3 - x1, 2)) + (Math.Pow(y3 - y1, 2)));
            p = (A + B + C) / 2;
            S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            textBoxSquart.Text = S.ToString();
        }
    }
}
