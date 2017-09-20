using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedDictionary<string, SortedDictionary<string, int>> result = 
                new SortedDictionary<string, SortedDictionary<string, int>>();

            Dictionary<string, int> tempDic = new Dictionary<string, int>();

            while (true)
            {

                string input = Console.ReadLine();
                if (input=="report")
                {
                    break;
                }

                string[] tokens = input.Split('|');
                string city = tokens[0];
                string country = tokens[1];
                int population = int.Parse(tokens[2]);

                SortedDictionary<string, int> citiesAndPopulation = new SortedDictionary<string, int>();
                citiesAndPopulation.Add(city, population);

                if (!result.ContainsKey(country))
                {
                    result.Add(country, citiesAndPopulation);
                }
                else
                {
                    if (!result[country].ContainsKey(city))
                    {
                        result[country].Add(city, population);
                    }
                    else
                    {
                        result[country][city] = population;
                    }
                }

                if (!tempDic.ContainsKey(country))
                {
                    tempDic.Add(country, population);
                }
                else
                {
                    tempDic[country] += population;
                }

            }

            foreach (var item in tempDic.OrderByDescending(key=>key.Value))
            {
                
                Console.WriteLine($"{item.Key} (total population: {tempDic[item.Key]})");
                foreach (var city in result[item.Key])
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");

                }
            }
        }
    }
}
