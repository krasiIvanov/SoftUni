using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {


            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double width = (w * 100)-100;
            double lenght = l * 100;

            int desk = (int)width / 70;

            int rows = (int)lenght / 120;

            int places = rows * desk - 3;

            Console.WriteLine(places);

        }
    }
}
