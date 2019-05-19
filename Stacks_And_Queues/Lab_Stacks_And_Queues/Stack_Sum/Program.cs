using System;
using System.Linq;
using System.Collections.Generic;


namespace Stack_Sum                 // 100 / 100
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);
            string commandLine = Console.ReadLine().ToLower();

            while (commandLine != "end")
            {
                string[] commandInfo = commandLine.Split();
                string command = commandInfo[0];

                switch (command)
                {
                    case "add":
                        int num1 = int.Parse(commandInfo[1]);
                        int num2 = int.Parse(commandInfo[2]);
                        stack.Push(num1);
                        stack.Push(num2);

                        break;

                    case "remove":
                        int count = int.Parse(commandInfo[1]);

                        if (stack.Count >= count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                stack.Pop();
                            }
                        }
                        break;
                }

                commandLine = Console.ReadLine().ToLower();
            }

            int sum = stack.Sum();
           
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
