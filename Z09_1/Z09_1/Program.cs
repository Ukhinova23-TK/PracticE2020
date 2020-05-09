using System;
using System.IO;

namespace Z09_1
{
    class Program
    {
        static void Init()
        {
            try
            {
                double A, B, H;
                try
                {
                    Console.Write("Начало интервала: ");
                    A = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Конец интервала: ");
                    B = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Шаг интервала: ");
                    H = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    throw new Exception("Неверные данные");
                }
                if (A > B)
                {
                    throw new Exception("Начало интервала не может быть больше конца");
                }
                if (H <= 0)
                {
                    throw new Exception("Шаг интервала должен быть сторого положительным");
                }
                using (BinaryWriter bw = new BinaryWriter(File.Open("file.dat", FileMode.Create)))
                {
                    for (double i = A; i <= B; i+=H)
                    {
                        bw.Write(i);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return;
            }
        }

        static void Outit()
        {
            try
            {
                double help;
                using(BinaryReader br = new BinaryReader(File.Open("file.dat", FileMode.Open)))
                {
                    while (br.PeekChar() > -1)
                    {
                        help = br.ReadDouble();
                        if (help > 0)
                        {
                            Console.Write(help + " ");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Init();
                Outit();
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
