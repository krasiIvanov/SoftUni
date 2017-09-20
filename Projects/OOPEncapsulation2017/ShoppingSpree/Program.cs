using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] people = Console.ReadLine().Split(new char[] { ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string[] products = Console.ReadLine().Split(new char[] { ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, Person> allPersons = new Dictionary<string, Person>();
            Dictionary<string, Product> allProducts = new Dictionary<string, Product>();


            try
            {
                foreach (var p in people)
                {
                    string[] peopleTokens = p.Split('=');
                    string name = peopleTokens[0];
                    decimal money = decimal.Parse(peopleTokens[1]);
                    if (!allPersons.ContainsKey(name))
                    {
                        Person newPerson = new Person(name, money);
                        allPersons.Add(name, newPerson);
                    }
                }
                foreach (var prod in products)
                {
                    string[] peopleTokens = prod.Split('=');
                    string name = peopleTokens[0];
                    decimal cost = decimal.Parse(peopleTokens[1]);
                    if (!allProducts.ContainsKey(name))
                    {
                        Product newProduct = new Product(name, cost);
                        allProducts.Add(name, newProduct);
                    }
                }
           

            string input = Console.ReadLine();

            while (input!="END")
            {
                string[] inputTokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string personName=inputTokens[0];
                string productName = inputTokens[1];

                Person currentPerson = allPersons[personName];
                Product currentProduct = allProducts[productName];
                try
                {

                    currentPerson.BuyProduct(currentProduct);


                }
                catch (InvalidOperationException ex)
                {

                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }
            }
            catch (ArgumentException aex)
            {

                Console.WriteLine(aex.Message);

            }
            foreach (var per in allPersons.Values)
            {
                Console.WriteLine(per);
            }
           

        }
    }
}
