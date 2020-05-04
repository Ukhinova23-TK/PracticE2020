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
            int A = (int)numericUpDownKrat.Value;
            string num = numericUpDownNum.Value.ToString();
            int sum = Convert.ToInt32(num[0].ToString()) + Convert.ToInt32(num[1].ToString());
            if (sum % A == 0)
            {
                textBoxAnswer.Text = "Число кратно" + A;
            }
            else
            {
                textBoxAnswer.Text = "Число не кратно" + A;
            }
        }
    }
}
