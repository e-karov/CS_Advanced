
namespace _04.Matrix_Shuffling           // 100 / 100
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] column = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = column[col];
                }
            }

             string input = String.Empty;

            while ((input = Console.ReadLine()) != "END")
            {

                if (input == "END")
                {
                    return;
                }

                string[] commandLine = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (commandLine[0] == "swap" && commandLine.Length == 5)
                {
                    int row1 = int.Parse(commandLine[1]);
                    int col1 = int.Parse(commandLine[2]);
                    int row2 = int.Parse(commandLine[3]);
                    int col2 = int.Parse(commandLine[4]);

                    if (row1 < 0 || col1 < 0 || row2 < 0 || col2 < 0 
                        || row1 > matrix.GetLength(0) || col1 > matrix.GetLength(1)
                        || row2 > matrix.GetLength(0) || col2 > matrix.GetLength(1))
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    else
                    {
                        string temp = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = temp;

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write(matrix[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

            }
        }
    }
}
