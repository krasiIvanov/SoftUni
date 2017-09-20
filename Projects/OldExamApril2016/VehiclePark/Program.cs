using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclePark
{
    class Program
    {
        static void Main(string[] args)
        {

            var park = Console.ReadLine().Split(' ').ToList();
            int sold = 0;
            while (true)
            {
                string request = Console.ReadLine().ToLower();
                if (request== "end of customers!")
                {
                    break;
                }
                string[] type = request.Split(' ');
                string vehicle = type[0];
                char vehicleChar;
                vehicleChar = vehicle[0];
           
                string seat = type[2];

                string totalString = ""+vehicleChar + seat;
                int price = int.Parse(seat);
                int totalPrice = vehicleChar * price;
                bool flag = false;
                for (int i = 0; i < park.Count; i++)
                {
                    if (park[i]==totalString)
                    {

                        flag = true;
                        sold++;
                        park.Remove(park[i]);
                        break;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Yes, sold for {0}$",totalPrice);
                }
                else
                {
                    Console.WriteLine("No");
                }
            }

            Console.WriteLine("Vehicles left: {0}",string.Join(", ",park));
            Console.WriteLine("Vehicles sold: {0}",sold);

        }
    }
}
