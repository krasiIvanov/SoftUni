using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            string input = Console.ReadLine();

            while (input!="END")
            {
                try
                {
                    string[] tokens = input.Split(';');

                    string cmd = tokens[0];
                    string teamName=tokens[1];
                    string plName ;
                    Team currentTeam;
                    switch (cmd)
                    {
                        
                        case "Team":                           
                            Team team = new Team(teamName);
                            teams.Add(team);
                            break;
                        case "Add":
                            plName = tokens[2];
                            int endurance = int.Parse(tokens[3]);
                            int sprint = int.Parse(tokens[4]);
                            int dribble = int.Parse(tokens[5]);
                            int passing = int.Parse(tokens[6]);
                            int shooting = int.Parse(tokens[7]);
                            Stats stats = new Stats(endurance, sprint, dribble, passing, shooting);
                            Player player = new Player(plName, stats);
                            currentTeam = teams.Where(t => t.Name == teamName).FirstOrDefault();
                            currentTeam.AddPlayer(player);
                            break;
                        case "Remove":
                            plName = tokens[2];
                            currentTeam = teams.Where(t => t.Name == teamName).FirstOrDefault();
                            currentTeam.RemovePlayer(plName);
                            break;
                        case "Rating":
                            currentTeam = teams.Where(t => t.Name == teamName).FirstOrDefault();
                            Console.WriteLine($"{teamName} - {currentTeam.TeamStats()}");
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                input = Console.ReadLine();
            }

        }
    }
}
