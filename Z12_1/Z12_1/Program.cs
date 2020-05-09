using System;

namespace Z12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите координату х: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите координату y: ");
                int y = Convert.ToInt32(Console.ReadLine());
                Point point = new Point(x, y);
                Console.WriteLine($"Изначальные координаты точки: {point.Print()}");
                point++;
                Console.WriteLine($"Точка++ = {point.Print()}");
                point--;
                Console.WriteLine($"Точка-- = {point.Print()}");
                Console.Write("Введите скаляр: ");
                int s = Convert.ToInt32(Console.ReadLine());
                point += s;
                Console.WriteLine($"Точка + скаляр = {point.Print()}");
                point = s + point;
                Console.WriteLine($"Скаляр + точка = {point.Print()}");
                if (point)
                {
                    Console.WriteLine("X == Y");
                }
                else
                {
                    Console.WriteLine("X != Y");
                }
                string str = (string)point;
                Console.WriteLine($"Преобразование в String: {str}");
                Point str_point = (Point)str;
                Console.WriteLine($"Преобразование в Point: {str_point.Print()}");
                Console.WriteLine($"Результат обращения по индексу 0: {point[0]}");
                Console.WriteLine($"Результат обращения по индексу 1: {point[1]}");
                Console.WriteLine($"Результат обращения по несуществующему индексу: {point[2]}");
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
