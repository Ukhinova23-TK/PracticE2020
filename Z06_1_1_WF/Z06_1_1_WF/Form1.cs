using System;
using System.Windows.Forms;

namespace Z06_1_1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[,] Init()
        {
            uint n, m;
            n = (uint)numericUpDownSize.Value;
            m = (uint)numericUpDownSize1.Value;
            int[,] mass = new int[n,m];
            string allstr = richTextBoxMass.Text;
            string[] str = allstr.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (n == str.Length)
            {
                for (int i = 0; i < n; ++i)
                {
                    string[] str1 = str[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    if (m == str1.Length)
                    {
                        try
                        {
                            for (int j = 0; j < m; j++)
                            {
                                mass[i, j] = Convert.ToInt32(str1[j].Trim());
                            }
                        }
                        catch
                        {
                            throw new Exception("Неверные данные");
                        }
                    }
                    else
                    {
                        throw new Exception("Количество столбцов не соответствует введенным данным");
                    }
                }
                return mass;
            }
            else
            {
                throw new Exception("Количество строк не соответствует введенным данным");
            }
        }

        public void Print(int[,] mass)
        {
            richTextBoxPrint.Text = "";
            for(int i=0; i<mass.GetLength(0); i++)
            {
                for(int j=0; j<mass.GetLength(1); j++)
                {
                    richTextBoxPrint.Text += $"{mass[i,j]} ";
                }
                richTextBoxPrint.Text += "\n";
            }
        }

        public int Sum(int[,] mass)
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
                int[,] mass = Init();
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
