using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations                        // 100 / 100
{
    class Program
    {
        static void Main()
        {
            int[] commandArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int pushElements = commandArr[0];
            int popElements = commandArr[1];
            int checkElement = commandArr[2];

            Stack<int> elements = new Stack<int>();

            for (int i = 0; i < pushElements; i++)
            {
                elements.Push(numbers[i]);
            }

            for (int i = 0; i < popElements; i++)
            {
                elements.Pop();
            }

            if (elements.Contains(checkElement))
            {
                Console.WriteLine("true");
            }

            else if (elements.Count == 0)
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
