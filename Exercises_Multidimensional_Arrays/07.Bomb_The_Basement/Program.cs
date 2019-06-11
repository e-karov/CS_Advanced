namespace _07.Bomb_The_Basement                 // 100 / 100
{
    using System;
    using System.Linq;


    public class StartUp
    {
        public static void Main()
        {
            int[] sizes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[,] basement = new int[sizes[0], sizes[1]];

            int[] bomb = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int bombRow = bomb[0];
            int bombCol = bomb[1];
            int impact = bomb[2];

            for (int row = 0; row < basement.GetLength(0); row++)
            {
                for (int col = 0; col < basement.GetLength(1); col++)
                {
                    bool isInRadius = Math.Pow(row - bombRow, 2) + Math.Pow(col - bombCol, 2) <= Math.Pow(impact, 2);

                    if (isInRadius)
                    {
                        basement[row, col] = 1;
                    }
                }
            }

            for (int col = 0; col < basement.GetLength(1); col++)
            {
                int counter = 0;

                for (int row = 0; row < basement.GetLength(0); row++)
                {
                    if (basement[row, col] == 1)
                    {
                        counter++;
                        basement[row, col] = 0;
                    }
                }

                for (int row = 0; row < counter; row++)
                {
                    basement[row, col] = 1;
                }
            }

            for (int i = 0; i < basement.GetLength(0); i++)
            {
                for (int j = 0; j < basement.GetLength(1); j++)
                {
                    Console.Write(basement[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
