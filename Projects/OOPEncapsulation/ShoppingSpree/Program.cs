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
            Dictionary<string, Person> persons = new Dictionary<string, Person>();
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            String[] personsInput = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
            String[] productsInput = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < personsInput.Length; i+=2)
            {
                string name = personsInput[i];
                decimal money = decimal.Parse(personsInput[i + 1]);
                try
                {
                    Person newPerson = new Person(name, money);
                    persons.Add(name, newPerson);
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                    return;
                }
                
                

            }

            for (int i = 0; i < productsInput.Length; i += 2)
            {
                string name = productsInput[i];
                decimal cost = decimal.Parse(productsInput[i + 1]);

                try
                {
                    Product newProduct = new Product(name, cost);
                    products.Add(name, newProduct);
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                    return;
                }
                

            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split(' ');

                string personName = tokens[0];
                string productName = tokens[1];
                try
                {
                    persons[personName].BuyProduct(products[productName]);
                }
                catch (InvalidOperationException ex)
                {

                    Console.WriteLine(ex.Message);
                    //break;
                }
                

                input = Console.ReadLine();
            }
            foreach (var item in persons.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
