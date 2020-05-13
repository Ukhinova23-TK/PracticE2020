using System;
using System.Windows.Forms;

namespace Сommunity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItemRoom_Click(object sender, EventArgs e)
        {
            roomsForm form2 = new roomsForm();
            form2.Text = "Комнаты";
            form2.ShowDialog();
        }

        private void toolStripMenuItemLgota_Click(object sender, EventArgs e)
        {
            lgotaForm form3 = new lgotaForm();
            form3.Text = "Льготы";
            form3.ShowDialog();
        }

        private void toolStripMenuItemStudents_Click(object sender, EventArgs e)
        {
            studetsForm form4 = new studetsForm();
            form4.Text = "Студенты";
            form4.ShowDialog();
        }

        private void toolStripMenuItemRasselenie_Click(object sender, EventArgs e)
        {
            rasselenieForm form5 = new rasselenieForm();
            form5.Text = "Расселение";
            form5.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            zaprosForm form6 = new zaprosForm();
            form6.Text = "Запрос";
            form6.ShowDialog();
        }

        private void toolStripButtonReport_Click(object sender, EventArgs e)
        {
            Otchet form7 = new Otchet();
            form7.Text = "Отчет";
            form7.ShowDialog();
        }
    }
}
