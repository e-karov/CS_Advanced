using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Miner                     // 100 / 100
{
    public class StartUp
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split();

            string[,] field = new string[size, size];
            int currentRow = 0;
            int currentCol = 0;
            int totalCoals = 0;

            for (int row = 0; row < size; row++)
            {
                string [] rowArray = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < size; col++)
                {
                    field[row, col] = rowArray[col];

                    if (field[row, col] == "s")
                    {
                        currentRow = row;
                        currentCol = col;
                    }

                    if (field[row, col] == "c")
                    {
                        totalCoals ++ ;
                    }
                }
            }

            int collectedCoals = 0;
          
            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == "up") 
                {
                    if (currentRow - 1 < 0)
                    {
                        continue;
                    }

                    currentRow -= 1;
                }

                else if (commands[i] == "down")
                {
                    if (currentRow + 1 >= size)
                    {
                        continue;
                    }

                    currentRow += 1;
                }

                else if (commands[i] == "left")
                {
                    if (currentCol - 1 < 0)
                    {
                        continue;
                    }

                    currentCol -= 1;
                }

                else if (commands[i] == "right")
                {
                    if (currentCol + 1 >= size)
                    {
                        continue;
                    }

                    currentCol += 1;
                }

                if (field[currentRow, currentCol] == "c")
                {
                    collectedCoals++;
                    field[currentRow, currentCol] = "*";

                    if (collectedCoals == totalCoals)
                    {
                        Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");

                        return;
                    }
                }

                else if (field[currentRow, currentCol] == "e")
                {
                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");

                    return;
                }
            }

            int coalsLeft = totalCoals - collectedCoals;

            Console.WriteLine($"{coalsLeft} coals left. ({currentRow}, {currentCol})");
        }
    }
}
