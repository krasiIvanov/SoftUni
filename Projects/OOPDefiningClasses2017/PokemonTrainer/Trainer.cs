using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    class Trainer
    {

        private string name;
        private int numberOfBadges;
        List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.Name = name;
            this.NumberOfBadges=0;
            this.pokemons = new List<Pokemon>();
        }


        public void AddPokemon(Pokemon pokemon)
        {
            pokemons.Add(pokemon);
        }
        public void RemovePokemon(Pokemon pokemon)
        {
            pokemons.Remove(pokemon);
        }



        public void CheckPokemon(string element)
        {
            bool flag = false;
            foreach (var poke in pokemons)
            {
                if (poke.Element==element)
                {
                    numberOfBadges++;
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                for (int i = 0; i < pokemons.Count; i++)
                {
                    pokemons[i].Health -= 10;
                    if (pokemons[i].Health<=0)
                    {
                        pokemons.RemoveAt(i);
                    }
                }
            }
        }

        public string Name { get => name; set => name = value; }
        public int NumberOfBadges { get => numberOfBadges; set => numberOfBadges = value; }
        public List<Pokemon> Pokemons { get => pokemons;  }

        public override string ToString()
        {
            string result = $"{name} {numberOfBadges} {pokemons.Count}";
            return result;
        }
    }
}
