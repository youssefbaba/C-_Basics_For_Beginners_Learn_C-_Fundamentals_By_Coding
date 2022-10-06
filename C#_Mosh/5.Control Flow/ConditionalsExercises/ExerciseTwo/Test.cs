using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTwo
{
    class Test
    {
        static void Main()
        {
            Console.WriteLine("Please Enter A Number (Number One) : ");
            string inputOne = Console.ReadLine();
            int numberOne = Int32.Parse(inputOne);
            Console.WriteLine("Please Enter A Number (Number Two) : ");
            string inputTwo = Console.ReadLine();
            int numberTwo = Int32.Parse(inputTwo);
            int max = (numberOne >= numberTwo) ? numberOne : numberTwo;
            Console.WriteLine("The Max Between is {0} and {1} is {2}", numberOne, numberTwo,max);
        }
    }
}
