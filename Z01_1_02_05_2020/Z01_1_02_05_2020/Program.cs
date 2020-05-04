using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z01_1_02_05_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double x1, x2, x3, y1, y2, y3;
                double A, B, C;
                double p, S;
                try
                {
                    Console.Write("Координата х1 = ");
                    x1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Координата y1 = ");
                    y1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Координата х2 = ");
                    x2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Координата y2 = ");
                    y2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Координата х3 = ");
                    x3 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Координата y3 = ");
                    y3 = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Неверные данные");
                    Console.ReadKey();
                    return;
                }
                A = Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)));
                B = Math.Sqrt((Math.Pow(x3 - x2, 2)) + (Math.Pow(y3 - y2, 2)));
                C = Math.Sqrt((Math.Pow(x3 - x1, 2)) + (Math.Pow(y3 - y1, 2)));
                p = (A + B + C) / 2;
                S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
                Console.WriteLine($"Площадь треугольника равна {S}");
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
