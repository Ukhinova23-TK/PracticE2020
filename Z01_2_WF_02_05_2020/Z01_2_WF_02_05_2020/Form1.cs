using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z01_2_WF_02_05_2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int A;
            string num;
            int sum, help;
            A = (int)numericUpDownKrat.Value;
            if (A == 0)
            {
                textBox.Text = "Кратность не может быть равна 0";
                return;
            }
            help = (int)numericUpDownNum.Value;
            if (help < 0)
            {
                help *= -1;
            }
            num = help.ToString();
            if (num.Length == 2)
            {
                sum = Convert.ToInt32(num[0].ToString()) + Convert.ToInt32(num[1].ToString());
                if (sum % A == 0)
                {
                    textBox.Text = $"Сумма цифр двузначного числа кратна {A}";
                }
                else
                {
                    textBox.Text = $"Сумма цифр двузначного числа не кратна {A}";
                }
            }
            else
            {
                textBox.Text = "Введенное - не двузначное число!";
            }
        }
    }
}
