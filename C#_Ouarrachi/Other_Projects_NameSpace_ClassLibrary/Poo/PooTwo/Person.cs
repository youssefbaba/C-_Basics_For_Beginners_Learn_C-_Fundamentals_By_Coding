using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTwo
{
    internal class Person
    {
        private string name;
        private string address;
        private string phone;
        public bool isActive;

        // Getter and Setter
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private string PersonData()
        {
            return $"{name};{address};{phone}";
        }
        public string GetPersonData() 
        {
            return PersonData().Replace(";", "\n");
        }

        // Overloading One
        public string GetPersonData(string separator) 
        {
            return PersonData().Replace(";", separator);
        }

        // Overloading Two
        public string GetPersonData(string separator , string addition)
        {
            return String.Concat(PersonData().Replace(";", separator) , addition);
        }

        public void PrintPersonData()
        {
            Console.WriteLine(GetPersonData());
        }

        public virtual void DataType()
        {
            Console.WriteLine("Person");
        }

       

    }
}
