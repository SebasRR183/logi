using System;

namespace GeometricFigures
{
    public class Circle : Figure
    {
        private double r;

        public Circle(string name, double r) : base(name)
        {
            this.r = r;
        }

        public override double Area()
        {
            return Math.PI * r * r;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * r;
        }
    }
}