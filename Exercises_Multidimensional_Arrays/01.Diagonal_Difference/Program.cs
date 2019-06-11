namespace _01.Diagonal_Difference                   // 100 / 100
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] col = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = col[j];
                }
            }

            int primDiagonalSum = 0;
            int secondDiagonalSum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        primDiagonalSum += matrix[i, j];
                    }

                    if (i + j == matrix.GetLength(0) -1)
                    {
                        secondDiagonalSum += matrix[i, j];
                    }
                }
            }
            
            Console.WriteLine(Math.Abs(primDiagonalSum - secondDiagonalSum));
        }
    }
}
