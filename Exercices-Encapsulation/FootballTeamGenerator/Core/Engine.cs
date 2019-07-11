namespace FootballTeamGenerator.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FootballTeamGenerator.Exceptions;
    using FootballTeamGenerator.Models;


    public class Engine
    {
        private readonly  List<Team> teams;

        public Engine()
        {
            this.teams = new List<Team>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                
                try
                {
                    string[] commandInfo = input.Split(";").ToArray();

                    string command = commandInfo[0];
                    string teamName = commandInfo[1];

                    if (command == "Team")
                    {

                        AddTeam(teamName);
                    }

                    else if (command == "Add")
                    {
                        AddPlayerToATeam(commandInfo, teamName);

                    }

                    else if (command == "Remove")
                    {
                        RemovePlayerFromATeam(commandInfo, teamName);
                    }

                    else if (command == "Rating")
                    {
                        GetTeamsRating(teamName);
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }

                input = Console.ReadLine();
            }
        }

        private void GetTeamsRating(string teamName)
        {
            ValidateTeamName(teamName);

            Team team = this.teams.First(t => t.Name == teamName);

            Console.WriteLine(team.ToString());
        }

        private void RemovePlayerFromATeam(string[] commandInfo, string teamName)
        {
            ValidateTeamName(teamName);

            string playerToRemove = commandInfo[2];

            Team team = this.teams.First(t => t.Name == teamName);

            team.RemovePlayer(playerToRemove);
        }

        private void AddPlayerToATeam(string[] commandInfo, string teamName)
        {
            ValidateTeamName(teamName);
            string playerName = commandInfo[2];

            Stat stat = CreateStat(commandInfo);

            Player playerToAdd = new Player(playerName, stat);

            Team team = this.teams.First(t => t.Name == teamName);

            team.AddPlayer(playerToAdd);
        }

        private void AddTeam(string teamName)
        {
            Team team = new Team(teamName);
            this.teams.Add(team);
        }

        private static Stat CreateStat(string[] commandInfo)
        {
            int endurance = int.Parse(commandInfo[3]);
            int sprint = int.Parse(commandInfo[4]);
            int dribble = int.Parse(commandInfo[5]);
            int passing = int.Parse(commandInfo[6]);
            int shooting = int.Parse(commandInfo[7]);

            Stat stat = new Stat(endurance, sprint, dribble, passing, shooting);

            return stat;
        }

        private void ValidateTeamName(string teamName)
        {
            if (string.IsNullOrWhiteSpace(teamName))
            {
                throw new ArgumentException(ExceptionMessages.EmptyNameException);
            }

            Team team = this.teams.FirstOrDefault(t => t.Name == teamName);

            if (team == null)
            {
                throw new ArgumentException(String.Format(ExceptionMessages.MissingTeamException, teamName));
            }
        }
    }
}
