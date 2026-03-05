namespace GeometricFigures
{
    public class Trapeze : Figure
    {
        private double a;
        private double b;
        private double c;
        private double d;
        private double h;

        public Trapeze(string name, double a, double b, double c, double d, double h)
            : base(name)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.h = h;
        }

        public override double Area()
        {
            return (a + b) * h;
        }

        public override double Perimeter()
        {
            return a + b + c + d;
        }
    }
}