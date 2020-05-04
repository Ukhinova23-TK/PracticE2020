using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z03_3
{
    class Program
    {
        static double F(double x)
        {
            if (x <= 5)
            {
                return x * x + 5;
            }
            else if (x > 5 && x < 20)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        static double F(double x, out double y)
        {
            if (x <= 5)
            {
                y = x * x + 5;
            }
            else if (x > 5 && x < 20)
            {
                y = 0;
            }
            else
            {
                y = 1;
            }
            return y;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Начало интервала: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Конец интервала: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Шаг интервала: ");
                double h = Convert.ToDouble(Console.ReadLine());
                if (a <= b && h>0)
                {
                    for (double i = a; i <= b; i += h)
                    {
                        Console.Write($"f({i}) = {F(i)}\n");
                    }
                    Console.WriteLine();
                    double y = 0;
                    for (double i = a; i <= b; i += h)
                    {
                        Console.Write($"f({i}) = {F(i, out y)}\n");
                    }
                }
                else
                {
                    Console.WriteLine("Начало интервала не может быть больше конца, шаг не может быть отриательным");
                }
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
