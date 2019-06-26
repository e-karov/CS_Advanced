using System;
using System.Collections.Generic;

namespace Club_Party                                    // 100 / 100
{
     public class StartUp
    {
        public static void Main()
        {
            int hallsCapacity = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();

            Stack<string> elements = new Stack<string>(input);
            Queue<string> halls = new Queue<string>();
            List<int> reservationsDone = new List<int>();
            int currentCapacity = hallsCapacity;

            while (elements.Count > 0)
            {
                string currentElement = elements.Pop();
                bool IsNumber = Int32.TryParse(currentElement, out int currentReservation);

                if (! IsNumber)
                {
                    halls.Enqueue(currentElement);
                }

                if(IsNumber)
                {
                    if (halls.Count == 0)
                    {
                        continue;
                    }

                    if (currentCapacity - currentReservation < 0)
                    {
                        Console.WriteLine($"{halls.Dequeue()} -> {String.Join(", ", reservationsDone)}");

                        reservationsDone.Clear();
                        currentCapacity = hallsCapacity;
                    }


                    if (halls.Count > 0)
                    {
                        currentCapacity -= currentReservation;
                        reservationsDone.Add(currentReservation);

                    }
                }
            }
           
        } 
    }
}
