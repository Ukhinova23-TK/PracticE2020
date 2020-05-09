using System;

namespace Z11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Point point1 = new Point();//Инициализация нулевыми значениями
                point1.Print();//Вывод координат
                Console.Write("Введите координату х: ");
                point1.X = Convert.ToInt32(Console.ReadLine());//Получение координаты х
                Console.Write("Введите координату y: ");
                point1.Y = Convert.ToInt32(Console.ReadLine());//Получение координаты у
                point1.Print();//Вывод координат
                Console.Write("Введите координату х вектора: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите координату y вектора: ");
                int y = Convert.ToInt32(Console.ReadLine());
                point1.Moving(x, y);//Перемещение на вектор
                point1.Print();
                Console.WriteLine();

                Console.Write("Введите координату х: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите координату y: ");
                y = Convert.ToInt32(Console.ReadLine());
                Point point2 = new Point(x, y);//Инициализация введенными значениями
                point2.Print();//Вывод координат
                Console.Write("Введите скаляр: ");
                int s = Convert.ToInt32(Console.ReadLine());
                point2.ScalX = s;//Умножение координаты на скалярное значение
                point2.ScalY = s;//Умножение координаты на скалярное значение
                point2.Print();//Вывод координат
                Console.WriteLine($"Расстояние от точки до начала координат: {point2.Distance()}");
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
