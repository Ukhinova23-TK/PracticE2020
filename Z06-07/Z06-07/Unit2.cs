using System;
using System.Windows.Forms;

namespace Z06_07
{
    public partial class Unit2 : Form
    {
        public Unit2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = 0;
            try
            {
                result = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
                label1.Text = result.ToString();
            }
            catch (DivideByZeroException ex)
            {
                label1.Text = ex.Message;
            }
            catch
            {
                label1.Text = "Неизвестная ошибка!";
            }
        }
    }
}
