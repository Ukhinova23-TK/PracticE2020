using System;

namespace Z02_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double x, y;
                try
                {
                    Console.Write("Введите координату x: ");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите координату y: ");
                    y = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Неверные данные");
                    Console.ReadKey();
                    return;
                }
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
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
