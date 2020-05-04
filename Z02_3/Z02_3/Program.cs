using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z02_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Начало диапазона: ");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.Write("Конец диапазона: ");
                int B = Convert.ToInt32(Console.ReadLine());
                if (A <= B)
                {
                    for (int i = A; i <= B; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    Console.WriteLine();
                    int index = A;
                    while (index <= B)
                    {
                        if (index % 2 == 0)
                        {
                            Console.Write(index + " ");
                        }
                        index++;
                    }
                    Console.WriteLine();
                    index = A;
                    do
                    {
                        if (index % 2 == 0)
                        {
                            Console.Write(index + " ");
                        }
                        index++;
                    }
                    while (index <= B);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Начало диапазона не может быть больше конца.");
                }
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }
         }   
    }
}
