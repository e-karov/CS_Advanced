using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator                     // 100 / 100
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Stack<string> stack = new Stack<string>(input.Reverse());

            while (stack.Count > 1)
            {
                int operand1 = int.Parse(stack.Pop());
                string opr = stack.Pop();
                int operand2 = int.Parse(stack.Pop());

                switch (opr)
                {
                    case "+":
                        stack.Push((operand1 + operand2).ToString());
                        break;

                    case "-":
                        stack.Push((operand1 - operand2).ToString());
                        break;
                    
                }

            }
            Console.WriteLine(stack.Pop()); 
        }
    }
}
