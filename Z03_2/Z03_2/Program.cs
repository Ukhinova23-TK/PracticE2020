using System;

namespace Z03_2
{
    class Program
    {
        static double F(double x)
        {
            if (x <= 5)
            {
                return x * x + 5;
            }
            else if(x>5 && x < 20)
            {
                return 0;
            }
            else
            {
                return 1;
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
                }
                else
                {
                    Console.WriteLine("Начало интервала не может быть больше конца, шаг не может быть отриательным и больше нуля");
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
