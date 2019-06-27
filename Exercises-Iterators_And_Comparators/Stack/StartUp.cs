using System;
using System.Linq;

namespace Stack                 // 100 / 100
{
   public  class StartUp
    {
        static void Main()
        {
            string commandLine = String.Empty;

            CustomStack<string> customStack = new CustomStack<string>();

            while ((commandLine = Console.ReadLine()) != "END")
            {
                string[] commands = commandLine
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "Push")
                {
                    string[] elements = commands
                        .Skip(1)
                        .ToArray();

                    for (int i = 0; i < elements.Length; i++)
                    {
                        customStack.Push(elements[i]);
                    }
                }

                else if (commands[0] == "Pop" )
                {
                    if (customStack.Count() == 0)
                    {
                        Console.WriteLine("No elements");
                    }

                    else
                    {
                        customStack.Pop();
                    }
                }
            }

            foreach (var item in customStack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in customStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
