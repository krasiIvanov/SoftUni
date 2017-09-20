using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    class Team
    {
        private string name;
        
        private List<Player>players;

        public Team(string name)
        {
            this.Name = name;
            
            this.players = new List<Player>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty. ");
                }
                name = value;
            }
        }
        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }
        public void RemovePlayer(string name)
        {
            var player=players.Where(p => p.Name == name).FirstOrDefault();
            players.Remove(player);
            Console.WriteLine($"Player {name} is not in Arsenal team.");
        }
        public double TeamStats()
        {
            double stats = 0;
            foreach (var pl in players)
            {
                stats += pl.Stats.PlayerStats();
            }
            if (stats==0)
            {
                return 0;
            }
            double result =stats / players.Count;

            return result;
        }

    }

    
}
