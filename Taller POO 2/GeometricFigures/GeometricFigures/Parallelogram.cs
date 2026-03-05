namespace GeometricFigures
{
    public class Parallelogram : Figure
    {
        private double a;
        private double b;
        private double h;

        public Parallelogram(string name, double a, double b, double h)
            : base(name)
        {
            this.a = a;
            this.b = b;
            this.h = h;
        }

        public override double Area()
        {
            return b * h;
        }

        public override double Perimeter()
        {
            return 2 * (a + b);
        }
    }
}
