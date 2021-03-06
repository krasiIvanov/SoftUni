﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                string author = Console.ReadLine();
                string title = Console.ReadLine();
                decimal price = Decimal.Parse(Console.ReadLine());

                Book book = new Book(author, title, price);
                GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);
                Console.WriteLine(book);
                Console.WriteLine(goldenEditionBook);

            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
