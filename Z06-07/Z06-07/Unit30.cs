using System;
using System.Windows.Forms;

namespace Z06_07
{
    public partial class Unit30 : Form
    {
        public Unit30()
        {
            InitializeComponent();
        }

        string fileName = "";

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                Text = fileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] fileNames;
                fileNames = openFileDialog1.FileNames;
                foreach (string s in fileNames)
                {
                    listBox1.Items.Add(s);
                }
            }
        }
    }
}
