using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmountOfBeers
{
    class Program
    {
        static void Main(string[] args)
        {


            int beers = int.Parse(Console.ReadLine());
            long totalBeers = 0;

            while (true)
            {
                string comand = Console.ReadLine();
                if (comand == "Exam Over")
                {
                    break;
                }

                var beerType = comand.Split(' ').ToArray();
                long amount = long.Parse(beerType[0]);
                if (beerType[1] == "beers")
                {
                    totalBeers += amount;
                }
                else if (beerType[1] == "cases")
                {
                    totalBeers += amount * 24;
                }
                else if (beerType[1] == "sixpacks")
                {
                    totalBeers += amount * 6;
                }


            }

            if (totalBeers >= 100)
            {
                totalBeers -= totalBeers / 100;
            }
            long beerLeft = Math.Abs(beers - totalBeers);
            long cases = 0;
            long sixpacks = 0;
            long singleBer = 0;
            
            if (beerLeft>=24)
            {
                cases = beerLeft / 24;
                beerLeft %= 24;
            }
            if (beerLeft<24 && beerLeft>5)
            {
                sixpacks = beerLeft / 6;
                beerLeft %= 6;
            }


            singleBer = beerLeft;

            if (totalBeers >= beers)
            {
                Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", cases, sixpacks, singleBer);
            }
            else
            {
                Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", cases, sixpacks, singleBer);
            }
        }
    }
}
