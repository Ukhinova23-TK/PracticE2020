using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Z08_1_WF
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
            Regex[] patterns = {new Regex(@"(^\d{3}-\d{3}$)"),
                                    new Regex(@"(^\d{2}-\d{2}-\d{2}$)"),
                                    new Regex(@"(^\d{3}-\d{2}-\d{2}$)")};
            if (!string.IsNullOrEmpty(str))
            {
                richTextBoxAnswer.Text = "Номера телефонов:\n";
                String[] str1 = str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                foreach (String item in str1)
                {
                    foreach (Regex pat in patterns)
                    {
                        if (pat.IsMatch(item.Trim(new char[] { ',', '.', ';', '!', '?', '\"', '\'', ':' })))
                        {
                            richTextBoxAnswer.Text += item.Trim(new char[] { ',', '.', ';', '!', '?', '\"', '\'', ':' }) + "\n";
                        }
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
