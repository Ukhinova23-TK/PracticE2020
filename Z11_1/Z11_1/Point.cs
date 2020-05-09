using System;

namespace Z11_1
{
    class Point
    {
        private int _x, _y;
        //Свойста
        public int X { get { return _x; } set { _x = value; } }
        public int Y { get { return _y; } set { _y = value; } }
        public int ScalX { set { X *= value; } }
        public int ScalY { set { Y *= value; } }
        //Конструкторы
        public Point()
        {
            X = Y = 0;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        //Методы
        public void Print()
        {
            Console.WriteLine($"X: {X} Y: {Y}");
        }
        public double Distance()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public void Moving(int a, int b)
        {
            X += a;
            Y += b;
        }
    }
}
