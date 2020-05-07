using System;

namespace Z06_4
{
    class Program
    {
        static int[][] Init()
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
                int[][] mass = new int[n][];
                for (int i = 0; i < n; i++)
                {
                    mass[i] = new int[n];
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"a[{i},{j}]= ");
                        mass[i][j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                return mass;
            }
            catch
            {
                throw new Exception("Неверные данные");
            }
        }

        static void PrintRezult(int[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }
        }

        static void PrintMass(int[][] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass[i].Length; ++j)
                {
                    Console.Write($"{mass[i][j]} ");
                }
                Console.WriteLine();
            }
        }

        static int[] Not_Chet(int[][] mass)
        {
            int[] new_mass = new int[mass.Length];
            for(int i=0; i<mass.Length; i++)
            {
                for(int j = mass[i].Length - 1; j >= 0; j--)
                {
                    if(mass[j][i]%2 != 0)
                    {
                        new_mass[i] = mass[j][i];
                        break;
                    }
                }
                if(new_mass[i] == 0)
                {
                    new_mass[i] = -1;
                }
            }
            return new_mass;
        }

        static void Main(string[] args)
        {
            try
            {
                int[][] mass = Init();
                Console.WriteLine();
                PrintMass(mass);
                Console.WriteLine();
                PrintRezult(Not_Chet(mass));
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
