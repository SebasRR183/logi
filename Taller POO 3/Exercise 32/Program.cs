using System;

namespace Exercise32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño del rombo: ");
            int n = int.Parse(Console.ReadLine());

            int mitad = n / 2;

            for (int i = 0; i < n; i++)
            {
                int espacios = Math.Abs(mitad - i);

                Console.Write(new string(' ', espacios));
                Console.Write("*");

                if (espacios < mitad)
                {
                    int interior = n - 2 * espacios - 2;
                    if (interior >= 0)
                    {
                        Console.Write(new string(' ', interior));
                        Console.Write("*");
                    }
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}