namespace SpaceStationRecruitment
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class SpaceStation
    {
        private List<Astronaut> data;

        public SpaceStation()
        {
            this.data = new List<Astronaut>();
        }

        public  SpaceStation(string name, int capacity)
        {
            this.data = new List<Astronaut>();

            this.Name = name;
            this.Capacity = capacity;
        }

        public string Name { get; private set; }

        public int Capacity { get; private set; }

        public int Count => this.data.Count;
      


        public void Add(Astronaut astronaut)
        {
            if (this.Count < this.Capacity)
            {
                this.data.Add(astronaut);
            }
        }

        public bool Remove(string name)
        {
            bool isRemoved = false;

            Astronaut astronautToRemove = data.FirstOrDefault(a => a.Name == name);

            if (astronautToRemove != null)
            {
                data.Remove(astronautToRemove);
                isRemoved = true;
            }
            return isRemoved;
        }

        public Astronaut GetOldestAstronaut()
        {
            Astronaut oldestAstronaut = data.OrderByDescending(a => a.Age).FirstOrDefault();

            if (oldestAstronaut == null)
            {
                throw new System.InvalidOperationException("Collection is empty");
            }
            return oldestAstronaut;
        }

        public Astronaut GetAstronaut(string name)
        {
            Astronaut targetAstronaut = data.FirstOrDefault(a => a.Name == name);

            if (targetAstronaut == null)
            {
                throw new System.InvalidOperationException($"No astronaut with name {name} in the Collection");
            }
            return targetAstronaut;
        }

        public string Report()
        {
            StringBuilder report = new StringBuilder();

            report.AppendLine($"Astronauts working at Space Station {this.Name}:");
            foreach (var astronaut in data)
            {
                report.AppendLine($"{astronaut}");
            }
            return report.ToString().TrimEnd();
        }
    }
}
