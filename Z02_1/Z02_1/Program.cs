using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z02_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double x, y;
                Console.Write("Введите координату x: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату y: ");
                y = Convert.ToDouble(Console.ReadLine());
                if (x > 40 || x < -40 || y > 40 || y < -40)
                {
                    Console.WriteLine("Точка находится в области");
                }
                else if (((x == 40 || x == -40) && (y >= -40 || y <= 40)) || ((y == 40 || y == -40) && (x >= -40 || x <= 40)))
                {
                    Console.WriteLine("Точка находится на границе области");
                }
                else
                {
                    Console.WriteLine("Точка находится вне области");
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }
        }
    }
}
