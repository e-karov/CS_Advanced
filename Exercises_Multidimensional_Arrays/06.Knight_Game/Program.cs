namespace _06.Knight_Game                           // 100 / 100
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char[,] board = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] column = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    board[row, col] = column[col];
                }
            }

            int[] moves = new int[]
               {
                    1,  2,
                    1, -2,
                   -1,  2,
                   -1, -2,
                    2,  1,
                    2, -1,
                   -2,  1,
                   -2, -1
               };

            int counter = 0;

            while (true)
            {
                int maxKnights = 0;
                int knightRow = 0;
                int knightCol = 0;

                for (int row = 0; row < n; row++)
                {
                    
                    for (int col = 0; col < n; col++)
                    {
                        int currentKnights = 0;

                        if (board[row, col] == 'K')
                        {
                            for (int i = 0; i < moves.Length; i += 2)
                            {
                                if (IsInside(board, row + moves[i], col + moves[i + 1])
                                    && board[row + moves[i], col + moves[i + 1]] == 'K')
                                {
                                    currentKnights++;
                                }
                            }
                        }
                        if (currentKnights > maxKnights)
                        {
                            maxKnights = currentKnights;
                            knightRow = row;
                            knightCol = col;
                        }
                    }

                }
                if (maxKnights == 0)
                {
                    break;
                }

                board[knightRow, knightCol] = '0';
                counter++;
            }

            Console.WriteLine(counter);
        }


        private static bool IsInside (char[,] board, int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < board.GetLength(0)
                && targetCol >= 0 && targetCol < board.GetLength(1);
        }
    }
}
