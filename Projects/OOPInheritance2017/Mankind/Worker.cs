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
        private int hoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int hoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.HoursPerDay = hoursPerDay;
        }

        public int HoursPerDay
        {
            get { return hoursPerDay; }
            set
            {
                if (value<1 || value>12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                hoursPerDay = value;
            }
        }


        public decimal WeekSalary
        {
            get { return weekSalary; }
            set
            {
                if (value<10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                weekSalary = value;
            }
        }

        private decimal MoneyPerHour()
        {
            return (weekSalary / 5) / hoursPerDay;
        }

        public override string ToString()
        {
            string result = $"First Name: {base.FirstName}\r\n" +
                            $"Last Name: {base.LastName}\r\n" +
                            $"Week Salary: {this.weekSalary:f2}\n\r"+
                            $"Hours per day: {this.hoursPerDay:f2}\r\n"+
                            $"Salary per hour: {MoneyPerHour():f2}";
            return result;
        }

    }
}
