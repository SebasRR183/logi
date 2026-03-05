namespace GeometricFigures
{
    public class Square : Figure
    {
        private double a;

        public Square(string name, double a) : base(name)
        {
            this.a = a;
        }

        public override double Area()
        {
            return a * a;
        }

        public override double Perimeter()
        {
            return 4 * a;
        }
    }
}
