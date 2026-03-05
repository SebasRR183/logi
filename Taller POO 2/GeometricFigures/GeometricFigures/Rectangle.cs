namespace GeometricFigures
{
    public class Rectangle : Figure
    {
        private double a;
        private double b;

        public Rectangle(string name, double a, double b) : base(name)
        {
            this.a = a;
            this.b = b;
        }

        public override double Area()
        {
            return a * b;
        }

        public override double Perimeter()
        {
            return 2 * (a + b);
        }
    }
}
