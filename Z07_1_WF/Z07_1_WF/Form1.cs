using System;
using System.Windows.Forms;

namespace Z07_1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            textBoxSum.Text = "";
            String str = textBoxStr.Text;
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    sum += Convert.ToInt32(str[i].ToString());
                }
            }
            textBoxSum.Text = $"Сумма цифр в строке: {sum}";
        }
    }
}
