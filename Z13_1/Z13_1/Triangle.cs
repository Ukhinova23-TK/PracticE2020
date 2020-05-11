using System;

namespace Z13_1
{
    class Triangle : Figure
    {
        private int a_, b_, c_;

        public int A { get { return a_; } set { a_ = value; } }
        public int B { get { return b_; } set { b_ = value; } }
        public int C { get { return c_; } set { c_ = value; } }

        public Triangle()
        {
            A = B = C = 0;
        }

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double Perimeter()
        {
            if(A + B > C && A + C > B && B + C > A)
            {
                return A + B + C;
            }
            else
            {
                return 0;
            }
        }

        public override double Square()
        {
            if (A + B > C && A + C > B && B + C > A)
            {
                double p = this.Perimeter() / 2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
            else
            {
                return 0;
            }
        }

        public override void Show()
        {
            if(this.Perimeter()!=0 && this.Square() != 0)
            {
                Console.WriteLine($"Треугольник со сторонами {A}, {B}, {C}");
                base.Show();
            }
            else
            {
                Console.WriteLine($"Треугольник со сторонами {A}, {B}, {C} не существует\n");
            }
        }
    }
}
