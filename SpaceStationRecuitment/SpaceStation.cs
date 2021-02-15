using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecuitment
{
    public class SpaceStation
    {
        private List<Astronaut> astronauts;

        public SpaceStation(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.astronauts = new List<Astronaut>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count { get; }

        public void Add(Astronaut astronaut)
        {
            if (this.astronauts.Count < this.Capacity)
            {
                this.astronauts.Add(astronaut);
            }
        }

        public bool Remove(string name)
        {
            foreach (var astronaut in astronauts)
            {
                if (astronaut.Name == name)
                {
                    astronauts.Remove(astronaut);
                    return true;
                }
            }
            return false;
        }

        public Astronaut GetOldestAstronaut()
        {
            //Astronaut astronaut = astronauts.OrderByDescending(a => a.Age).FirstOrDefault();
            //return astronaut;

            Astronaut result = null;
            foreach (var astronaut in this.astronauts)
            {
                if (astronaut.Age > result.Age)
                {
                    result = astronaut;
                }
            }
            return result;
        }

        public Astronaut GetAstronaut(string name)
        {
            Astronaut result = null;
            foreach (var astronaut in astronauts)
            {
                if (astronaut.Name == name)
                {
                    result = astronaut;
                    break;
                }
            }
            return result;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Astronauts working at Space Station {this.Name}");

            foreach (var astroaut in this.astronauts)
            {
                sb.AppendLine(astroaut.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
