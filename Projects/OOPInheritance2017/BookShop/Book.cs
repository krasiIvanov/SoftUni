using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    public class Book
    {

        private string title;
        private string author;
        private decimal price;

        public Book(string author ,string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public virtual decimal Price
        {
            get { return price; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                price = value;
            }
        }


        public string Author
        {
            get { return author; }
            set
            {
                string[] nameTokens = value.Split();
                if (!char.IsLetter(nameTokens[1][0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
                author = value;
            }
        }


        public string Title
        {
            get { return title; }
            set
            {
                if (value.Length<3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                title = value;
            }
        }

        public override string ToString()
        {
            return $"{Author} - {Title} - {Price}";
        }

    }
}
