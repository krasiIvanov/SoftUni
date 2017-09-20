using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyRoster
{
    class Employee
    {
        public string name;
        public decimal salary;
        public string position;
        public string department;
        public string email;
        public int age;

       
        public Employee(string name,decimal salary,string position,string department,string email,int age)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.email = email;
            this.age = age;
        }
        public Employee(string name, decimal salary, string position, string department):this(name,salary,position,department, @"n/a", -1)
        {

        }



    }
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfEmployees = int.Parse(Console.ReadLine());
            List<Employee> listWithEmployees = new List<Employee>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                string[] employees = Console.ReadLine().Split();
                string name = employees[0];
                decimal salary = decimal.Parse(employees[1]);
                string position = employees[2];
                string department = employees[3];
                string email;
                int age;
                var newEmployee = new Employee(name, salary, position, department);

                if (employees.Length>4)
                {
                    if (employees[4].Contains("@"))
                    {
                        email = employees[4];
                        newEmployee.email = email;
                    }
                    else
                    {
                        age = int.Parse(employees[4]);
                        newEmployee.age = age;
                    }
                }

                if (employees.Length>5)
                {
                    age = int.Parse(employees[5]);
                    newEmployee.age = age;
                }

                listWithEmployees.Add(newEmployee);
            }
            var result = listWithEmployees.GroupBy(e => e.department)
                .Select(e => new
                {
                    Department = e.Key,
                    AvaregeSalary = e.Average(emp => emp.salary),
                    Employees = e.OrderByDescending(emp => emp.salary)
                }).FirstOrDefault();
            Console.WriteLine($"Highest Average Salary: {result.Department}");

            foreach (var emp in result.Employees)
            {
                Console.WriteLine($"{emp.name} {emp.salary:f2} {emp.email} {emp.age}");
            }
        }
    }
}
