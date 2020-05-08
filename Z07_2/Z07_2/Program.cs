using System;

namespace Z07_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String str = Console.ReadLine();
                if (!string.IsNullOrEmpty(str))
                {
                    String[] str1 = str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    int size = str1[0].Length;
                    for (int i = 1; i < str1.Length; i++)
                    {
                        str1[i] = str1[i].Trim(new char[] { ',', '.', ';', '!', '?', '\"', '\'', ':' });
                        if (str1[i].Length > size)
                        {
                            size = str1[i].Length;
                        }
                    }
                    Console.WriteLine("Самые длинные слова сообщения:");
                    for (int i = 1; i < str1.Length; i++)
                    {
                        if (str1[i].Length == size)
                        {
                            Console.WriteLine(str1[i]);
                        }
                    }
                    Console.ReadKey();
                }
                else
                {
                    throw new Exception("Строка пуста");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
