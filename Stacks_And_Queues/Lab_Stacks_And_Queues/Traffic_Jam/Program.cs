using System;
using System.Collections.Generic;

namespace Traffic_Jam               // 100 / 100
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string infoLine = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int counter = 0;

            while (infoLine != "end")
            {
                if (infoLine == "green")
                {
                    
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            counter++;
                        }
                    }
                }

                else
                {
                    cars.Enqueue(infoLine);
                }

                infoLine = Console.ReadLine();
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
