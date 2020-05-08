using System;
using System.Text.RegularExpressions;

namespace Z08_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String str = Console.ReadLine();
                Regex[] patterns = {new Regex(@"(^\d{3}-\d{3}$)"),
                                    new Regex(@"(^\d{2}-\d{2}-\d{2}$)"),
                                    new Regex(@"(^\d{3}-\d{2}-\d{2}$)")};
                if (!string.IsNullOrEmpty(str))
                {
                    Console.WriteLine("Номера телефонов:");
                    String[] str1 = str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    foreach(String item in str1)
                    {
                        foreach(Regex pat in patterns)
                        {
                            if (pat.IsMatch(item.Trim(new char[] { ',', '.', ';', '!', '?', '\"', '\'', ':' })))
                            {
                                Console.WriteLine(item.Trim(new char[] { ',', '.', ';', '!', '?', '\"', '\'', ':' }));
                            }
                        }
                    }
                    Console.ReadKey();
                }
                else
                {
                    throw new Exception("Строка пуста");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
