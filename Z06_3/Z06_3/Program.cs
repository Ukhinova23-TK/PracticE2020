using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z06_3
{
    class Program
    {
        static int[,] Init()
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
                int[,] mass = new int[n, n];
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"mass[{i}][{j}]= ");
                        mass[i, j] = Convert.ToInt32(Console.ReadLine());
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
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write($"{mass[i, j]} ");
                }
                Console.Write("\n");
            }
            Console.WriteLine();
        }

        static int Norm(int[,] mass)
        {
            int norm = 0, max;
            for(int i = 0; i<mass.GetLength(0); i++)
            {
                max = mass[0,i];
                for (int j = 0; j<mass.GetLength(1); j++)
                {
                    if (mass[j, i] > max)
                    {
                        max = mass[j, i];
                    }
                }
                norm += max;
            }
            return norm;
        }

        static void Main(string[] args)
        {
            try
            {
                int[,] mass = Init();
                Print(mass);
                Console.WriteLine($"Норма: {Norm(mass)}");
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

