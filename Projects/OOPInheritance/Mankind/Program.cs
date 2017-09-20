using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    class Program
    {
        static void Main(string[] args)
        {

            
            try
            {
                string[] studentsInfo = Console.ReadLine().Split(' ');

                string studentFirstName = studentsInfo[0];
                string studentLastName = studentsInfo[1];
                string studentFacNumber = studentsInfo[2];

                Student student = new Student(studentFirstName,studentLastName,studentFacNumber);

                string[] workerInfo = Console.ReadLine().Split(' ');
                string workerFirstName = workerInfo[0];
                string workerLastName = workerInfo[1];
                decimal weekSalary = decimal.Parse(workerInfo[2]);
                decimal hoursPreDey = decimal.Parse(workerInfo[3]);

                Worker worker = new Worker(workerFirstName,workerLastName,weekSalary,hoursPreDey);

                Console.WriteLine(student);
                Console.WriteLine(worker);


            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
