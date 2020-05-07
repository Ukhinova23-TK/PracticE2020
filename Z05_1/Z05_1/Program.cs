using System;

namespace Z05_1
{
    class Program
    {
        static double F(double x)
        {
            if(x>=0 && x <= 2)
            {
                throw new Exception("Функция не определена");
            }
            return Math.Log(x / (x - 2));
        }

        static void Main(string[] args)
        {
            try
            {
                double A, B, H;
                try
                {
                    Console.Write("Начало интервала: ");
                    A = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Конец интервала: ");
                    B = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Шаг интервала: ");
                    H = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Неверные данные");
                    Console.ReadKey();
                    return;
                }
                if (A > B)
                {
                    throw new Exception("Начало интервала не может быть больше конца");
                }
                if (H <= 0)
                {
                    throw new Exception("Шаг интервала должен быть сторого положительным");
                }
                for(double i=A; i<B; i += H)
                {
                    try
                    {
                        Console.Write($"F({i}) = {F(i)}\n");
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
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
