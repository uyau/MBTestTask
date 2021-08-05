using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class Circle : IFigure
    {
        public Circle(double x)
        {
            if (x <= 0)
                throw new ArgumentException("Неверное значение", nameof(x));
            Radius = x;
        }
        public double Radius { get; }

        public double Area()
        {
            double area = Math.PI * (Radius * Radius);
            return area;
        }

    }
}
