using System;
using System.Drawing;
using System.Windows.Forms;

namespace Z06_07
{
    public partial class Unit28 : Form
    {
        public Unit28()
        {
            InitializeComponent();
        }

        Color color;
        string firstName;

        private void Unit28_Load(object sender, EventArgs e)
        {
            try
            {
                // Восстановление настроек.
                color = Properties.Settings.Default.MyColor;
                firstName = Properties.Settings.Default.FirstName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Новые значения для настроек.
            color = Color.Firebrick;
            firstName = "Lucrezia";
            Invalidate();

            // Запись настроек.
            Properties.Settings.Default.MyColor = Color.Firebrick;
            Properties.Settings.Default.FirstName = firstName;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Новые значения для настроек.
            color = Color.MediumPurple;
            firstName = "Selestina";
            Invalidate();

            // Запись настроек.
            Properties.Settings.Default.MyColor = color;
            Properties.Settings.Default.FirstName = firstName;
            Properties.Settings.Default.Save();
        }

        private void Unit28_Paint(object sender, PaintEventArgs e)
        {
            // Использование настроек.
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 10);
            g.DrawString(firstName, font, new SolidBrush(color), 100, 100);
        }
    }
}
