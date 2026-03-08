namespace GeometricFigures
{
    public abstract class Figure
    {
        public string Name { get; set; }

        public Figure(string name)
        {+
            Name = name;
        }

        public abstract double Area();
        public abstract double Perimeter();

        public override string ToString()
        {
            return string.Format("{0,-15} => Area.....: {1,10:N5}    Perimiter: {2,10:N5}",
                Name, Area(), Perimeter());
        }
    }
}