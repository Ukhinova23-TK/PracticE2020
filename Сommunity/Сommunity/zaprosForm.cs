using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сommunity
{
    public partial class zaprosForm : Form
    {
        public zaprosForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection sqlconn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\\College\\PP_PM01\\Общежитие.mdb;");
            sqlconn.Open();
            string s = "";
            if (radioButton1.Checked) { s = "SELECT * FROM Students"; }
            if (radioButton2.Checked) { s = "SELECT SNP, Group, Address FROM Students"; }
            if (radioButton3.Checked) { s = "SELECT DISTINCT Group FROM Students"; }
            if (radioButton4.Checked) { s = "SELECT * FROM rooms WHERE Flour=3"; }
            if (radioButton5.Checked) { s = "SELECT * FROM Students WHERE Students.Group LIKE 'ПО%'"; }
            OleDbDataAdapter oda = new OleDbDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Columns.Count;
            for(int i=0; i<count; i++)
            {
                dataGridView1.Columns.RemoveAt(0);
            }
        }
    }
}
