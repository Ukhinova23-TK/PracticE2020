using System;
using System.Windows.Forms;

namespace Z06_07
{
    public partial class Unit1 : Form
    {
        public Unit1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
            label1.Text = result.ToString();
        }
    }
}
