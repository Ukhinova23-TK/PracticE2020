using System;
using System.Windows.Forms;

namespace Z07_2_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            String str = richTextBoxText.Text;
            if (!string.IsNullOrEmpty(str))
            {
                String[] str1 = str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                int size = str1[0].Length;
                for (int i = 1; i < str1.Length; i++)
                {
                    str1[i] = str1[i].Trim(new char[] { ',', '.', ';', '!', '?', '\"', '\'', ':' });
                    if (str1[i].Length > size)
                    {
                        size = str1[i].Length;
                    }
                }
                richTextBoxAnswer.Text = "Самые длинные слова сообщения:\n";
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i].Length == size)
                    {
                        richTextBoxAnswer.Text += str1[i] + "\n";
                    }
                }
            }
            else
            {
                MessageBox.Show(text: "Строка пуста");
            }
        }
    }
}
