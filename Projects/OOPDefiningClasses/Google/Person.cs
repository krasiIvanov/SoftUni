using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Person
    {
        public string name;
        public Company company;
        public Car car;
        public List<Pokemon> pokemons=new List<Pokemon>();
        public List<Parent> parents=new List<Parent>();
        public List<Childern> childrens = new List<Childern>();

        public Person(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return $"{this.name}\nCompany:\n{this.company.ToString()}\nCar:\n{this.car.ToString()}\nPokemon:\n{String.Join("\n",this.pokemons)}\nParents:\n{String.Join("\n", this.parents)}\nChildren:\n{String.Join("\n", this.childrens)}";
        }
    }
}
