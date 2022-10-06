using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTwo
{
    class Program
    {
        public void ExerciseTwo()
        {
            float sum = 0;  
            while (true)
            {
                Console.Write("Please enter a number : ");
                string input = Console.ReadLine();

                if (input.ToLower() == "ok")
                {
                    break;
                }
                else
                {
                    sum += Convert.ToSingle(input);
                }
                
            }
            Console.WriteLine(" the sum of all the previously entered numbers is : {0}", sum);
        }
    }
}
