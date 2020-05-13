using System;
using System.Windows.Forms;

namespace Сommunity
{
    public partial class roomsForm : Form
    {
        public roomsForm()
        {
            InitializeComponent();
        }

        private void roomsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "общежитиеDataSet.rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.общежитиеDataSet.rooms);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            roomsTableAdapter.Update(общежитиеDataSet);
        }
    }
}
