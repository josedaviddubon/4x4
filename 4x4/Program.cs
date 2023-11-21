using System;

class Program
{
    static void Main()
    {

        int[,] matriz = {
            {17, 8, 36, 21},
            {8, 28, 3, 1},
            {15, 7, 5, 30},
            {10, 17, 4, 12}
        };

        int diagonales = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (i == j) 
                {
                    diagonales += matriz[i, j];
                }
            }
        }
        Console.WriteLine($"La suma es: {diagonales}");

        Console.ReadLine();
    }
}

