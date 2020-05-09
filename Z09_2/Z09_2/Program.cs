using System;
using System.IO;

namespace Z09_2
{
    class Program
    {
        static void Output()
        {
            try
            {
                Console.Write("Размер строки: ");
                uint size = Convert.ToUInt32(Console.ReadLine());
                if (size != 0)
                {
                    string str; bool f = false;
                    using (StreamReader sr = new StreamReader("text.txt"))
                    {
                        while (sr.Peek() > -1)
                        {
                            str = sr.ReadLine();
                            if (str.Length == size)
                            {
                                f = true;
                                Console.WriteLine(str);
                            }
                        }
                        if (!f)
                        {
                            Console.WriteLine("Нет подходящих по размеру строк");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Размер строки должен быть больще нуля");
                    Console.ReadKey();
                    return;
                }
            }
            catch
            {
                Console.WriteLine("Неверные данные");
                Console.ReadKey();
                return;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Output();
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
