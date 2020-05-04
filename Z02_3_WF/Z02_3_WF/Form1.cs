using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z02_3_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(numericUpDownRun.Value);
            int B = Convert.ToInt32(numericUpDownEnd.Value);
            if (A <= B)
            {
                for (int i = A; i <= B; i++)
                {
                    if (i % 2 == 0)
                    {
                        textBoxFor.Text += i + " ";
                    }
                }
                int index = A;
                while (index <= B)
                {
                    if (index % 2 == 0)
                    {
                        textBoxWhile.Text += index + " ";
                    }
                    index++;
                }
                index = A;
                do
                {
                    if (index % 2 == 0)
                    {
                        textBoxDoWhile.Text += index + " ";
                    }
                    index++;
                }
                while (index <= B);
            }
            else
            {
                textBoxFor.Text = "Начало диапазона не может быть больше конца.";
                textBoxWhile.Text = "Начало диапазона не может быть больше конца.";
                textBoxDoWhile.Text = "Начало диапазона не может быть больше конца.";
            }
        }
    }
}
