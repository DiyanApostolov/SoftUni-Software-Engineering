using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TheRace
{
    public class Race
    {
        readonly List<Racer> data = new List<Racer>();
        
        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => data.Count;

        public void Add(Racer racer)
        {
            if (data.Count < Capacity)
            {
                data.Add(racer);
            }
        }

        public bool Remove(string name)
        {
            Racer currentRacer = data.FirstOrDefault(r => r.Name == name);
            if (currentRacer != null)
            {
                data.Remove(currentRacer);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Racer GetOldestRacer()
        {
            return data.OrderByDescending(r => r.Age).FirstOrDefault();
        }

        public Racer GetRacer(string name)
        {
            Racer currentRacer = data.FirstOrDefault(r => r.Name == name);
            return currentRacer;
        }

        public Racer GetFastestRacer()
        {
            Racer currentRacer = data.OrderByDescending(r => r.Car.Speed).FirstOrDefault();
            return currentRacer;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racers participating at {Name}:");
            foreach (var racer in data)
            {
                sb.AppendLine(racer.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
