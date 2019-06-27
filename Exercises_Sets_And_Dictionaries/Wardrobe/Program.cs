namespace Wardrobe                      // 100 / 100
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> colors = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];

                string[] clothes = input[1]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (! colors.ContainsKey(color))
                {
                    colors.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j  < clothes.Length; j ++)
                {
                     if (!colors[color].ContainsKey(clothes[j]))
                    {
                        colors[color].Add(clothes[j], 1);
                    }

                    else
                    {
                        colors[color][clothes[j]]++;
                    }
                }
            }

            string[] searchedCloth = Console.ReadLine()
                .Split();

            foreach (var color in colors)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var item in color.Value)
                {
                    if (color.Key == searchedCloth[0] && item.Key == searchedCloth[1])
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }

                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
