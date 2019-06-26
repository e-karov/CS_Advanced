using System;
using System.Linq;

namespace Space_Station_Establishment               // 100 / 100
{
    public class StartUp
    {

        static int shipsRow;
        static int shipsCol;
        static int starPower;

        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            char[,] galaxy = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    galaxy[row, col] = currentRow[col];

                    if (galaxy[row, col] == 'S')
                    {
                        shipsRow = row;
                        shipsCol = col;
                    }
                }
            }

            bool isPowerEnough = false;

            while (starPower < 50
                || shipsRow > 0 && shipsRow < size
                || shipsCol > 0 && shipsCol < size)
            {
                string direction = Console.ReadLine().ToLower();

                if (IsShipLost(direction, galaxy))
                {
                    Console.WriteLine("Bad news, the spaceship went to the void.");
                    Console.WriteLine($"Star power collected: {starPower}");
                    break;
                }

                else
                {
                    if (Char.IsDigit(galaxy[shipsRow, shipsCol]))
                    {
                        int starSize = int.Parse(galaxy[shipsRow, shipsCol].ToString());
                        starPower += starSize;
                    }

                    else if (galaxy[shipsRow, shipsCol] == 'O')
                    {
                        for (int row = 0; row < galaxy.GetLength(0); row++)
                        {
                            for (int col = 0; col < galaxy.GetLength(1); col++)
                            {
                                if (galaxy[row, col] == 'O')
                                {
                                    galaxy[row, col] = '-';
                                    if (row != shipsRow && col != shipsCol)
                                    {
                                        shipsRow = row;
                                        shipsCol = col;
                                    }
                                }
                            }
                        }
                    }

                    galaxy[shipsRow, shipsCol] = 'S';
                }

                if (starPower >= 50)
                {
                    isPowerEnough = true;
                    break;
                }
            }

            if (isPowerEnough)
            {
                Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                Console.WriteLine($"Star power collected: {starPower}");
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(galaxy[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static bool IsShipLost(string direction, char[,] galaxy)
        {
            galaxy[shipsRow, shipsCol] = '-';
            bool isLost = false;

            switch (direction)
            {
                case "up":
                    shipsRow--;

                    if (shipsRow < 0)
                    {
                        isLost = true;

                    }
                    break;

                case "down":
                    shipsRow++;
                    if (shipsRow >= galaxy.GetLength(0))
                    {
                        isLost = true;
                    }
                    break;

                case "left":
                    shipsCol--;
                    if (shipsCol < 0)
                    {
                        isLost = true;
                    }
                    break;

                case "right":
                    shipsCol++;
                    if (shipsCol >= galaxy.GetLength(1))
                    {
                        isLost = true;
                    }
                    break;
            }
            return isLost;
        }
    }
}
