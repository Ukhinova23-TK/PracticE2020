using System;
using System.Windows.Forms;

namespace Z06_1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] Init()
        {
            uint n;
            n = (uint)numericUpDownSize.Value;
            int[] mass = new int[n];
            string allstr = textBoxMass.Text;
            string[] str = allstr.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            if (mass.Length == str.Length)
            {
                try
                {
                    for (int i = 0; i < n; ++i)
                    {
                        mass[i] = Convert.ToInt32(str[i].Trim());
                    }
                    return mass;
                }
                catch
                {
                    throw new Exception("Неверные данные");
                }
                
            }
            else
            {
                throw new Exception("Размер не соответствует введенным данным");
            }
        }

        public void Print(int[] mass)
        {
            textBoxPrint.Text = "";
            foreach(int item in mass)
            {
                textBoxPrint.Text += $"{item} ";
            }
        }

        public int Sum(int[] mass)
        {
            int sum = 0;
            foreach (int item in mass)
            {
                if (item % 2 == 0)
                {
                    sum += item * item;
                }
            }
            return sum;
        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                int[] mass = Init();
                Print(mass);
                textBoxAnswer.Text = $"Сумма квадратов четных элементов: {Sum(mass)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
