namespace Sets_Of_Elements              // 100 / 100
{
    using System;
    using System.Collections.Generic;
    using System.Linq;



    public class StartUp
    {
        public static void Main()
        {
            int[] sizes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            HashSet<int> firstNumbers = new HashSet<int>();
            HashSet<int> secondNumbers = new HashSet<int>();

            for (int i = 0; i < sizes[0]; i++)
            {
                firstNumbers.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < sizes[1]; i++)
            {
                secondNumbers.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var num in firstNumbers)
            {
                if (secondNumbers.Contains(num))
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
