using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    class Student : Human
    {
        private string facultyNumber;


        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (value.Length<5 || value.Length>10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }
        public override string ToString()
        {
            //            First Name: Stefo
            //            Last Name: Mk321
            //            Faculty number: 0812111

            string result = $"First Name: {base.FirstName}\r\n"+
                            $"Last Name: {base.LastName}\r\n"+
                            $"Faculty number: {this.facultyNumber}";
            return result;
        }
    }
}
