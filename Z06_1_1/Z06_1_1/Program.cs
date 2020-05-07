using System;

namespace Z06_1
{
    class Program
    {
        static int[,] Init()
        {
            uint n, m;
            try
            {
                Console.Write("Количество строк: ");
                n = Convert.ToUInt32(Console.ReadLine());
                Console.Write("Количество столбцов: ");
                m = Convert.ToUInt32(Console.ReadLine());
                if (n == 0 || m == 0)
                {
                    throw new Exception("Неверные данные");
                }
                int[,] mass = new int[n,m];
                for (int i = 0; i < n; ++i)
                {
                    for(int j=0; j<m; j++)
                    {
                        Console.Write($"mass[{i}][{j}]= ");
                        mass[i,j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                return mass;
            }
            catch
            {
                throw new Exception("Неверные данные");
            }
        }

        static void Print(int[,] mass)
        {
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for(int j=0; j<mass.GetLength(1); j++)
                {
                    Console.Write($"{mass[i,j]} ");
                }
            }
            Console.WriteLine();
        }

        static int Sum(int[,] mass)
        {
            int sum = 0;
            foreach (int item in mass)
            {
                if (item % 2 == 0)
                {
                    sum += item * item;
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            try
            {
                int[,] mass = Init();
                Print(mass);
                Console.WriteLine($"Сумма квадратов четных элементов: {Sum(mass)}");
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
