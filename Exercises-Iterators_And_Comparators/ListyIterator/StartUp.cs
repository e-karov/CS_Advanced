using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries); ;
            List<string> elements = input.Skip(1).ToList();
            ListyIterator<string> items = new ListyIterator<string>(elements);

            string commandLine;
            while ((commandLine = Console.ReadLine()) != "END")
            {
                string[] commands = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    if (commands[0] == "HasNext")
                    {
                        Console.WriteLine(items.HasNext());
                    }

                    else if (commands[0] == "Move")
                    {
                        Console.WriteLine(items.Move());
                    }

                    else if (commands[0] == "Print")
                    {
                        items.Print();
                    }

                    else if (commands[0] == "PrintAll")
                    {
                        foreach (var item in items)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                    }
                }
                catch ( Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
