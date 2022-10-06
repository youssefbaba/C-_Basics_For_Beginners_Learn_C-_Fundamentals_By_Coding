using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTypeEqualsMethodTest7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Youssef" ,"Baba");
            Person person2 = new Person("Youssef" , "Baba");
            Console.WriteLine($"Calling Equals");
            Console.WriteLine($"{person1.Equals(person2)}"); // True
            Console.WriteLine(person1.lastName.Equals(person2.lastName)); // True
            
        }
    }
}
