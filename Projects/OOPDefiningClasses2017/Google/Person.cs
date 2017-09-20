using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Person
    {
        private string name;
        private Company company;
        private Car car;
        private List<Pokemon> pokemons;
        private List<Parents> parents;
        private List<Children> childrens;

        public Person(string name)
        {
            this.Name = name;
            pokemons = new List<Pokemon>();
            parents = new List<Parents>();
            childrens = new List<Children>();
        }

        public string Name { get => name; set => name = value; }
        public Company Company { get => company; set => company = value; }
        public Car Car { get => car; set => car = value; }
        public List<Pokemon> Pokemons { get => pokemons; set => pokemons = value; }
        public List<Parents> Parents { get => parents; set => parents = value; }
        public List<Children> Childrens { get => childrens; set => childrens = value; }

        public void AddPokemon(Pokemon pokemon)
        {
            pokemons.Add(pokemon);
        }
        public void AddParent(Parents parent)
        {
            parents.Add(parent);
        }
        public void AddChildren(Children children)
        {
            childrens.Add(children);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.name}")
                .Append(Environment.NewLine)
                .Append("Company:")
                .Append(Environment.NewLine)
                .Append(this.company)
                .Append(Environment.NewLine)
                .Append("Car:")
                .Append(Environment.NewLine)
                .Append(this.car)
                .Append(Environment.NewLine)              
                .Append("Pokemons:")
                .Append(Environment.NewLine)
                .Append(string.Join(Environment.NewLine, pokemons))
                .Append(Environment.NewLine)
                .Append("Parents:")
                .Append(Environment.NewLine)
                .Append(string.Join(Environment.NewLine, parents))
                .Append(Environment.NewLine)
                .Append("Childrens:")
                .Append(Environment.NewLine)
                .Append(string.Join(Environment.NewLine, childrens));


            return sb.ToString();
        }
    }
}
