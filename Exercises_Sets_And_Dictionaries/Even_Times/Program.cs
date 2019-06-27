namespace Even_Times                     // 100 / 100
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());

                if (numbers.ContainsKey(current))
                {
                    numbers[current] += 1 ;
                }

                else
                {
                    numbers.Add(current, 1);
                }
            }

            foreach (var num in numbers)
            {
                if (num.Value % 2 == 0)
                {
                    Console.WriteLine(num.Key);
                }
            }
        }
    }
}
