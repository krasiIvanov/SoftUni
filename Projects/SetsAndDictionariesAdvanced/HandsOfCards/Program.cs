using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {


            Dictionary<string, HashSet<string>> playerCards = new Dictionary<string, HashSet<string>>();
            string[] cardsFromJtoA = {"A","J","K","Q" };

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "JOKER")
                {
                    break;
                }

                

                string[] tokens = input.Split(':');
                string name = tokens[0];
                string[] cards = tokens[1].Trim().Split(new char[] { ',',' ' }, StringSplitOptions.RemoveEmptyEntries);
                HashSet<string> uniqueCards = new HashSet<string>();
                for (int i = 0; i < cards.Length; i++)
                {
                    uniqueCards.Add(cards[i]);
                }

               

                if (!playerCards.ContainsKey(name))
                {
                    playerCards.Add(name, uniqueCards);
                }
                else
                {
                    playerCards[name].UnionWith(uniqueCards);
                }
            }


            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (var name in playerCards.Keys)
            {
                int points = 0;
                foreach (var card in playerCards[name])
                {
                    char[] cardsValueAndType = card.ToCharArray();
                    string value = cardsValueAndType[0].ToString();
                    string type = cardsValueAndType[1].ToString();

                    int valuePoint = 0;
                    int typePoint = 0;
                    if (value == "1")
                    {
                        value = "10";
                        type = cardsValueAndType[2].ToString();

                    }
                    if (!cardsFromJtoA.Contains(value))
                    {
                        valuePoint = int.Parse(value);

                    }
                    else
                    {
                        if (value == "A")
                        {
                            valuePoint = 14;
                        }
                        else if (value == "K")
                        {
                            valuePoint = 13;
                        }
                        else if (value == "Q")
                        {
                            valuePoint = 12;
                        }
                        else if (value == "J")
                        {
                            valuePoint = 11;
                        }

                    }

                    if (type == "S")
                    {
                        typePoint = 4;
                    }
                    else if (type == "H")
                    {
                        typePoint = 3;
                    }
                    else if (type == "D")
                    {
                        typePoint = 2;
                    }
                    else if (type == "C")
                    {
                        typePoint = 1;
                    }


                    points += valuePoint * typePoint;
                }
                result.Add(name, points);
            }
            

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
