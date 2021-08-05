using System;

namespace TestLibrary
{
    public class Triangle : IFigure
    {
        public Triangle(double a, double b, double c)
        {
            if (a<=0)
                throw new ArgumentException("Неверное значение", nameof(a));
            if (b <= 0)
                throw new ArgumentException("Неверное значение", nameof(b));
            if (c <= 0)
                throw new ArgumentException("Неверное значение", nameof(c));
            A = a;
            B = b;
            C = c;
        }
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public double Area()
        {
            double p = (A + B + C) / 2d;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return area;
        }
        public bool IsRectangular()
        {
            bool triangle;

            if ((A * A + B * B == C * C) || (A * A + C * C == B * B) || (C * C + B * B == A * A))
                triangle = true;

            else
                triangle = false;

            return triangle;
        }

    }
}
