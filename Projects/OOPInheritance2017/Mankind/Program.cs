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
                string[] studentTokens = Console.ReadLine().Split();
                string[] workerTokens = Console.ReadLine().Split();

                string studentFirstName = studentTokens[0];
                string studentLastName = studentTokens[1];
                string facultyNumber = studentTokens[2];

                string workerFirstName = workerTokens[0];
                string workerLastName = workerTokens[1];
                decimal salary = decimal.Parse(workerTokens[2]);
                int hoursPerDay = int.Parse(workerTokens[3]);

                Student student = new Student(studentFirstName, studentLastName, facultyNumber);
                Worker worker = new Worker(workerFirstName,workerLastName,salary,hoursPerDay);

                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
