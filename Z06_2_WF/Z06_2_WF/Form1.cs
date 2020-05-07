using System;
using System.Windows.Forms;

namespace Z06_2_WF
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

        public void Funcion(int[] mass)
        {
            int max, max_i, min, min_i, sum = 0;
            max = mass[0];
            max_i = 0;
            for (int i = 1; i < mass.Length; i++)
            {
                if (mass[i] > max)
                {
                    max = mass[i];
                    max_i = i;
                }
            }
            min = mass[0];
            min_i = 0;
            for (int i = 1; i < mass.Length; i++)
            {
                if (mass[i] <= min)
                {
                    min = mass[i];
                    min_i = i;
                }
            }
            if (min_i < max_i)
            {
                textBoxAnswer.Text = "Максимальный элемент встретился позже минимального";
                return;
            }
            else
            {
                for (int i = max_i + 1; i < min_i; i++)
                {
                    sum += mass[i];
                }
                textBoxAnswer.Text = $"Сумма: {sum}";
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                int[] mass = Init();
                Funcion(mass);
            }
            catch(Exception ex)
            {
                MessageBox.Show(text: ex.Message);
            }
            
        }

    }
}
