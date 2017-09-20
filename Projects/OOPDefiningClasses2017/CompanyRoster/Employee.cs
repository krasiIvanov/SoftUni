using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyRoster
{
    public class Employee
    {

        private string name;
        private decimal salary;
        private string position;
        private string department;
        private string email;
        private int age;

        

        public Employee(string name,decimal salary,string position,string department,string email,int age)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Email = email;
            this.Age = age;

        }
        public Employee(string name,decimal salary,string position,string department):this(name,salary,position,department,"n/a",-1)
        {

        }
        public Employee(string name, decimal salary, string position, string department,string email) : this(name, salary, position, department, email, -1)
        {

        }
        public Employee(string name, decimal salary, string position, string department,int age) : this(name, salary, position, department, "n/a", age)
        {

        }

        public string Name { get => name; set => name = value; }
        public decimal Salary { get => salary; set => salary = value; }
        public string Position { get => position; set => position = value; }
        public string Department { get => department; set => department = value; }
        public string Email { get => email; set => email = value; }
        public int Age { get => age; set => age = value; }

        public override string ToString()
        {
            string result = $"{this.Name} {this.Salary} {this.Email} {this.Age}";
            return result;
        }

    }
}
