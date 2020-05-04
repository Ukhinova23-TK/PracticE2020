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

        static void F(double x, out double y)
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
        }

        static void Main(string[] args)
        {
            try
            {
                double a, b, h;
                try
                {
                    Console.Write("Начало интервала: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Конец интервала: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Шаг интервала: ");
                    h = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Неверные данные");
                    Console.ReadKey();
                    return;
                }
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
                        F(i, out y);
                        Console.Write($"f({i}) = {y}\n");
                    }
                }
                else
                {
                    Console.WriteLine("Начало интервала не может быть больше конца, шаг не может быть отриательным и равным нулю");
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
