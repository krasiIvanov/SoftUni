using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            while (input!= "Tournament")
            {

                string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string trainerName = tokens[0];

                Trainer trainer = new Trainer(trainerName);
                
                string pokemonName = tokens[1];
                string pokemonElement = tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!trainers.Keys.Contains(trainerName))
                {
                    trainer.AddPokemon(pokemon);
                    trainers.Add(trainerName, trainer);
                }
                else
                {
                    trainers[trainerName].AddPokemon(pokemon);
                }

                input = Console.ReadLine();
            }

            string tournamentInput = Console.ReadLine();

            while (tournamentInput!="End")
            {
                foreach (var trainer in trainers.Values)
                {
                    trainer.CheckPokemon(tournamentInput);
                }
                

                tournamentInput = Console.ReadLine();
            }

            foreach (var trainer in trainers.Values.OrderByDescending(t=>t.NumberOfBadges))
            {
                Console.WriteLine(trainer);
            }

        }
    }
}
