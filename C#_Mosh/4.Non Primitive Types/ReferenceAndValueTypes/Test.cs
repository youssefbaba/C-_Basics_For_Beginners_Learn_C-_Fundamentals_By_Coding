using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueTypes
{
    class Test
    {
        /*
         - Value Types : - Structures
                            - Primitives Types : byte , short , int , long , float , double , decimal , bool , char .
                            - Custom Structures .


         - Reference Types : - Classes
                                - Custom Classes , Arrays , String . 
          
         */
        /*
         - Value Types : - Allocated on stack(part of memory) .
                         - Memory allocation done automatically .
                         - Immediately removed when out of scope .

         - Reference Types : - You need to allocate on memory  (use new operator).
                             - Memory allocated on heap (part of memory)  .
                             - Garbage Collected by CLR (removed the objects from heaps) .
         
         */
        static void Main(string[] args)
        {
            int numberOne = 10;
            int numberTwo = numberOne;
            numberTwo++;
            Console.WriteLine("numberOne = {0} , numberTwo = {1}" , numberOne , numberTwo) ;


            int[] arrayOne = new int[3]{ 1 , 2 , 3};
            int[] arrayTwo = arrayOne;
            arrayTwo[0] = 5;
            Console.WriteLine("arrayOne[0] = {0} , arrayTwo[0] = {1}" , arrayOne[0], arrayTwo[0]);

            int number = 1;
            Person.Increment(number);
            Console.WriteLine(number);

            Person personOne = new Person() {
                Age = 20 
            };
            Person.MakeOld(personOne); // Age = 30
            Console.WriteLine(personOne.Age);

        }
    }
}
