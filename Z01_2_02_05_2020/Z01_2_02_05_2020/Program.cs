using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z01_2_02_05_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            string num;
            int sum, help;
            try
            {
                Console.Write("Кратность: ");
                A = Convert.ToInt32(Console.ReadLine());
                if (A == 0)
                {
                    Console.WriteLine("Кратность не может быть равна 0");
                    Console.ReadKey();
                    return;
                }
                Console.Write("Двузначное число: ");
                help = Convert.ToInt32(Console.ReadLine());
                if (help < 0)
                {
                    help *= -1;
                }
            }
            catch
            {
                Console.WriteLine("Неверные данные");
                Console.ReadKey();
                return;
            }
            num = help.ToString();
            if (num.Length == 2)
            {
                sum = Convert.ToInt32(num[0].ToString()) + Convert.ToInt32(num[1].ToString());
                if(sum%A == 0)
                {
                    Console.WriteLine($"Сумма цифр двузначного числа кратна {A}");
                }
                else
                {
                    Console.WriteLine($"Сумма цифр двузначного числа не кратна {A}");
                }
            }
            else
            {
                Console.WriteLine("Введенное - не двузначное число!");
            }
            Console.ReadKey();
        }
    }
}
