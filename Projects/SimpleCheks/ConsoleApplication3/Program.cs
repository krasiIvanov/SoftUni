using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            double num = double.Parse(Console.ReadLine());
            string fromtype = Console.ReadLine();
            string totype = Console.ReadLine();

            double kmToMm = ((num * 100) * 1000);
            double kmToCm = ((num * 100) * 100);
            double kmToMiles = ((num * 100) * 0.000621371192);
            double kmToInch = ((num * 100) * 39.3700787);
            double kmToFoot = ((num * 100) * 3.2808399);
            double kmToYards = ((num * 100) * 1.0936133);

            double mmToKm = (num /1000)* 0.001;
            double mmtocm = (num  / 1000) * 100;
            double mmtoMiles = (num / 1000) * 0.000621371192;
            double mmtoinch = (num / 1000) / 1000 * 39.3700787;
            double mmtofoot = (num / 1000) / 1000 * 3.2808399;
            double mmtoyards = (num / 1000) / 1000 * 1.0936133;

            double milesToKm = (num / 0.000621371192) * 0.001;
            double milestocm = (num / 0.000621371192) * 100;
            double milestoMiles = (num / 0.000621371192) * 10;
            double milestoinch = (num / 0.000621371192) * 39.3700787;
            double milestofoot = (num / 0.000621371192) * 3.2808399;
            double milestoyards = (num / 0.000621371192) * 1.0936133;
            double milestomm = (num / 0.000621371192) * 1000;

            double inchToKm = (num / 39.3700787) * 0.001;
            double inchtocm = (num / 39.3700787) * 100;
            double inchtoMiles = (num / 39.3700787) * 0.000621371192;
            double inchtoM = (num / 39.3700787) * 10;
            double inchtofoot = (num / 39.3700787) * 3.2808399;
            double inchtoyards = (num / 39.3700787) * 1.0936133;
            double inchtoMm = (num / 39.3700787) * 1000;

            double footToKm = (num / 3.2808399) * 0.001;
            double foottocm = (num / 3.2808399) * 100;
            double foottoMiles = (num / 3.2808399) * 0.000621371192;
            double foottoinch = (num / 3.2808399) * 39.3700787;
            double foottoM = (num / 3.2808399) * 10;
            double foottoyards = (num / 3.2808399) * 1.0936133;
            double foottoMm = (num / 3.2808399) * 1000;

            double yardToKm = (num / 1.0936133) * 0.001;
            double yardtocm = (num / 1.0936133) * 100;
            double yardtoMiles = (num / 1.0936133) * 0.000621371192;
            double yardtoinch = (num / 1.0936133) * 39.3700787;
            double yardtoFoot= (num / 1.0936133) * 3.2808399;
            double yardtoM = (num / 1.0936133) * 10;
            double yardtoMm = (num / 1.0936133) * 1000;

            //km
            if (fromtype.Equals("km") && totype.Equals("mm"))
            {
                Console.WriteLine(kmToMm + totype);
            }
            else if (fromtype.Equals("km") && totype.Equals("cm"))
            {
                Console.WriteLine(kmToCm + totype);
            }
            else if (fromtype.Equals("km") && totype.Equals("mi"))
            {
                Console.WriteLine(kmToMiles + totype);
            }
            else if (fromtype.Equals("km") && totype.Equals("in"))
            {
                Console.WriteLine(kmToInch + totype);
            }
            else if (fromtype.Equals("km") && totype.Equals("ft"))
            {
                Console.WriteLine(kmToFoot + totype);
            }
            else if (fromtype.Equals("km") && totype.Equals("yd"))
            {
                Console.WriteLine(kmToYards + totype);
            }

            //mm
            if (fromtype.Equals("mm") && totype.Equals("km"))
            {
                Console.WriteLine(mmToKm + totype);
            }
            else if (fromtype.Equals("mm") && totype.Equals("cm"))
            {
                Console.WriteLine(mmtocm + totype);
            }
            else if (fromtype.Equals("mm") && totype.Equals("mi"))
            {
                Console.WriteLine(mmtoMiles + totype);
            }
            else if (fromtype.Equals("mm") && totype.Equals("in"))
            {
                Console.WriteLine(mmtoinch + totype);
            }
            else if (fromtype.Equals("mm") && totype.Equals("ft"))
            {
                Console.WriteLine(mmtofoot + totype);
            }
            else if (fromtype.Equals("mm") && totype.Equals("yd"))
            {
                Console.WriteLine(mmtoyards + totype);
            }

            //miles
            if (fromtype.Equals("mi") && totype.Equals("mm"))
            {
                Console.WriteLine(milestomm + totype);
            }
            else if (fromtype.Equals("mi") && totype.Equals("cm"))
            {
                Console.WriteLine(milestocm + totype);
            }
            else if (fromtype.Equals("mi") && totype.Equals("m"))
            {
                Console.WriteLine(milestoMiles + totype);
            }
            else if (fromtype.Equals("mi") && totype.Equals("in"))
            {
                Console.WriteLine(milestoinch + totype);
            }
            else if (fromtype.Equals("mi") && totype.Equals("ft"))
            {
                Console.WriteLine(milestofoot + totype);
            }
            else if (fromtype.Equals("mi") && totype.Equals("yd"))
            {
                Console.WriteLine(milestoyards + totype);
            }
            else if (fromtype.Equals("mi") && totype.Equals("km"))
            {
                Console.WriteLine(milesToKm + totype);
            }

            //inch

            if (fromtype.Equals("in") && totype.Equals("mm"))
            {
                Console.WriteLine(inchtoMm + totype);
            }
            else if (fromtype.Equals("in") && totype.Equals("cm"))
            {
                Console.WriteLine(inchtocm + totype);
            }
            else if (fromtype.Equals("in") && totype.Equals("mi"))
            {
                Console.WriteLine(inchtoMiles + totype);
            }
            else if (fromtype.Equals("in") && totype.Equals("m"))
            {
                Console.WriteLine(inchtoM + totype);
            }
            else if (fromtype.Equals("in") && totype.Equals("ft"))
            {
                Console.WriteLine(inchtofoot + totype);
            }
            else if (fromtype.Equals("in") && totype.Equals("yd"))
            {
                Console.WriteLine(inchtoyards + totype);
            }
            else if (fromtype.Equals("in") && totype.Equals("km"))
            {
                Console.WriteLine(inchToKm + totype);
            }

            //foot
            if (fromtype.Equals("ft") && totype.Equals("mm"))
            {
                Console.WriteLine(foottoMm + totype);
            }
            else if (fromtype.Equals("ft") && totype.Equals("cm"))
            {
                Console.WriteLine(foottocm + totype);
            }
            else if (fromtype.Equals("ft") && totype.Equals("mi"))
            {
                Console.WriteLine(foottoMiles + totype);
            }
            else if (fromtype.Equals("ft") && totype.Equals("m"))
            {
                Console.WriteLine(foottoM + totype);
            }
            else if (fromtype.Equals("ft") && totype.Equals("in"))
            {
                Console.WriteLine(foottoinch + totype);
            }
            else if (fromtype.Equals("ft") && totype.Equals("yd"))
            {
                Console.WriteLine(foottoyards + totype);
            }
            else if (fromtype.Equals("ft") && totype.Equals("km"))
            {
                Console.WriteLine(footToKm + totype);
            }

            //yards
            if (fromtype.Equals("yd") && totype.Equals("mm"))
            {
                Console.WriteLine(yardtoMm + totype);
            }
            else if (fromtype.Equals("yd") && totype.Equals("cm"))
            {
                Console.WriteLine(yardtocm + totype);
            }
            else if (fromtype.Equals("yd") && totype.Equals("m"))
            {
                Console.WriteLine(yardtoM + totype);
            }
            else if (fromtype.Equals("yd") && totype.Equals("mi"))
            {
                Console.WriteLine(yardtoMiles + totype);
            }
            else if (fromtype.Equals("yd") && totype.Equals("in"))
            {
                Console.WriteLine(yardtoinch + totype);
            }
            else if (fromtype.Equals("yd") && totype.Equals("km"))
            {
                Console.WriteLine(yardToKm+totype);
            }

        }
    }
}
