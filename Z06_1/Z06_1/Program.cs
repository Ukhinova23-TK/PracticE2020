using System;

namespace Z06_1
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

        static void Print(int[] mass)
        {
            for(int i=0; i<mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }
            Console.WriteLine();
        }

        static int Sum(int[] mass)
        {
            int sum = 0;
            foreach(int item in mass)
            {
                if(item%2 == 0)
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
                int[] mass = Init();
                Print(mass);
                Console.WriteLine($"Сумма квадратов четных элементов: {Sum(mass)}");
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
