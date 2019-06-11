using System;
using System.Linq;
using System.Collections.Generic;


namespace _06.Reverse_And_Exclude               // 100 / 100 
{
    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int divider = int.Parse(Console.ReadLine());

            Predicate<int> divisionCheck = number => number % divider != 0;

            Func<int[], int[]> filterReversedArr = array => array
            .Reverse()
            .Where(n => divisionCheck(n))
            .ToArray();

            numbers = filterReversedArr(numbers);

            Console.WriteLine(String.Join(" ", numbers));
          
        }
    }
}
