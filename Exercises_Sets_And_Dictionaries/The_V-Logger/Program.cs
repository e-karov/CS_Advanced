namespace The_V_Logger                  // 100 / 100
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class    StartUp
    {
        public static void Main()
        {
            var vloggersCollection = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string[] input = Console.ReadLine().Split().ToArray();

            while (input[0] != "Statistics")
            {
                if (input.Contains("joined"))
                {
                    string vloggerName = input[0];

                    if ( ! vloggersCollection.ContainsKey(vloggerName))
                    {
                        vloggersCollection.Add(vloggerName, new Dictionary<string, HashSet<string>>());
                        vloggersCollection[vloggerName].Add("followers", new HashSet<string>());
                        vloggersCollection[vloggerName].Add("followed", new HashSet<string>());
                    }

                }

                else if (input.Contains("followed"))
                {

                    string follower = input[0];
                    string followedVlogger = input[2];

                    if ( ! vloggersCollection.ContainsKey(followedVlogger) 
                        || !vloggersCollection.ContainsKey(follower)
                        || follower == followedVlogger)
                    {
                        input = Console.ReadLine().Split().ToArray();
                        continue;
                    }

                    vloggersCollection[followedVlogger]["followers"].Add(follower);
                    vloggersCollection[follower]["followed"].Add(followedVlogger);
                }

                input = Console.ReadLine().Split().ToArray();
            }

            int totalVloggers = vloggersCollection.Select(x => x.Key).Count();

            Console.WriteLine($"The V-Logger has a total of {totalVloggers} vloggers in its logs.");

            int count = 1;

            var sortedCollection = vloggersCollection
                .OrderByDescending(x => x.Value["followers"].Count)
                .ThenBy(x => x.Value["followed"].Count)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var (vlogger, value) in sortedCollection)
            {
                Console.WriteLine($"{count}. {vlogger} : {value["followers"].Count()} followers, {value["followed"].Count()} following");

                if (count == 1)
                {
                    List<string> followers = value["followers"].OrderBy(n => n).ToList();

                    foreach (var user in followers)
                    {
                        Console.WriteLine($"*  {user}");
                    }
                }

                count++;
            }
        }
    }
}
