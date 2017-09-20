using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{

    class Sales
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

       public decimal TotalSum
        {
            get
            {
                return this.Price * this.Quantity;
            }
        }
        public static  List<Sales> ReadOfSales()
        {
            var list = new List<Sales>();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                Sales newSale = new Sales()
                {
                    Town = tokens[0],
                    Product = tokens[1],
                    Price = decimal.Parse(tokens[2]),
                    Quantity = decimal.Parse(tokens[3])
                };

                list.Add(newSale);
            }
            return list;
        }
        public override string ToString()
        {
            return String.Format($"{this.Town} {this.Product} {this.Price} {this.Quantity}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var list = Sales.ReadOfSales();
            SortedDictionary<string, decimal> result = new SortedDictionary<string, decimal>();
            foreach (var item in list)
            {
                if (result.ContainsKey(item.Town))
                {
                    result[item.Town] += item.TotalSum;
                }
                else
                {
                    result.Add(item.Town, item.TotalSum);
                }
            }

            foreach (var item in result.Keys)
            {
                Console.WriteLine($"{item} -> {result[item]:f2}");
            }

        }
    }
}
