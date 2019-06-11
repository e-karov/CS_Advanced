using System;
using System.Collections.Generic;
using System.Linq;


namespace _04.Find_Evens_Or_Odds                // 100 / 100
{
    public class StartUp
    {
        public static void Main()
        {
            int[] bounds = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int start = bounds[0];
            int end = bounds[1];

            List<int> numbers = new List<int>();

            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> evenNumbers = number => number % 2 == 0;
            Predicate<int> oddNumbers = number => number % 2 != 0;
            Action<List<int>> printNumbers = outputNumbers => Console.WriteLine(String.Join(" ", outputNumbers));
            string numType = Console.ReadLine();

            if (numType == "even")
            {
                numbers = numbers
                    .Where(n => evenNumbers(n))
                    .ToList();
            }

            else
            {
                numbers = numbers
                    .Where(n => oddNumbers(n))
                    .ToList();
            }

            printNumbers(numbers);
        }
    }
}
