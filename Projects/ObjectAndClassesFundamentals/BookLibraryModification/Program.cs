using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        public static List<Books> ReadBook()
        {
            List<Books> list = new List<Books>();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                var newBook = new Books()
                {
                    Title = tokens[0],
                    Author = tokens[1],
                    Publisher = tokens[2],
                    ReleaseDate = DateTime.ParseExact( tokens[3],"dd.MM.yyyy",CultureInfo.InvariantCulture),
                    ISBN = tokens[4],
                    Price = decimal.Parse(tokens[5])

                };
                list.Add(newBook);
            }
            return list;
        }

    }

    class Library
    {
        public string Name { get; set; }
        public List<Books> ListOfBooks { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var newBooks = Books.ReadBook().OrderBy(x => x.ReleaseDate).ThenBy(a => a.Title);
            string dateString = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateString, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Dictionary<string, decimal> result = new Dictionary<string, decimal>();

           
            foreach (var item in newBooks)
            {
                if (item.ReleaseDate>=date)
                {
                    Console.WriteLine($"{item.Title} -> {item.ReleaseDate:dd.MM.yyyy}");
                }
            }

        }
    }
}
