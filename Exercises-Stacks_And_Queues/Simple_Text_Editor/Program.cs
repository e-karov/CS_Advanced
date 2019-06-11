namespace Simple_Text_Editor                // 100 / 100
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder builder = new StringBuilder();
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();
                string command = input[0];

                if (command ==  "1")
                {
                    string text = input[1];

                    stack.Push(builder.ToString());
                    builder.Append(text);
                }

                else if (command == "2")
                {
                    int count = int.Parse(input[1]);

                    stack.Push(builder.ToString());
                    builder = builder.Remove(builder.Length - count, count);
                }

                else if (command == "3")
                {
                    int index = int.Parse(input[1]) - 1;

                    Console.WriteLine(builder[index]);
                }

                else if (command == "4")
                {
                    if (stack.Count > 0)
                    {
                        builder.Clear();
                        builder.Append(stack.Pop());
                    }
                }
            }
        }
    }
}
