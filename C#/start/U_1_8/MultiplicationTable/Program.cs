using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMultiplicationTable(15, 15);
        }

        static void PrintMultiplicationTable(int width, int height)
        {
            int[,] table = new int[width, height];
            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= height; j++)
                    Console.Write($"{i * j}\t");
                Console.WriteLine();
            }
        }
    }
}
