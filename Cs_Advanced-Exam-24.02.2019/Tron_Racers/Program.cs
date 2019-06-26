using System;
using System.Collections.Generic;
using System.Linq;

namespace Tron_Racers                       // 100 / 100
{
    public class Program
    {
        static char[,] field;
        
        static int size = int.Parse(Console.ReadLine());

        public static void Main()
        {
            field = new char[size, size];
            int firstPlayerRow = 0;
            int firstPlayerCol = 0;
            int secondPlayerRow = 0;
            int secondPlayerCol = 0;

            for (int row = 0; row < size; row++)
            {
                char[] rowElements = Console.ReadLine().ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    field[row, col] = rowElements[col];

                    if (field[row, col] == 'f')
                    {
                        firstPlayerRow = row;
                        firstPlayerCol = col;
                    }

                    else if (field[row, col] == 's')
                    {
                        secondPlayerRow = row;
                        secondPlayerCol = col;
                    }
                }
            }

            bool IsOnePlayerLeft = false;

            while (IsOnePlayerLeft == false)
            {
                string[] commands = Console.ReadLine().Split();
                string firstCommand = commands[0];
                string secondCommand = commands[1];

                if (firstCommand == "up")
                {
                    if (IsOutside(firstPlayerRow - 1))
                    {
                        firstPlayerRow = size - 1;
                    }

                    else
                    {
                        firstPlayerRow -= 1;
                    }

                    if (field[firstPlayerRow, firstPlayerCol] == 's')
                    {
                        IsOnePlayerLeft = true;
                        field[firstPlayerRow, firstPlayerCol] = 'x';
                        break;
                    }

                    else
                    {
                        field[firstPlayerRow, firstPlayerCol] = 'f';
                    }
                }

                if (firstCommand == "down")
                {
                    if (IsOutside(firstPlayerRow + 1))
                    {
                        firstPlayerRow = 0;
                    }

                    else
                    {
                        firstPlayerRow += 1;
                    }

                    if (field[firstPlayerRow, firstPlayerCol] == 's')
                    {
                        IsOnePlayerLeft = true;
                        field[firstPlayerRow, firstPlayerCol] = 'x';
                        break;
                    }

                    else
                    {
                        field[firstPlayerRow, firstPlayerCol] = 'f';
                    }
                }

                if (firstCommand == "left")
                {
                    if (IsOutside(firstPlayerCol - 1))
                    {
                        firstPlayerCol = size - 1;
                    }

                    else
                    {
                        firstPlayerCol -= 1;
                    }

                    if (field[firstPlayerRow, firstPlayerCol] == 's')
                    {
                        IsOnePlayerLeft = true;
                        field[firstPlayerRow, firstPlayerCol] = 'x';
                        break;
                    }

                    else
                    {
                        field[firstPlayerRow, firstPlayerCol] = 'f';
                    }
                }

                if (firstCommand == "right")
                {
                    if (IsOutside(firstPlayerCol + 1))
                    {
                        firstPlayerCol = 0;
                    }

                    else
                    {
                        firstPlayerCol += 1;
                    }

                    if (field[firstPlayerRow, firstPlayerCol] == 's')
                    {
                        IsOnePlayerLeft = true;
                        field[firstPlayerRow, firstPlayerCol] = 'x';
                        break;
                    }

                    else
                    {
                        field[firstPlayerRow, firstPlayerCol] = 'f';
                    }
                }


                if (secondCommand == "up")
                {
                    if (IsOutside(secondPlayerRow - 1))
                    {
                        secondPlayerRow = size - 1;
                    }

                    else
                    {
                        secondPlayerRow -= 1;
                    }

                    if (field[secondPlayerRow, secondPlayerCol] == 'f')
                    {
                        IsOnePlayerLeft = true;
                        field[secondPlayerRow, secondPlayerCol] = 'x';
                        break;
                    }

                    else
                    {
                        field[secondPlayerRow, secondPlayerCol] = 's';
                    }
                }

                if (secondCommand == "down")
                {
                    if (IsOutside(secondPlayerRow + 1))
                    {
                        secondPlayerRow = 0;
                    }

                    else
                    {
                        secondPlayerRow += 1;
                    }

                    if (field[secondPlayerRow, secondPlayerCol] == 'f')
                    {
                        IsOnePlayerLeft = true;
                        field[secondPlayerRow, secondPlayerCol] = 'x';
                        break;
                    }

                    else
                    {
                        field[secondPlayerRow, secondPlayerCol] = 's';
                    }
                }

                if (secondCommand == "left")
                {
                    if (IsOutside(secondPlayerCol - 1))
                    {
                        secondPlayerCol = size - 1;
                    }

                    else
                    {
                        secondPlayerCol -= 1;
                    }

                    if (field[secondPlayerRow, secondPlayerCol] == 'f')
                    {
                        IsOnePlayerLeft = true;
                        field[secondPlayerRow, secondPlayerCol] = 'x';
                        break;
                    }

                    else
                    {
                        field[secondPlayerRow, secondPlayerCol] = 's';
                    }
                }

                if (secondCommand == "right")
                {
                    if (IsOutside(secondPlayerCol + 1))
                    {
                        secondPlayerCol = 0;
                    }

                    else
                    {
                        secondPlayerCol += 1;
                    }

                    if (field[secondPlayerRow, secondPlayerCol] == 'f')
                    {
                        IsOnePlayerLeft = true;
                        field[secondPlayerRow, secondPlayerCol] = 'x';
                        break;
                    }

                    else
                    {
                        field[secondPlayerRow, secondPlayerCol] = 's';
                    }
                }

            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }

        }

       

        public static bool IsOutside(int newPosition)
        {
            if (newPosition < 0 || newPosition >= size)
            {
                return true;
            }

            return false;
        }
    }
}
