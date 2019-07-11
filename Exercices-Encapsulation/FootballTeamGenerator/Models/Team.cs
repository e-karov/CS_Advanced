namespace FootballTeamGenerator.Models
{
    using FootballTeamGenerator.Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Team
    {
        private string name;
        private List<Player> players;

        private Team()
        {
            this.players = new List<Player>();
        }

        public Team(string name)
            :this()
        {
            this.Name = name;
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.EmptyNameException);
                }

                this.name = value;
            }
        }

        public int Rating
        {
            get
            {
                int overallRating;

                if (this.players.Count == 0)
                {
                    overallRating = 0;
                }
                else
                {
                    overallRating = (int)(Math.Round(this.players.Average(p => p.OverallSkill), 0));
                }

                return overallRating;
            }
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string name)
        {
            Player playerToRemove = this.players.FirstOrDefault(p => p.Name == name);

            if (playerToRemove == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.MissingPlayerException, name, this.Name));
            }

            this.players.Remove(playerToRemove);
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}";
        }
    }
}
