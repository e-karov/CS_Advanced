using System;
using System.Linq;


namespace Jagged_Array_Modidfication                // 100 / 100
{
    class Program
    {
        static void Main()
        {
            int arrayRows = int.Parse(Console.ReadLine());

            int[][] jaggedArr = new int[arrayRows][];

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                int[] column = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArr[i] = column;
            }

            string commandLine = string.Empty;

            while ((commandLine = Console.ReadLine()) != "END")
            {
                string[] operations = commandLine.Split().ToArray();
                string command = operations[0];
                int row = int.Parse(operations[1]);
                int col = int.Parse(operations[2]);
                int value = int.Parse(operations[3]);

                if (row >= 0 && row < jaggedArr.Length && col >= 0 && col < jaggedArr[row].Length)
                {
                    switch (command.ToLower())
                    {
                        case "add":
                            jaggedArr[row][col] += value;

                            break;

                        case "subtract":
                            jaggedArr[row][col] -= value;
                            break;
                    }
                }

                else
                {
                    Console.WriteLine("Invalid coordinates");
                }

            }

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                Console.WriteLine(string.Join(" ", jaggedArr[i]));
            }
        }
    }
}
