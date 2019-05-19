using System;
using System.Collections.Generic;
using System.Linq;

namespace Hot_Potato                    // 100 / 100
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            Queue<string> kids = new Queue<string>(input);
            int counter = 0;

            while (kids.Count > 1)
            {
                counter++;

                if (counter == n)
                {
                    Console.WriteLine($"Removed {kids.Dequeue()}");
                    counter = 0;
                }

                else
                {
                    string currentKid = kids.Dequeue();
                    kids.Enqueue(currentKid);

                }
            }

            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}
