using System;
using System.Linq;
using System.Collections.Generic;


namespace _05.Applied_Arithmetics                   // 100 / 100
{
    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Func<int, int> add = number => number + 1;
            Func<int, int> multiply = number => number * 2;
            Func<int, int> subtract = number => number - 1;
            Action<List<int>> print = outputNumbers => Console.WriteLine(String.Join(" ", outputNumbers));

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "end")
            {

                if (command == "add")
                {
                    numbers = numbers
                        .Select(add)
                        .ToList();
                }

                if (command == "multiply")
                {
                    numbers = numbers
                        .Select(multiply)
                        .ToList();
                }

                if (command == "subtract")
                {
                    numbers = numbers
                        .Select(subtract)
                        .ToList();
                }

                if (command == "print")
                {
                    print(numbers);
                }
            }

        }
    }
}
