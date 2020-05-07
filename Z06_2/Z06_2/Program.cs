using System;

namespace Z06_2
{
    class Program
    {
        static int[] Init()
        {
            uint n;
            try
            {
                Console.Write("Размер массива: ");
                n = Convert.ToUInt32(Console.ReadLine());
                if (n == 0)
                {
                    throw new Exception("Неверные данные");
                }
                int[] mass = new int[n];
                for (int i = 0; i < n; ++i)
                {
                    Console.Write($"mass[{i}]= ");
                    mass[i] = Convert.ToInt32(Console.ReadLine());
                }
                return mass;
            }
            catch
            {
                throw new Exception("Неверные данные");
            }
        }

        static void Funcion(int[] mass)
        {
            int max, max_i, min, min_i, sum = 0;
            max = mass[0];
            max_i = 0;
            for (int i = 1; i < mass.Length; i++)
            {
                if (mass[i] > max)
                {
                    max = mass[i];
                    max_i = i;
                }
            }
            min = mass[0];
            min_i = 0;
            for (int i = 1; i < mass.Length; i++)
            {
                if (mass[i] <= min)
                {
                    min = mass[i];
                    min_i = i;
                }
            }
            if (min_i < max_i)
            {
                Console.WriteLine("Максимальный элемент встретился позже минимального");
                return;
            }
            else
            {
                for (int i = max_i + 1; i < min_i; i++)
                {
                    sum += mass[i];
                }
                Console.WriteLine($"Сумма: {sum}");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                int[] mass = Init();
                Funcion(mass);
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
