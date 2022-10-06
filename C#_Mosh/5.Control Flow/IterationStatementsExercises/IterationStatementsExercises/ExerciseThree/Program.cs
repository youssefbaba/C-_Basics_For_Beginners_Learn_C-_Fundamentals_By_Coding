using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseThree
{
    class Program
    {
        public void ExerciseThree()
        {
            Console.Write("Please Enter a number : ");
            int input = Convert.ToInt32(Console.ReadLine());
            int  factorial = 1;
            for (int i = 1 ; i <= input ; i++)
            {
                factorial *= i; 
            }
            if (input == 0)
            {
                Console.WriteLine(input);
            }
            Console.WriteLine("{0}! = {1}", input, factorial);


        }
    }
}
