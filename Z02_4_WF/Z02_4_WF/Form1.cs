using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z02_4_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int n;
            for (int i = 1; i <= 5; i++)
            {
                n = i;
                for (int j = 1; j <= i; j++)
                {
                    textBox.Text += n + " ";
                    n--;
                }
                textBox.Text += "\r\n";
            }
        }
    }
}
