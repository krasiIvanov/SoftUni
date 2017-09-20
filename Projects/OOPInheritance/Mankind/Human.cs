using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    class Human
    {

        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;

        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                char firstLatter=value[0];
                if (!char.IsUpper(firstLatter))
                {
                    throw new ArgumentException($"Expected upper case letter!Argument: {nameof(this.firstName)}");
                }
                if (value.Count()<4)
                {
                    throw new ArgumentException($"Expected length at least 4 symbols!Argument: {nameof(this.firstName)}");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                char firstLatter = value[0];
                if (!char.IsUpper(firstLatter))
                {
                    throw new ArgumentException($"Expected upper case letter!Argument: {nameof(this.lastName)}");
                }
                if (value.Count() < 4)
                {
                    throw new ArgumentException($"Expected length at least 4 symbols!Argument: {nameof(this.lastName)}");
                }
                this.lastName = value;
            }
            
        }

    }
}
