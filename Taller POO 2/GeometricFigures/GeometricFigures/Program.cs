using System;
using System.Collections.Generic;

namespace GeometricFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("Circle", 5);
            Square square = new Square("Square", 10);
            Rhombus rhombus = new Rhombus("Rhombus", 5, 7, 10);
            Kite kite = new Kite("Kite", 7, 8, 6, 5);
            Rectangle rectangle = new Rectangle("Rectangle", 4.568, 67.790);
            Parallelogram parallelogram = new Parallelogram("Parallelogram", 14.65, 54.67, 23.09);
            Triangle triangle = new Triangle("Triangle", 45.56, 12.34, 27.09, 15);
            Trapeze trapeze = new Trapeze("Trapeze", 10, 20, 30, 40, 20);

            List<Figure> figures = new List<Figure>()
            {
                circle, square, rhombus, kite,
                rectangle, parallelogram, triangle, trapeze
            };

            foreach (Figure figure in figures)
            {
                Console.WriteLine(figure);
            }

            Console.ReadLine();
        }
    }
}