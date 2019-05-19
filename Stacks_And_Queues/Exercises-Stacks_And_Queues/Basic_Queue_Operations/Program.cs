using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations                    // 100 / 100 
{
    class Program
    {
        static void Main()
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int enqueueElements = commands[0];
            int dequeueElements = commands[1];
            int checkElement = commands[2];

            Queue<int> elements = new Queue<int>();

            for (int i = 0; i < enqueueElements; i++)
            {
                elements.Enqueue(array[i]);
            }

            for (int i = 0; i < dequeueElements; i++)
            {
                if (elements.Count > 0 )
                {
                    elements.Dequeue();
                }
            }

            if (elements.Contains(checkElement))
            {
                Console.WriteLine("true");
            }

            else if(elements.Count == 0)
            {
                Console.WriteLine(0);
            }

            else
            {
                Console.WriteLine(elements.Min());
            }
        }
    }
}
