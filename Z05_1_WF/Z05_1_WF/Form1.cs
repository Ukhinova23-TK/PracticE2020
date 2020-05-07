using System;
using System.Windows.Forms;

namespace Z05_1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double F(double x)
        {
            if (x >= 0 && x <= 2)
            {
                throw new Exception("Функция не определена\n");
            }
            return Math.Log(x / (x - 2));
        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxAnswer.Text = "";
                double A, B, H;
                A = (double)numericUpDownRun.Value;
                B = (double)numericUpDownEnd.Value;
                H = (double)numericUpDownFoot.Value;
                if (A > B)
                {
                    throw new Exception("Начало интервала не может быть больше конца");
                }
                if (H <= 0)
                {
                    throw new Exception("Шаг интервала должен быть сторого положительным");
                }
                for (double i = A; i < B; i += H)
                {
                    try
                    {
                        richTextBoxAnswer.Text += $"F({i}) = {F(i)}\n";
                    }
                    catch (Exception ex)
                    {
                        richTextBoxAnswer.Text += ex.Message;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(text: ex.Message);
            }
        }
    }
}
