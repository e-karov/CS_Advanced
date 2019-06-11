using System;
using System.Linq;
using System.Collections.Generic;



namespace _11.Party_Reservation_Filter_Module                   // 100 / 100
{
    public class StartUp
    {
        public static void Main()
        {
            string[] guests = Console.ReadLine()
                .Split()
                .ToArray();

            List<string> filters = new List<string>();

            string filter = Console.ReadLine();

            while (filter != "Print")
            {
                string[] filterArr = filter.Split(";");
                string action = filterArr[0];

                if (action == "Add filter")
                {
                    filters.Add($"{filterArr[1]};{filterArr[2]}");
                }

                else if (action == "Remove filter")
                {
                    filters.Remove($"{filterArr[1]};{filterArr[2]}");
                }

                filter = Console.ReadLine();
            }

            Func<string, string, bool> startCheck = (name, str) => name.StartsWith(str);
            Func<string, string, bool> endCheck = (name, str) => name.EndsWith(str);
            Func<String, string, bool> containsCheck = (name, str) => name.Contains(str);
            Func<string, int, bool> lenCheck = (name, len) => name.Length == len;

            foreach (var currentFilter in filters)
            {
                string[] filterInfo = currentFilter.Split(";");

                string action = filterInfo[0];
                string param = filterInfo[1];

                switch (action)
                {
                    case "Starts with":
                        guests = guests
                            .Where(g => !startCheck(g, param))
                            .ToArray();
                        break;

                    case "Ends with":
                        guests = guests
                            .Where(g => !endCheck(g, param))
                            .ToArray();
                        break;

                    case "Contains":
                        guests = guests
                            .Where(g => !containsCheck(g, param))
                            .ToArray();
                        break;

                    case "Length":
                        guests = guests
                            .Where(g => !lenCheck(g, int.Parse(param)))
                            .ToArray();
                        break;
                }
            }

            Console.WriteLine(String.Join(" ", guests));
        }
    }
}
