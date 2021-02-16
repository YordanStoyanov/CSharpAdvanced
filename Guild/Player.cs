using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {
        public Player(string name, string @class)
        {
            this.Name = name;
            this.Class = @class;
        }
        
        public Player(string name, string @class, string description)
        {
            this.Name = name;
            this.Class = @class;
            this.Description = "n/a";
        }
        public Player(string name, string @class, string rank, string description)
        {
            this.Name = name;
            this.Class = @class;
            this.Rank = "Trial";
            this.Description = "n/a";
        }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Player {Name}: {Class}");
            result.AppendLine($"Rank: {Rank}");
            result.AppendLine($"Description: {Description}");
            return result.ToString().TrimEnd();
        }
    }
}
