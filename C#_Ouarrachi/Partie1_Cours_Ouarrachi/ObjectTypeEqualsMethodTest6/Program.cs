using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTypeEqualsMethodTest6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte value1 = 12;
            int value2 = 12;
            object object1 = value1;
            object object2 = value2;


            Console.WriteLine(object1.GetType().Name); // Byte
            Console.WriteLine(object2.GetType().Name); // Int32
            Console.WriteLine(value1.Equals(value2)); // False
            Console.WriteLine(object1.Equals(object2)); // False


            int amount1 = 10;
            int amount2 = 10;
            object obj1 = amount1;
            object obj2 = amount2;


            Console.WriteLine(amount1.Equals(amount2)); // True
            Console.WriteLine(obj1.Equals(obj2)); // True


        }
    }
}
