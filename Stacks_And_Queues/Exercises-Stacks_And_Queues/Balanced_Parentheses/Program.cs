namespace Balanced_Parentheses              // 100 / 100
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            char[] input = Console.ReadLine()
                .ToCharArray();

            char[] openingParenthesis = new char[] { '(', '{', '[' };
            Stack<char> stack = new Stack<char>();
            bool isBalanced = true;

            if (openingParenthesis.Contains(input[0]) == false)
            {
                isBalanced = false;
            }

            foreach (var item in input)
            {
                if (openingParenthesis.Contains(item))
                {
                    stack.Push(item);
                    continue;
                }

                if (stack.Count > 0)
                {
                    if (item == ')' && stack.Pop() == '(')
                    {
                        continue;
                    }

                    else if (item == ']' && stack.Pop() == '[')
                    {
                        continue;
                    }

                    else if (item == '}' && stack.Pop() == '{')
                    {
                        continue;
                    }
                }

                isBalanced = false;
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }

            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
