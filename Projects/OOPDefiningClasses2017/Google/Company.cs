using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Company
    {
        private string name;
        private string department;
        private decimal salary;

        public Company(string name,string department,decimal salary)
        {

            this.Name = name;
            this.Department = department;
            this.Salary = salary;

        }

        public string Name { get => name; set => name = value; }
        public string Department { get => department; set => department = value; }
        public decimal Salary { get => salary; set => salary = value; }

        public override string ToString()
        {
            string result = $"{this.name} {this.department} {this.salary:f2}";
            return result;
        }
    }
}
