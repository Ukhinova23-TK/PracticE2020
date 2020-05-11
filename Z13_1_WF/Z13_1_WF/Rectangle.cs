using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z13_1_WF
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

        public override string Show()
        {
            return $"Прямоугольник со сторонами {A} и {B}\n" + base.Show();
        }
    }
}
