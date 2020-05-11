using System;

namespace Z13_1
{
    abstract class Figure
    {
        public abstract double Square();

        public abstract double Perimeter();

        public virtual void Show()
        {
            Console.WriteLine($"Площадь: {Square()}\n" +
                $"Пеример: {Perimeter()}\n");
        }
    }
}
