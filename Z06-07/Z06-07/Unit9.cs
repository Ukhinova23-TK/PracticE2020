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
    public partial class Unit9 : Form
    {
        public Unit9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создание контекстного меню
            ContextMenuStrip cms = new ContextMenuStrip();

            // Добавление существующих элементов меню к элементам контекстного меню
            cms.Items.AddRange(new ToolStripItem[] {this.cutToolStripMenuItem,
                this.copyToolStripMenuItem, this.pasteToolStripMenuItem});

            // Подсоединение контекстного меню к главному окну.
            this.ContextMenuStrip = cms;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CUT");
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("COPY");
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PASTE");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FILE");
        }
    }
}
