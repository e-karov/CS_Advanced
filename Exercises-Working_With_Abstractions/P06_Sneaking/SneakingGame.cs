namespace P06_Sneaking
{
    using System;


    public class SneakingGame
    {
        public void StartGame()
        {
            int n = int.Parse(Console.ReadLine());
            char[][] room = new char[n][];

            int[] samPosition = GetPLayersPosition(room);

            var directions = Console.ReadLine().ToCharArray();

            for (int i = 0; i < directions.Length; i++)
            {
                int[] enemyPosition = new int[2];

                MoveEnemies(room);

                CheckIfSamGotKilled(room, samPosition, enemyPosition);

                MoveSam(samPosition, room, directions[i]);

                CheckIfNikoladzeGotKilled(room, samPosition, enemyPosition);
            }
        }

        private static int[] GetPLayersPosition(char[][] room)
        {
            int[] samPosition = new int[2];

            for (int row = 0; row < room.Length; row++)
            {
                var input = Console.ReadLine().ToCharArray();
                room[row] = new char[input.Length];

                for (int col = 0; col < input.Length; col++)
                {
                    room[row][col] = input[col];

                    if (room[row][col] == 'S')
                    {
                        samPosition[0] = row;
                        samPosition[1] = col;
                    }
                }
            }

            return samPosition;
        }

        private static void CheckIfSamGotKilled(char[][] room, int[] samPosition, int[] enemyPosition)
        {
            for (int j = 0; j < room[samPosition[0]].Length; j++)
            {
                if (room[samPosition[0]][j] != '.' && room[samPosition[0]][j] != 'S')
                {
                    enemyPosition[0] = samPosition[0];
                    enemyPosition[1] = j;
                }
            }

            if (samPosition[1] < enemyPosition[1]
                && room[enemyPosition[0]][enemyPosition[1]] == 'd'
                && enemyPosition[0] == samPosition[0])
            {
                room[samPosition[0]][samPosition[1]] = 'X';

                Console.WriteLine($"Sam died at {samPosition[0]}, {samPosition[1]}");

                PrintFinalState(room);
            }

            else if (enemyPosition[1] < samPosition[1]
                    && room[enemyPosition[0]][enemyPosition[1]] == 'b'
                    && enemyPosition[0] == samPosition[0])
            {
                room[samPosition[0]][samPosition[1]] = 'X';

                Console.WriteLine($"Sam died at {samPosition[0]}, {samPosition[1]}");

                PrintFinalState(room);
            }
        }

        private static void CheckIfNikoladzeGotKilled(char[][] room, int[] samPosition, int[] enemyPosition)
        {
            for (int j = 0; j < room[samPosition[0]].Length; j++)
            {
                if (room[samPosition[0]][j] != '.'
                    && room[samPosition[0]][j] != 'S')
                {
                    enemyPosition[0] = samPosition[0];
                    enemyPosition[1] = j;
                }
            }

            if (room[enemyPosition[0]][enemyPosition[1]] == 'N'
                && samPosition[0] == enemyPosition[0])
            {
                room[enemyPosition[0]][enemyPosition[1]] = 'X';

                Console.WriteLine("Nikoladze killed!");

                PrintFinalState(room);
            }
        }

        private static void MoveEnemies(char[][] room)
        {
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    if (room[row][col] == 'b')
                    {
                        if (row >= 0 && row < room.Length && col + 1 >= 0 && col + 1 < room[row].Length)
                        {
                            room[row][col] = '.';
                            room[row][col + 1] = 'b';
                            col++;
                        }
                        else
                        {
                            room[row][col] = 'd';
                        }
                    }
                    else if (room[row][col] == 'd')
                    {
                        if (row >= 0 && row < room.Length && col - 1 >= 0 && col - 1 < room[row].Length)
                        {
                            room[row][col] = '.';
                            room[row][col - 1] = 'd';
                        }
                        else
                        {
                            room[row][col] = 'b';
                        }
                    }
                }
            }
        }

        private static void PrintFinalState(char[][] room)
        {
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    Console.Write(room[row][col]);
                }
                Console.WriteLine();
            }
            Environment.Exit(0);
        }

        private static void MoveSam(int[] samPosition, char[][] room, char direction)
        {
            room[samPosition[0]][samPosition[1]] = '.';

            switch (direction)
            {
                case 'U':
                    samPosition[0]--;
                    break;
                case 'D':
                    samPosition[0]++;
                    break;
                case 'L':
                    samPosition[1]--;
                    break;
                case 'R':
                    samPosition[1]++;
                    break;
                default:
                    break;
            }

            room[samPosition[0]][samPosition[1]] = 'S';
        }
    }
}
