using System;

namespace Exercise33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese m: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Ingrese n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Ingrese p: ");
            int p = int.Parse(Console.ReadLine());

            int[,] A = new int[m, n];
            int[,] B = new int[n, p];
            int[,] C = new int[m, p];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    A[i, j] = (i + 1) * j;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < p; j++)
                    B[i, j] = (j + 1) * i;

            for (int i = 0; i < m; i++)
                for (int j = 0; j < p; j++)
                    for (int k = 0; k < n; k++)
                        C[i, j] += A[i, k] * B[k, j];

            Console.WriteLine("\n*** A ***");
            Mostrar(A);

            Console.WriteLine("\n*** B ***");
            Mostrar(B);

            Console.WriteLine("\n*** C ***");
            Mostrar(C);

            Console.ReadKey();
        }

        static void Mostrar(int[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                    Console.Write(matriz[i, j] + " ");

                Console.WriteLine();
            }
        }
    }
}