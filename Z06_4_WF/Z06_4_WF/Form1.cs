using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z06_4_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[][] Init()
        {
            uint n;
            n = (uint)numericUpDownSize.Value;
            int[][] mass = new int[n][];
            string allstr = richTextBoxMass.Text;
            string[] str = allstr.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (n == str.Length)
            {
                for (int i = 0; i < n; ++i)
                {
                    mass[i] = new int[n];
                    string[] str1 = str[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    if (n == str1.Length)
                    {
                        try
                        {
                            for (int j = 0; j < n; j++)
                            {
                                mass[i][j] = Convert.ToInt32(str1[j].Trim());
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

        public void PrintMass(int[][] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass[i].Length; j++)
                {
                    richTextBoxPrint.Text += $"{mass[i][j]} ";
                }
                richTextBoxPrint.Text += "\n";
            }
        }

        public void PrintRezult(int[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                textBoxAnswer.Text += $"{mass[i]} ";
            }
        }

        public int[] Not_Chet(int[][] mass)
        {
            int[] new_mass = new int[mass.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = mass[i].Length - 1; j >= 0; j--)
                {
                    if (mass[j][i] % 2 != 0)
                    {
                        new_mass[i] = mass[j][i];
                        break;
                    }
                }
                if (new_mass[i] == 0)
                {
                    new_mass[i] = -1;
                }
            }
            return new_mass;
        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxPrint.Text = "";
                textBoxAnswer.Text = "";
                int[][] mass = Init();
                PrintMass(mass);
                PrintRezult(Not_Chet(mass));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
