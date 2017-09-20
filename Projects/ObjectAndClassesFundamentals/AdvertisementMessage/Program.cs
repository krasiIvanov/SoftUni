﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            string[] phrases = new string[] {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."};
            string[] events = new string[] {"Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};
            string[] author = new string[] {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
            string[] cities = new string[] {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            for (int i = 0; i < num; i++)
            {
                
                Console.WriteLine($"{phrases[ rnd.Next(0,phrases.Length)]} {events[rnd.Next(0,events.Length)]} {author[rnd.Next(0,author.Length)]} - {cities[rnd.Next(0,cities.Length)]}");
            }
        }
    }
}
