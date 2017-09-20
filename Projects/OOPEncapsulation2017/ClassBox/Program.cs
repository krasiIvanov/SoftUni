using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassBox
{
    class Program
    {
        static void Main(string[] args)
        {

            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(length, width, height);
                double surfaceArea = box.SurfaceArea();
                double leteralSurfaceArea = box.LeteralSurfaceArea();
                double volume = box.Volume();

                Console.WriteLine($"Surface Area – {surfaceArea:f2}");
                Console.WriteLine($"Lateral Surface Area  – {leteralSurfaceArea:f2}");
                Console.WriteLine($"Volume – {volume:f2}");
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
            

            

        }
    }
}
