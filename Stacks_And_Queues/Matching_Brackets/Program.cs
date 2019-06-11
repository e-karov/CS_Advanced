using System;
using System.Collections;
using System.Collections.Generic;

namespace Matching_Brackets             // 100 / 100
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (ch == '(')
                {
                    stack.Push(i);
                }

                else if (ch == ')')
                {
                    int startIndex = stack.Pop();
                    string expression = input.Substring(startIndex, i + 1 - startIndex);
                    Console.WriteLine(expression);
                }

                
            }
        }
    }
}
