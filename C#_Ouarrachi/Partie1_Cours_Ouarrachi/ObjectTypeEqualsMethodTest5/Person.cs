using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTypeEqualsMethodTest5
{
    internal class Person
    {
        private string firstName ;

        public Person(string firstName)
        {
            this.firstName = firstName;
        }
        public override string ToString()
        {
            return $"{this.firstName}";
        }
    }
}
