namespace _02._2x2_Squares_In_Matrix                // 100 / 100
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[sizes[0], sizes[1]];

            for (int i = 0; i < sizes[0]; i++)
            {
                char[] col = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int j = 0; j < sizes[1]; j++)
                {
                    matrix[i, j] = col[j];
                }
            }

            int squaresCount = 0;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i,j] == matrix[i, j+1] 
                        && matrix[i, j] == matrix[i+1, j] 
                        && matrix[i, j] == matrix[i+1, j+1])
                    {
                        squaresCount++;
                    }
                }
            }

            Console.WriteLine(squaresCount);
        }
    }
}
