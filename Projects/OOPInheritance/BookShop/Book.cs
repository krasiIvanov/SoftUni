using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class Book
    {

        private string title;
        private string author;
        private decimal price;

        public Book(string author, string title,  decimal price)
        {
            this.Author = author;
            this.Title = title;        
            this.Price = price;
            
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            private set
            {
                if (value.Count()<3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                this.title = value;
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }
            private set
            {
                string[] nameTokens = value.Split(' ');
                //string firstName = nameTokens[0];
                string lastName = nameTokens[1];
               
                if (Char.IsNumber(lastName[0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
                this.author = value;
            }
        }
        public virtual decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                this.price = value;

            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Type: ").Append(this.GetType().Name)
                    .Append(Environment.NewLine)
                    .Append("Title: ").Append(this.Title)
                    .Append(Environment.NewLine)
                    .Append("Author: ").Append(this.Author)
                    .Append(Environment.NewLine)
                    .Append("Price: ").Append(this.Price)
                    .Append(Environment.NewLine);

            return sb.ToString();
        }


    }
}
