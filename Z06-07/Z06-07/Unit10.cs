using System;
using System.Drawing;
using System.Windows.Forms;

namespace Z06_07
{
    public partial class Unit10 : Form
    {
        public Unit10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Размер экрана.
            Size sz = SystemInformation.PrimaryMonitorSize;
            textBox1.Text = sz.ToString();

            // Имя компьтера.
            String cn = SystemInformation.ComputerName;
            textBox2.Text = cn;

            // Количество кнопок у мыши.
            int k = SystemInformation.MouseButtons;
            textBox3.Text = k.ToString();

            // Используемый шрифт для меню и его имя.
            Font f = SystemInformation.MenuFont;
            String fn = f.Name;
            textBox4.Text = f.ToString() + " " + fn;

            // Присутствует ли сеть?
            bool b = SystemInformation.Network;
            textBox5.Text = b.ToString();

            // Имя текущего пользователя.
            String un = SystemInformation.UserName;
            textBox6.Text = un;

            // Ширина вертикальной полосы прокрутки.
            int w = SystemInformation.VerticalScrollBarWidth;
            textBox7.Text = w.ToString();

            button1.Enabled = false;
        }
        
    }
}
