using System;

namespace Z13_1
{
    class Rectangle : Figure
    {
        private int a_, b_;

        public int A { get { return a_; } set { a_ = value; } }
        public int B { get { return b_; } set { b_ = value; } }

        public Rectangle()
        {
            A = B = 0;
        }

        public Rectangle(int a, int b)
        {
            A = a;
            B = b;
        }

        public override double Square()
        {
            return A * B;
        }

        public override double Perimeter()
        {
            return (A + B) * 2;
        }

        public override void Show()
        {
            Console.WriteLine($"Прямоугольник со сторонами {A} и {B}");
            base.Show();
        }
    }
}
