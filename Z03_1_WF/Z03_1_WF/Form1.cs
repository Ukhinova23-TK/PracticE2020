using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z03_1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void F(int x)
        {
            string num = x.ToString();
            if (num[0] == '-' && num.Length == 3)
            {
                x = Convert.ToInt32(num[0].ToString() + num[2].ToString() + num[1].ToString());
                textBoxAnswer.Text = x + "";
            }
            else if (num.Length == 2)
            {
                x = Convert.ToInt32(num[1].ToString() + num[0].ToString());
                textBoxAnswer.Text = x + "";
            }
            else
            {
                Console.WriteLine("Число не двузначное");
                textBoxAnswer.Text = "Число " + x + " не двузначное";
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(numericUpDownNum.Value);
            F(num);
        }
    }
}
