using System;

namespace Z07_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String str = Console.ReadLine();
                int sum = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsDigit(str[i]))
                    {
                        sum += Convert.ToInt32(str[i].ToString());
                    }
                }
                Console.WriteLine($"Сумма цифр в строке: {sum}");
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
