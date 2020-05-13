using System;
using System.Windows.Forms;

namespace Сommunity
{
    public partial class studetsForm : Form
    {
        public studetsForm()
        {
            InitializeComponent();
        }

        private void studetsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "общежитиеDataSet.students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.общежитиеDataSet.students);

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            studentsTableAdapter.Update(общежитиеDataSet);
        }
    }
}
