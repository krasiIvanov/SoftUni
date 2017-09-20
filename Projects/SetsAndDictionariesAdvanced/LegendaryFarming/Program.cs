using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine().ToLower();
            SortedDictionary<string, int> kayMaterials = new SortedDictionary<string, int>();
            kayMaterials.Add("motes", 0);
            kayMaterials.Add("shards", 0);
            kayMaterials.Add("fragments", 0);

            SortedDictionary<string, int> junkMaterials = new SortedDictionary<string, int>();

            bool obtained = false;
            string obtainedMaterial = "";
            while (true)
            {
                string[] tokens = input.Split(' ');
                string currentMaterial = "";
                int value = 0;
                for (int i = 0; i < tokens.Length; i++)
                {
                    if (i%2==0)
                    {
                        value = int.Parse(tokens[i]);
                    }
                    else
                    {
                        currentMaterial = tokens[i];
                        if (kayMaterials.ContainsKey(currentMaterial))
                        {
                            kayMaterials[currentMaterial] += value;
                            if (kayMaterials[currentMaterial]>=250)
                            {
                                obtainedMaterial = currentMaterial;
                                obtained = true;
                                kayMaterials[currentMaterial] -= 250;
                                break;
                            }
                        }
                        else
                        {
                            if (!junkMaterials.ContainsKey(currentMaterial))
                            {
                                junkMaterials.Add(currentMaterial, value);
                            }
                            else
                            {
                                junkMaterials[currentMaterial] += value;
                            }
                        }
                    }
                }
                if (obtained)
                {
                    break;
                }
                input = Console.ReadLine().ToLower();
            }
            if (obtainedMaterial=="fragments")
            {
                Console.WriteLine("Valanyr obtained!");

            }
            else if(obtainedMaterial=="motes")
            {
                Console.WriteLine("Dragonwrath obtained!");
            }
            else if (obtainedMaterial == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }

            foreach (var item in kayMaterials.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junkMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
