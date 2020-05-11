using System;

namespace Z13_1_WF
{
    abstract class Figure
    {
        public abstract double Square();

        public abstract double Perimeter();

        public virtual string Show()
        {
            return $"Площадь: {Square()}\n" +
                $"Пеример: {Perimeter()}\n";
        }
    }
}
