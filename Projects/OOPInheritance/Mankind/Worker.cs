using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    class Worker : Human
    {
        private decimal weekSalary;
        private decimal workingHours;

        public Worker(string firstName, string lastName,decimal weekSalary, decimal workingHours) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkingHours = workingHours;
        }

        public decimal WeekSalary
        {
            get
            {
                return weekSalary;
            }

            private set
            {
                if (value<10)
                {
                    throw new ArgumentException($"Expected value mismatch!Argument: {nameof(this.weekSalary)}");
                }
                weekSalary = value;
            }
        }

        public decimal WorkingHours
        {
            get
            {
                return workingHours;
            }

            private set
            {
                if (value<1 || value>12)
                {
                    throw new ArgumentException($"Expected value mismatch!Argument: {nameof(this.workingHours)}");
                }
                workingHours = value;
            }
        }
        public override string ToString()
        {
            decimal avrSalary = (weekSalary / 7m) / workingHours;
            StringBuilder sb = new StringBuilder();
            sb.Append("First Name: ").Append(this.FirstName)
                .Append(Environment.NewLine)
                .Append("Last Name: ").Append(this.LastName)
                .Append(Environment.NewLine)
                .Append($"Week Salary: {weekSalary:f2}")
                .Append(Environment.NewLine)
                .Append($"Hours per day: {workingHours:f2}")
                .Append(Environment.NewLine)
                .Append($"Salary per hour: {avrSalary:f2}");
            return sb.ToString();
        }
    }
}
