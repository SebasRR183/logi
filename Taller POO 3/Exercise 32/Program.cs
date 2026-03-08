using System;

namespace Exercise32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño del rombo: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");

                Console.Write("#");

                if (i > 1)
                {
                    for (int j = 1; j <= 2 * (i - 1) - 1; j++)
                        Console.Write(" ");

                    Console.Write("#");
                }

                Console.WriteLine();
            }

            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");

                Console.Write("#");

                if (i > 1)
                {
                    for (int j = 1; j <= 2 * (i - 1) - 1; j++)
                        Console.Write(" ");

                    Console.Write("#");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}