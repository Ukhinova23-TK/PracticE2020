using System;
using System.Windows.Forms;

namespace Z06_07
{
    public partial class Unit31 : Form
    {
        public Unit31()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Установка начальной папки.
            saveFileDialog1.InitialDirectory = "C:\tmp";
            // Задание возможных расширений для файла.
            saveFileDialog1.Filter = "abc files (*.abs)|*.abs|All files|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Код по сохранению...
                string fileName = saveFileDialog1.FileName;
                // ...
            }
        }
    }
}
