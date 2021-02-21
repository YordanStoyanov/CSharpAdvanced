using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data;

        public Race(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Racer>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count { get { return this.data.Count; } }

        public void Add(Racer Racer)
        {
            if (this.data.Count < this.Capacity)
            {
                this.data.Add(Racer);
            }
        }

        public bool Remove(string name)
        {
            Racer racer = this.data.FirstOrDefault(r => r.Name == name);
            if (racer == null)
            {
                return false;
            }

            this.data.Remove(racer);
            return true;
        }

        public Racer GetOldestRacer()
        {
            return data.OrderByDescending(r => r.Age).FirstOrDefault();
        }

        public Racer GetRacer(string name)
        {
            Racer racer = data.FirstOrDefault(r => r.Name == name);
            return racer;
        }
        public Racer GetFastestRacer()
        {
            Racer racer = data.OrderByDescending(r => r.Car.Speed).FirstOrDefault();
            return racer;
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Racers participating at {Name}:");
            foreach (var racer in data)
            {
                result.AppendLine($"Racer: {racer.Name}, {racer.Age} ({racer.Country})");
            }
            return result.ToString().TrimEnd();
        }
    }
}
