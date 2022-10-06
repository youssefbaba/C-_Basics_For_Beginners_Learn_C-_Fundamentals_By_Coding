using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFive
{
    class Program
    {
        public void ExerciseFive()
        {
            Console.Write("Please enter a series of numbers separated by comma like this (100,2,4,...) : ");
            string input =  Console.ReadLine();
            int[] numbers = Array.ConvertAll(input.Split(','), int.Parse);
            int max = 0;
            foreach (int number  in numbers)
            {
                if (number >= max)
                {
                    max = number;
                }
            }
            Console.WriteLine("Max is : {0} " , max);



        }
    }
}
