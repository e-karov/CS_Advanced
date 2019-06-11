namespace _05.Snake_Moves                       // 100 / 100
{
    using System;
    using System.Linq;


    public class StartUp
    {
        public static void Main()
        {
            int[] dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[dimensions[0], dimensions[1]];

            string snake = Console.ReadLine();
            int index = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (index >= snake.Length)
                    {
                        index = 0;
                    }

                    matrix[i, j] = snake[index++];
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
