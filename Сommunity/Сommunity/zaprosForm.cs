using System;
using System.Data;
using System.Data.OleDb;
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
            //OleDbConnection sqlconn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\\College\\PP_PM01\\Общежитие.mdb;");
            //sqlconn.Open();
            //string s = "";
            //if (radioButton1.Checked) { s = "SELECT * FROM Students"; }
            //if (radioButton2.Checked) { s = "SELECT SNP, Group, Address FROM Students"; }
            //if (radioButton3.Checked) { s = "SELECT DISTINCT Group FROM Students"; }
            //if (radioButton4.Checked) { s = "SELECT * FROM rooms WHERE Flour=3"; }
            //if (radioButton5.Checked) { s = "SELECT * FROM Students WHERE Students.Group LIKE 'ПО%'"; }
            //OleDbDataAdapter oda = new OleDbDataAdapter(s, sqlconn);
            //DataTable dt = new DataTable();
            //oda.Fill(dt);
            //dataGridView1.DataSource = dt;
            //sqlconn.Close();

            OleDbConnection sqlconn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\\College\\PP_PM01\\Общежитие.mdb;");
            sqlconn.Open();
            if (radioButton1.Checked)
            {
                OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM Students", sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
            if (radioButton2.Checked)
            {
                OleDbDataAdapter oda = new OleDbDataAdapter("SELECT SNP, Group, Address FROM Students", sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
            if (radioButton3.Checked)
            {
                OleDbDataAdapter oda = new OleDbDataAdapter("SELECT DISTINCT Group FROM Students", sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
            if (radioButton4.Checked)
            {
                OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM rooms WHERE Flour=3", sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
            if (radioButton5.Checked)
            {
                OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM Students WHERE Students.Group LIKE 'ПО%'", sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
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
