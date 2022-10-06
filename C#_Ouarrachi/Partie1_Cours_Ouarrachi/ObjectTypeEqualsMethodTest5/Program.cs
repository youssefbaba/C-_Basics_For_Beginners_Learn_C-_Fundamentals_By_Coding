using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTypeEqualsMethodTest5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // by default Equals(object) method tests for reference equality if the current object is reference type.
            // person1a and person2 have the same value and same reference
            // person2 and person1a have the same value but not the same reference
            Person person1a = new Person("Youssef");
            Person person1b = person1a;
            Person person2 = new Person(person1a.ToString());



            Console.WriteLine("Calling Equals:");
            Console.WriteLine($"person1a and person1b: {person1a.Equals(person1b)}"); // person1a and person1b: True
            Console.WriteLine($"person1a and person2: {person1a.Equals(person2)}"); // person1a and person2: False


            Console.WriteLine("\nCasting to an Object and calling Equals:");
            Console.WriteLine($"person1a and person1b: {((object)person1a).Equals((object)person1b)}"); // person1a and person1b: True
            Console.WriteLine($"person1a and person2: {((object)person1a).Equals((object)person2)}"); // person1a and person2: False
        }
    }
}
