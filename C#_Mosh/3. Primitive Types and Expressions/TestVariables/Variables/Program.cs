using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {


            const float Pi = 3.14f;

            byte number = 2;
            int count = 10;
            float totalPrice = 90.95f;
            char character = 'A';
            string firstName = "youssef";
            bool isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(Pi);

            // use var instead of specific type 

            var numberTwo = 3;
            var amount = 25;
            var totalWeight = 102.5f;
            var singleCharacter = 'B';
            var lastName = "Baba";
            var isretired = false;

            Console.WriteLine(numberTwo);
            Console.WriteLine(amount);
            Console.WriteLine(totalWeight);
            Console.WriteLine(singleCharacter);
            Console.WriteLine(lastName);
            Console.WriteLine(isretired);


            // Simple Example
            Console.WriteLine("{0}  {1}" , byte.MinValue , byte.MaxValue);
            Console.WriteLine("{0}  {1}", float.MinValue, float.MaxValue);


        }
    }
}
