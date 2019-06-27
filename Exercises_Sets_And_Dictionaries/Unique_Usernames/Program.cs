namespace Unique_Usernames                      // 100 / 100
{
    using System;
    using System.Collections.Generic;
    using System.Linq;



    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<String> names = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                names.Add(input);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
