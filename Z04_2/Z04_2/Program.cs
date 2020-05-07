using System;

namespace Z04_2
{
    class Program
    {
        static void Del(int num, int n)
        {
            if (n >= 1)
            {
                if (num % n == 0)
                {
                    Console.Write($"{n} ");
                }
                Del(num, --n);
            }
        }

        static void Main(string[] args)
        {
            try
            {
                int num;
                try
                {
                    Console.Write("Число: ");
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Неверные данные");
                    Console.ReadKey();
                    return;
                }
                if (num < 0)
                {
                    num *= -1;
                }
                if (num == 0)
                {
                    Console.WriteLine("У этого числа нет делителей");
                    Console.ReadKey();
                    return;
                }
                Del(num, num);
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
