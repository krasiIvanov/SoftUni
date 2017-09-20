using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            List<Employee> employeeList = new List<Employee>();
            
            for (int i = 0; i < num; i++)
            {
                string[] employeeTokens = Console.ReadLine().Split();
                string name = employeeTokens[0];
                decimal salary = decimal.Parse(employeeTokens[1]);
                string position = employeeTokens[2];
                string department = employeeTokens[3];

                Employee employee;

                if (employeeTokens.Length==5)
                {
                    string emailOrAge = employeeTokens[4];
                    int age;
                    if (int.TryParse(emailOrAge,out age))
                    {
                        employee = new Employee(name,salary,position,department,age);
                    }
                    else
                    {
                        employee = new Employee(name, salary, position, department, emailOrAge);
                    }

                }
                else if (employeeTokens.Length>5)
                {
                    string email = employeeTokens[4];
                    int age = int.Parse(employeeTokens[5]);
                    employee = new Employee(name, salary, position, department, email, age);
                }
                else
                {
                    employee = new Employee(name, salary, position, department);
                }

                employeeList.Add(employee);


            }

            var result = employeeList
                .GroupBy(e => e.Department)
                .Select(e => new
                {
                    Department = e.Key,
                    AvaregeSalary = e.Average(emp => emp.Salary),
                    Employees=e.OrderByDescending(emp=>emp.Salary)
                }).FirstOrDefault();

            Console.WriteLine($"Highest average salary: {result.Department}");
            foreach (var emp in result.Employees)
            {
                Console.WriteLine(emp);
            }
        }


    }
}
