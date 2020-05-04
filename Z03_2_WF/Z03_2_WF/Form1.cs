using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z03_2_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double F(double x)
        {
            if (x <= 5)
            {
                return x * x + 5;
            }
            else if (x > 5 && x < 20)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            richTextBoxAnswer.Text = "";
            double a = Convert.ToDouble(numericUpDownRun.Value);
            double b = Convert.ToDouble(numericUpDownEnd.Value);
            double h = Convert.ToDouble(numericUpDownFoot.Value);
            if (a <= b && h>0)
            {
                for (double i = a; i <= b; i += h)
                {
                    richTextBoxAnswer.Text += $"f({i}) = {F(i)}\n";
                }
            }
            else
            {
                richTextBoxAnswer.Text = "Начало интервала не может быть больше конца, шаг не может быть отриательным";
            }
        }
    }
}
