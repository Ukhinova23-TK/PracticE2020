using System;
using System.IO;

namespace Z13_1
{
    class Program
    {
        static Figure[] ParseData()
        {
            try
            {
                string[] allstr;
                int a, b, c, r;
                if (File.Exists("Mass.txt"))
                {
                    using (StreamReader sr = new StreamReader("Mass.txt"))
                    {
                        allstr = sr.ReadToEnd().Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                    }
                    Figure[] fig_mass = new Figure[allstr.Length];
                    for (int i = 0; i < allstr.Length; i++)
                    {
                        string[] str = allstr[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                        if (str.Length == 1)
                        {
                            r = Convert.ToInt32(str[0]);
                            fig_mass[i] = new Circle(r);
                        }
                        else if (str.Length == 2)
                        {
                            a = Convert.ToInt32(str[0]);
                            b = Convert.ToInt32(str[1]);
                            fig_mass[i] = new Rectangle(a, b);
                        }
                        else if (str.Length == 3)
                        {
                            a = Convert.ToInt32(str[0]);
                            b = Convert.ToInt32(str[1]);
                            c = Convert.ToInt32(str[2]);
                            fig_mass[i] = new Triangle(a, b, c);
                        }
                        else
                        {
                            throw new Exception("Некорректные данные в файле");
                        }
                    }
                    return fig_mass;
                }
                else
                {
                    throw new Exception("Файл не существует");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Figure[] figures = ParseData();
                foreach (Figure figure in figures)
                {
                    figure.Show();
                }
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
