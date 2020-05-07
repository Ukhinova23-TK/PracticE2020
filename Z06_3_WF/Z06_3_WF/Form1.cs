using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z06_3_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[,] Init()
        {
            uint n;
            n = (uint)numericUpDownSize.Value;
            int[,] mass = new int[n, n];
            string allstr = richTextBoxMass.Text;
            string[] str = allstr.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (n == str.Length)
            {
                for (int i = 0; i < n; ++i)
                {
                    string[] str1 = str[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    if (n == str1.Length)
                    {
                        try
                        {
                            for (int j = 0; j < n; j++)
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
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    richTextBoxPrint.Text += $"{mass[i, j]} ";
                }
                richTextBoxPrint.Text += "\n";
            }
        }

        public int Norm(int[,] mass)
        {
            int norm = 0, max;
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                max = mass[0, i];
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if (mass[j, i] > max)
                    {
                        max = mass[j, i];
                    }
                }
                norm += max;
            }
            return norm;
        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] mass = Init();
                Print(mass);
                textBoxAnswer.Text = $"Норма: {Norm(mass)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
