using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;
        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.roster = new List<Player>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count { get; }

        public void AddPlayer(Player player)
        {
            if (this.roster.Count < this.Capacity)
            {
                this.roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            Player player = roster.FirstOrDefault(p => p.Name == name);
            if (player != null)
            {
                this.roster.Remove(player);
                return true;
            }
            return false;

            //foreach (var player in roster)
            //{
            //    if (player.Name == name)
            //    {
            //        roster.Remove(player);
            //        break;
            //    }
            //}
        }
        public Player PromotePlayer(string name)
        {
            Player player = roster.FirstOrDefault(p => p.Name == name);
            if (player.Rank != "Member")
            {
                player.Rank = "Member";
            }
            return player;
        }

        public Player DemotePlayer(string name)
        {
            Player player = roster.FirstOrDefault(p => p.Name == name);
            if (player.Rank != "Trial")
            {
                player.Rank = "Trial";
            }
            return player;
        }

        public Player[] KickPlayersByClass(string @class)
        {
            Player[] player =new Player[] {roster.FirstOrDefault(p => p.Class == @class)};
            
            if (player != null)
            {
                
                this.roster.Remove(player.FirstOrDefault());
            }
            return player;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");
            foreach (var player in roster)
            {
                sb.AppendLine($"{player.Name}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
