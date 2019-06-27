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

                    if (lair[currentRow - 1, currentCol] == 'B')
                    {
                        Console.WriteLine($"dead: {currentRow} {currentCol}");
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

                    if (lair[currentRow + 1, currentCol] == 'B')
                    {
                        Console.WriteLine($"dead: {currentRow} {currentCol}");
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

                    if (lair[currentRow, currentCol-1] == 'B')
                    {
                        Console.WriteLine($"dead: {currentRow} {currentCol}");
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

                    if (lair[currentRow, currentCol+1] == 'B')
                    {
                        Console.WriteLine($"dead: {currentRow} {currentCol}");
                        return;
                    }
                }

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (lair[i, j] == 'B')
                        {
                            if (i-1 > 0)
                            {
                                if (lair[i - 1, j] == 'P')
                                {
                                    Console.WriteLine($"dead: {currentRow} {currentCol}");
                                }
                                lair[i - 1, j] = 'B';
                                return;
                            }

                            if (i + 1 < rows)
                            {
                                if (lair[i+1, j] == 'P')
                                {
                                    Console.WriteLine($"dead: {currentRow} {currentCol}");
                                }
                                lair[i + 1, j] = 'B';
                                return;
                            }

                            if (j - 1 > 0)
                            {
                                if (lair[i, j - 1] == 'P')
                                {
                                    Console.WriteLine($"dead: {currentRow} {currentCol}");
                                }
                                lair[i, j - 1] = 'B';
                                return;
                            }

                            if (j + 1 < cols)
                            {
                                if (lair[i, j + 1] == 'P')
                                {
                                    Console.WriteLine($"dead: {currentRow} {currentCol}");
                                }
                                lair[i, j + 1] = 'B';
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}
