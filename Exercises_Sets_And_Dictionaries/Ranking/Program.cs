namespace Ranking                       // 100 / 100 
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StarUp
    {
        public  static void Main()
        {
            Dictionary<string, string> contestsPasswords = new Dictionary<string, string>();
            var usersSubmissions = new SortedDictionary<string, Dictionary<string, int>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] contestData = input.Split(":").ToArray();

                string contest = contestData[0];
                string pass = contestData[1];

                if ( ! contestsPasswords.ContainsKey(contest))
                {
                    contestsPasswords.Add(contest, pass);
                }
            }

            while ((input = Console.ReadLine())!= "end of submissions")
            {
                string[] submissionsData = input.Split("=>").ToArray();
                string contest = submissionsData[0];
                string pass = submissionsData[1];
                string userName = submissionsData[2];
                int points = int.Parse(submissionsData[3]);

                if (! contestsPasswords.ContainsKey(contest) 
                    || !contestsPasswords[contest].Equals(pass))
                {
                    continue;
                }

                if ( !usersSubmissions.ContainsKey(userName))
                {
                    usersSubmissions.Add(userName, new Dictionary<string, int>());
                }

                if (!usersSubmissions[userName].ContainsKey(contest))
                {
                    usersSubmissions[userName].Add(contest, 0);
                }

                if (usersSubmissions[userName][contest] < points)
                {
                    usersSubmissions[userName][contest] = points;
                }
            }

            int maxPoints = usersSubmissions
                .Select(x => x.Value.Values.Sum())
                .ToList()
                .Max();
            //string bestCandidate = usersSubmissions
            //    .Where(x =>x.Value.Values.Sum() == maxPoints)
            //    .SingleOrDefault()
            //    .Key;

            string bestCandidate = usersSubmissions
                .OrderByDescending(x => x.Value.Values.Sum())
                .FirstOrDefault()
                .Key;


            Console.WriteLine();
            Console.WriteLine($"Best candidate is {bestCandidate} with total {maxPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var (user, contest ) in usersSubmissions)
            {
                Console.WriteLine(user);

                var sortedSubissions = contest.OrderByDescending(x => x.Value);

                foreach (var submission in sortedSubissions)
                {
                    Console.WriteLine($"#  {submission.Key} -> {submission.Value}");
                }
            }
        }
    }
}
