using System;
using System.Windows.Forms;

namespace Z06_07
{
    public partial class Unit22 : Form
    {
        public Unit22()
        {
            InitializeComponent();
        }

        private void Unit22_Load(object sender, EventArgs e)
        {
            linkLabel1.Links[0].LinkData = "https://microsoft.com";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Запускаем браузер и открываем в нем страницу.
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
