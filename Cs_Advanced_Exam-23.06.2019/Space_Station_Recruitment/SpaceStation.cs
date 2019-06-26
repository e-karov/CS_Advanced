using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
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

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => this.data.Count;
      


        public void Add(Astronaut astronaut)
        {
            if (data.Count <= data.Capacity)
            {
                data.Add(astronaut);
            }
        }

        public bool Remove(string name)
        {
            bool isRemoved = false;

            Astronaut astronautToRemove = data.FirstOrDefault(a => a.Name == name);

            if (data.Contains(astronautToRemove))
            {
                data.Remove(astronautToRemove);
                isRemoved = true;
            }

            return isRemoved;
        }

        public Astronaut GetOldestAstronaut()
        {
            Astronaut oldestAstronaut = data.OrderByDescending(a => a.Age).FirstOrDefault();

            return oldestAstronaut;
        }

        public Astronaut GetAstronaut(string name)
        {
            Astronaut targetAstronaut = data.FirstOrDefault(a => a.Name == name);

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
