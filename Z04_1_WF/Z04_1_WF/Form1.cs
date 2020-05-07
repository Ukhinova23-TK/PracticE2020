using System;
using System.Windows.Forms;

namespace Z04_1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int B(uint n, int i = 1, int b1 = -10, int b2 = 2)
        {
            int b = Math.Abs(b1) - 6 * b2;
            if (i + 2 == n)
            {
                return b;
            }
            else if (n == 1)
            {
                return b1;
            }
            else if (n == 2)
            {
                return b2;
            }
            return B(n, ++i, b2, b);
        }

        private void button_Click(object sender, EventArgs e)
        {
            uint n;
            n = (uint)numericUpDownNum.Value;
            textBoxAnswer.Text = $"{B(n, 1, -10, 2)}";
        }
    }
}
