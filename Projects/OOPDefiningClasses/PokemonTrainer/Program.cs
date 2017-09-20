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
            Dictionary<string, List<Pokemon>> trainersAndPokemons = new Dictionary<string, List<Pokemon>>();
            List<Trainer> trainers = new List<Trainer>();
            
            while (input!="Tournament")
            {
                string[] tokens = input.Split(' ');
                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string element = tokens[2];
                int health =int.Parse(tokens[3]);
                Pokemon newPokemon = new Pokemon(pokemonName, element, health);
                if (!trainersAndPokemons.ContainsKey(trainerName))
                {
                    trainersAndPokemons.Add(trainerName, new List<Pokemon> { newPokemon});
                }
                else
                {
                    trainersAndPokemons[trainerName].Add(newPokemon);
                }
                input = Console.ReadLine();
            }

            foreach (var item in trainersAndPokemons.Keys)
            {
                Trainer newTrainer = new Trainer(item, 0, trainersAndPokemons[item]);
                trainers.Add(newTrainer);
            }
            string comand = Console.ReadLine();

            while (comand!="End")
            {
                foreach (var item in trainersAndPokemons.Keys)
                {
                    var currentTrainer = trainers.Where(t => t.name == item).First();
                    bool flag = false;
                    foreach (var pokemons in trainersAndPokemons[item])
                    {
                        if (pokemons.element==comand)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                    {
                        currentTrainer.badges++;
                    }
                    else
                    {
                        trainersAndPokemons[item].Select(x => x.health -= 10).ToList();
                        trainersAndPokemons[item].RemoveAll(x => x.health <= 0);
                        
                    }
                }
                comand = Console.ReadLine();
            }
            var result = trainers.OrderByDescending(x => x.badges);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.name} {item.badges} {item.pokemons.Count()}");
            }
        }
    }
}
