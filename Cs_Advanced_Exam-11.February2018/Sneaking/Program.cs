using System;

namespace Sneaking
{
    public class StartUp
    {
        static int rowsCount;
        static int samsRow;
        static int samsCol;
        static int nikoladzeRow;
        static int nikoladzeCol;

        public static void Main()
        {
            rowsCount = int.Parse(Console.ReadLine());

            char[][] room = new char[rowsCount][];

            for (int row = 0; row < rowsCount; row++)
            {
                char[] inputRow = Console.ReadLine().ToCharArray();
                room[row] = new char[inputRow.Length];

                for (int col = 0; col < inputRow.Length; col++)
                {
                    room[row][col] = inputRow[col];

                    if (room[row][col] == 'S')
                    {
                        samsRow = row;
                        samsCol = col;
                    }

                    if (room[row][col] == 'N')
                    {
                        nikoladzeRow = row;
                        nikoladzeCol = col;
                    }
                }
            }

            char[] directions = Console.ReadLine().ToCharArray();

            bool isKilled = false;

            for (int i = 0; i < directions.Length; i++)
            {
                MoveEnemies(room);
                MoveSam(room, directions);

                char[] currentRow = room[samsRow];

                for (int c = 0; c < currentRow.Length; c++)
                {
                    if (currentRow[c] == 'b' && samsCol > c)
                    {
                        room[samsRow][samsCol] = 'X';
                        break;
                    }

                    else if (currentRow[c] == 'd' && samsCol < c)
                    {
                        room[samsRow][samsCol] = 'X';
                        break;
                    }
                }

                if (room[samsRow][samsCol] == 'b' || room[samsRow][samsCol] == 'd')
                {
                    room[samsRow][samsCol] = '.';
                }

                if (samsRow == nikoladzeRow)
                {
                    isKilled = true;
                    room[nikoladzeRow][nikoladzeCol] = 'X';
                    break;
                }
            }

            if (isKilled)
            {
                Console.WriteLine("Nikoladze killed!");
            }

            else
            {
                Console.WriteLine($"Sam died at {samsRow}, {samsCol}");
            }

            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    Console.Write(room[row][col]);
                }
                Console.WriteLine();
            }
        }

        private static void MoveSam(char[][] room, char[] directions)
        {
            foreach (var direction in directions)
            {
                room[samsRow][samsCol] = '.';

                if (direction == 'U')
                {
                    samsRow -= 1;
                }

                else if (direction == 'D')
                {
                    samsRow += 1;
                }

                else if (direction == 'L')
                {
                    samsCol -= 1;
                }

                else if (direction == 'R')

                {
                    samsCol += 1;
                }
                room[samsRow][samsCol] = 'S';
            }
        }

        private static void MoveEnemies(char[][] room)
        {
            for (int row = 0; row < room.Length; row++)
            {
                int indexB = Array.IndexOf(room[row], 'B');
                int indexD = Array.IndexOf(room[row], 'D');

                if (indexD != -1)
                {
                    if (indexB == 0)
                    {
                        room[row][0] = 'b';
                    }
                    else
                    {
                        room[row][indexD] = '.';
                        indexD--;
                        room[row][indexD] = 'd';
                    }
                    break;
                }

                if (indexB != -1)
                {
                    if (indexB == room[row].Length - 1)
                    {
                        room[row][indexB] = 'd';
                    }
                    else
                    {
                        room[row][indexB] = '.';
                        indexB++;
                        room[row][indexB] = 'b';
                    }

                }
            }
        }
    }
}
