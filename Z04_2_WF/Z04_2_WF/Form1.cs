using System;
using System.Windows.Forms;

namespace Z04_2_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Del(int num, int n)
        {
            if (n >= 1)
            {
                if (num % n == 0)
                {
                    richTextBoxAnswer.Text += $"{n} ";
                }
                Del(num, --n);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            richTextBoxAnswer.Text = "";
            int num;
            num = (int)numericUpDownNum.Value;
            if (num < 0)
            {
                num *= -1;
            }
            if (num == 0)
            {
                richTextBoxAnswer.Text = "У этого числа нет делителей";
                return;
            }
            Del(num, num);
        }
    }
}
