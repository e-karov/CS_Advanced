using System;
using System.Collections.Generic;
using System.Linq;


namespace _10.Predicate_Party                   // 100 / 100 
{
    public class StartUp
    {
        public static void Main()
        {
            List<string> guests = Console.ReadLine()
                .Split()
                .ToList();

            Func<string, string, bool> startCheck = (name, start) => name.StartsWith(start);
            Func<string, string, bool> endingCheck = (name, ending) => name.EndsWith(ending);
            Func<string, int, bool> lengthCheck = (name, len) => name.Length == len;

            Action<List<string>> printGuests = guestsList =>
           Console.WriteLine(guestsList.Count() > 0 ? String.Join(", ", guests) + " are going to the party!"
           : "Nobody is going to the party!");

            string[] commandString = Console.ReadLine().Split();

            while (commandString[0] != "Party!")
            {
                string command = commandString[0];
                string condition = commandString[1];
                string param = commandString[2];

                switch (condition)
                    {
                        case "StartsWith":

                        if (command == "Double")
                        {
                            for (int i = 0; i < guests.Count; i++)
                            {
                                if (startCheck(guests[i], param))
                                {
                                    guests.Insert(i, guests[i]);
                                    i++;
                                }
                            }
                        }

                        else if (command == "Remove")
                        {
                            guests = guests
                                .Where(guest => !startCheck(guest, param))
                                .ToList();
                        }
                        break;

                        case "EndsWith":
                        if (command == "Double")
                        {
                            for (int i = 0; i < guests.Count; i++)
                            {
                                if (endingCheck(guests[i], param))
                                {
                                    guests.Insert(i, guests[i]);
                                    i++;
                                }
                            }
                        }

                        else if (command == "Remove")
                        {
                            guests = guests
                                .Where(guest => !endingCheck(guest, param))
                                .ToList();
                        }
                        break;

                        case "Length":
                        if (command == "Double")
                        {
                            for (int i = 0; i < guests.Count; i++)
                            {
                                if (lengthCheck(guests[i], int.Parse(param)))
                                {
                                    guests.Insert(i, guests[i]);
                                    i++;
                                }
                            }
                        }
                       
                        else if (command == "Remove")
                        {
                            guests = guests
                                .Where(guest => !lengthCheck(guest, int.Parse(param)))
                                .ToList();
                        } 
                        break;
                    }
                
                commandString = Console.ReadLine().Split();
            }

            printGuests(guests);
        }
    }
}
