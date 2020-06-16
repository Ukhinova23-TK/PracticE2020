using System;
using System.Windows.Forms;

namespace Z06_07
{
    public partial class Unit26_main : Form
    {
        public Unit26_main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр класса, соответствующего второй форме
            Unit26_secondary f = new Unit26_secondary();
            // Если нажата кнопка OK
            if (f.ShowDialog() == DialogResult.OK)
            {
                // то передаем данные из текстового поля второй формы в поле на первой форме
                textBox1.Text = f.textBox1.Text;
            }
        }
    }
}
