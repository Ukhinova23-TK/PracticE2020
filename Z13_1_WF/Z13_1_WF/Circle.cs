using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z13_1_WF
{
    class Circle : Figure
    {
        private int r_;

        public int R { get { return r_; } set { r_ = value; } }

        public Circle()
        {
            R = 0;
        }

        public Circle(int r)
        {
            R = r;
        }

        public override double Square()
        {
            return Math.PI * R * R;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * R;
        }

        public override string Show()
        {
            return $"Круг радиусом {R}\n" + base.Show();
        }
    }
}
