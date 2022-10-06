using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoArrays
{
    class Program
    {
        public void Test()
        {
            int[] numbers = new int[] { 5, 7, 45, 12, 10, 4 };

            // Length
            Console.WriteLine("Length : {0}", numbers.Length);


            // IndexOf()
            int index = Array.IndexOf(numbers, 10);
            Console.WriteLine("Index of 10 is {0}", index);


            // Clear()
            Console.WriteLine("Effect Of Clear() : ");
            Array.Clear(numbers, 0, 3);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Copy()
            Console.WriteLine("Effect Of Copy() : ");
            int[] anotherArray = new int[4];
            Array.Copy(numbers, anotherArray, 4);
            foreach (int number in anotherArray)
            {
                Console.WriteLine(number);
            }

            // Sort()
            Console.WriteLine("Effect Of Sort() : ");
            Array.Sort(numbers);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }


            //Reverse()
            Console.WriteLine("Effect Of Reverse() : ");
            Array.Reverse(numbers);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }


        }  

    }
}
