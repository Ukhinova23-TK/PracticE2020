using System;
using System.Drawing;
using System.Windows.Forms;

namespace Z06_07
{
    public partial class Unit29 : Form
    {
        Font userFont = DefaultFont;

        public Unit29()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("Test", userFont, Brushes.Black, 20, 20);
            base.OnPaint(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                // Получение шрифта из диалогового окна.
                userFont = fontDialog1.Font;
                // Перерисовка формы.
                Invalidate();
            }
        }
    }
}
