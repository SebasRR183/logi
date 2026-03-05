namespace GeometricFigures
{
    public class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;
        private double h;

        public Triangle(string name, double a, double b, double c, double h)
            : base(name)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.h = h;
        }

        public override double Area()
        {
            return (b * h) / 2;
        }

        public override double Perimeter()
        {
            return a + b + c;
        }
    }
}