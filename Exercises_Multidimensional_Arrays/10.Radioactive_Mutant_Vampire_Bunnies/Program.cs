namespace _10.Radioactive_Mutant_Vampire_Bunnies
{
    using System;
    using System.Linq;


    public class StartUp
    {
        public static void Main()
        {
            int[] size = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rows = size[0];
            int cols = size[1];

            char[,] lair = new char [rows, cols];
            int currentRow = -1;
            int currentCol = -1;

            for (int row = 0; row < rows; row++)
            {
                char[] rowArray = Console.ReadLine().ToCharArray();

                for (int col = 0; col < cols; col++)
                {
                    lair[row, col] = rowArray[col];

                    if (lair[row, col] == 'P')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }

            char[] commands = Console.ReadLine().ToCharArray();

            foreach (var command in commands)
            {
                if (command == 'U')
                {
                    if (currentRow - 1 < 0)
                    {
                        Console.WriteLine($"won: {currentRow} {currentCol}");
                        return;
                    }
                }

                else if (command == 'D')
                {
                    if (currentRow + 1 >= rows)
                    {
                        Console.WriteLine($"won: {currentRow} {currentCol}");
                        return;
                    }
                }

                else if (command == 'L')
                {
                    if (currentCol - 1 < 0)
                    {
                        Console.WriteLine($"won: {currentRow} {currentCol}");
                        return;
                    }
                }

                else if (command == 'R')
                {
                    if (currentCol + 1 >= cols)
                    {
                        Console.WriteLine($"won: {currentRow} {currentCol}");
                        return; 
                    }
                }
            }
        }
    }
}
