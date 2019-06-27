namespace Count_Symbols                     // 100 / 100
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            char [] input = Console.ReadLine()
                .ToCharArray();

            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                Char curr = input[i];

                if (dict.ContainsKey(curr))
                {
                    dict[curr] += 1;
                }
                else
                {
                    dict.Add(curr, 1);
                }
            }

            foreach (var ch in dict)
            {
                Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
            }
        }
    }
}
