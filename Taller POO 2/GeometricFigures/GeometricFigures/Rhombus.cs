namespace GeometricFigures
{
    public class Rhombus : Figure
    {
        private double a;
        private double d1;
        private double d2;

        public Rhombus(string name, double a, double d1, double d2) : base(name)
        {
            this.a = a;
            this.d1 = d1;
            this.d2 = d2;
        }

        public override double Area()
        {
            return (d1 * d2) / 2;
        }

        public override double Perimeter()
        {
            return 4 * a;
        }
    }
}
