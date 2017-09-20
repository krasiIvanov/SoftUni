using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
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
            
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            try
            {
                Box box = new Box(lenght, width, height);
                Console.WriteLine(box);
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
            

            

        }
    }
}
