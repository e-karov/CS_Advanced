using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element                   // 100 / 100
{
    class Program
    {
        static void Main()
        {
            int queriesCount = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < queriesCount; i++)
            {
                int[] query = Console.ReadLine().Split().Select(int.Parse).ToArray();

                switch (query[0])
                {
                    case 1:
                        int number = query[1];

                        stack.Push(number);
                        break;

                    case 2:
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                        break;

                    case 3:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;

                    case 4:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }

            int count = stack.Count;
            for (int i = 0; i < count-1; i++)
            {
                Console.Write($"{stack.Pop()}, ");
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
