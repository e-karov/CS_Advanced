namespace Symbol_In_Matrix              // 100 / 100
{
    using System;
    using System.Linq;


    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            char[,] matrix = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                char[] colElements = Console.ReadLine().ToCharArray();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = colElements[j];

                }
            }

            char symbol = char.Parse(Console.ReadLine());
            bool isFound = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (symbol == matrix[i, j])
                    {
                        isFound = true;
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }

            if (! isFound)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }

        }
    }
}
