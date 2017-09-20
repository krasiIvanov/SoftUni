using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    class Trainer
    {
        public string name;
        public int badges;
        public List<Pokemon> pokemons;

        public Trainer(string name, int badges,List<Pokemon> pokemons)
        {
            this.name = name;
            this.badges = badges;
            this.pokemons = pokemons;
        }
    }
}
