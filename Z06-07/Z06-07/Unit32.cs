using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z06_07
{
    public partial class Unit32 : Form
    {
        public Unit32()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button pressed!");
        }

        private void Unit32_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
    }
}
