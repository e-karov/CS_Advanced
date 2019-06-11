using System;
using System.Linq;


namespace _03.Custom_Min_Function                       // 100 / 100
{
    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> minNumber = number =>
            {
                int minValue = int.MaxValue;

                foreach (var num in number)
                {
                    if (num < minValue)
                    {
                        minValue = num;
                    }
                }

                return minValue;
            };

            Console.WriteLine(minNumber(numbers));
        }
    }
}
