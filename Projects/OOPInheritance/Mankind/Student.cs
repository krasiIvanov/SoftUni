using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    class Student : Human
    {
        private string facNumber;

        public Student(string firstName, string lastName,string facNumber) 
            : base(firstName, lastName)
        {
            this.FacNumber = facNumber;
        }

        public string FacNumber
        {
            get
            {
                return facNumber;
            }

            private set
            {
                if (value.Count()<5 || value.Count()>15)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                facNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("First Name: ").Append(this.FirstName)
                .Append(Environment.NewLine)
                .Append("Last Name: ").Append(this.LastName)
                .Append(Environment.NewLine)
                .Append("Faculty number: ").Append(this.facNumber)
                .Append(Environment.NewLine);


            return sb.ToString();
        }
    }
}
