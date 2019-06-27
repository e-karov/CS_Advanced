using System;
using System.Linq;

namespace Froggy                    // 100 / 100
{
    public class Program
    {
        static void Main()
        {
            int[] stones = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Lake lake = new Lake(stones);

            Console.WriteLine(String.Join(", ", lake));
        }
    }
}
