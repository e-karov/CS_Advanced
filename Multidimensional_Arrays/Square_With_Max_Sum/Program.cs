
namespace Square_With_Max_Sum               // 100 / 100
{
  using System;
    using System.Linq;

    public  class Program
    {
        public static void Main()
        {
            int[] sizes = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] column = Console.ReadLine()
                    .Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = column[j];
                }
            }
            int maxSquareSum = int.MinValue;
            int startRow = 0;
            int startCol = 0;

            for (int i = 0; i < matrix.GetLength(0) -1; i++)
            {
                
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int squareSum = matrix[i, j] + matrix[i, j + 1]
                        + matrix[i + 1, j] + matrix[i + 1, j + 1];

                    if (squareSum > maxSquareSum)
                    {
                        maxSquareSum = squareSum;
                        startRow = i;
                        startCol = j;
                    }
                }
            }

            Console.WriteLine($"{matrix[startRow, startCol]} {matrix[startRow, startCol +1]}\n" +
                $"{matrix[startRow + 1, startCol]} {matrix[startRow + 1, startCol + 1]}");

            Console.WriteLine(maxSquareSum);
        }
    }
}
