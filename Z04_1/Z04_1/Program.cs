using System;

namespace Z04_1
{
    class Program
    {
        static int B(uint n, int i = 1, int b1 = -10, int b2 = 2)
        {
            int b = Math.Abs(b1) - 6 * b2;
            if (i + 2 == n)
            {
                return b;
            }
            else if (n == 1)
            {
                return b1;
            }
            else if (n == 2)
            {
                return b2;
            }
            return B(n, ++i, b2, b);
        }

        static void Main(string[] args)
        {
            try
            {
                uint n;
                try
                {
                    Console.Write("Номер в последовательности: ");
                    n = Convert.ToUInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Неверные данные");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine($"Ответ: {B(n, 1, -10, 2)}");
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
