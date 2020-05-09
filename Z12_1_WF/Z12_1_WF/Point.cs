using System;

namespace Z12_1_WF
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
        public string Print()
        {
            return $"{X}, {Y}";
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
        //Перегрузки
        public static Point operator --(Point p)
        {
            p.X -= 1;
            p.Y -= 1;
            return p;
        }
        public static Point operator ++(Point p)
        {
            p.X += 1;
            p.Y += 1;
            return p;
        }
        public static bool operator false(Point p)
        {
            if (p.X != p.Y)
                return false;
            return true;
        }
        public static bool operator true(Point p)
        {
            if (p.X == p.Y)
                return true;
            return false;
        }
        public static Point operator +(Point p, int scal)
        {
            p.X += scal;
            p.Y += scal;
            return p;
        }
        public static Point operator +(int scal, Point p)
        {
            p.X += scal;
            p.Y += scal;
            return p;
        }
        //Индексатор
        public int this[int i]
        {
            get
            {
                if (i == 0)
                    return X;
                if (i == 1) return Y;
                throw new Exception("Ошибка обращения по данному индексу");
            }
        }
        //Преобразование
        public static explicit operator String(Point p)
        {
            return $"{p.X}, {p.Y}";
        }
        public static explicit operator Point(string str)
        {
            string[] q = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Point p = new Point
            {
                X = Convert.ToInt32(q[0].Trim(new char[] { ',' })),
                Y = Convert.ToInt32(q[1].Trim(new char[] { ',' }))
            };
            return p;
        }
    }
}
