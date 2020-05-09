using System;
using System.IO;
using System.Windows.Forms;

namespace Z09_2_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Output()
        {
            try
            {
                uint size = (uint)numericUpDownSize.Value;
                string str; bool f = false;
                using (StreamReader sr = new StreamReader("text.txt"))
                {
                    while (sr.Peek() > -1)
                    {
                        str = sr.ReadLine();
                        if (str.Length == size)
                        {
                            f = true;
                            richTextBoxAnswer.Text = str + "\n";
                        }
                    }
                    if (!f)
                    {
                        richTextBoxAnswer.Text = "Нет подходящих по размеру строк";
                    }
                }
            }
            catch
            {
                throw new Exception("Неверные данные");
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                Output();
            }
            catch (Exception ex)
            {
                MessageBox.Show(text: ex.Message);
            }
        }
    }
}
