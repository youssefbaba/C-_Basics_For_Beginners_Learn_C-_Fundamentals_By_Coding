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
            Console.WriteLine("########## Method One ###############");
            List<int> numbers  = new List<int>();
            while (numbers.Count < 5)
            {
                Console.Write("Please enter a number : ");
                int inputNumberOne = Convert.ToInt32(Console.ReadLine());
                if (numbers.Count == 0)
                {
                    numbers.Add(inputNumberOne);
                }
                else
                {
                    if (!numbers.Contains(inputNumberOne))
                    {
                        numbers.Add(inputNumberOne);
                    }
                    else
                    {
                        Console.WriteLine("You've previously entered {0} please re-try to enter a new number", inputNumberOne);
                    } 
                }
            }
            numbers.Sort();
            Console.Write("Sorted List Is : ");
            foreach (var number in numbers)
            {
                Console.Write("{0} ",number);
            }
            Console.WriteLine();


            Console.WriteLine("########## Method Two ###############");
            List<int> numbersTwo = new List<int>();
            while (numbersTwo.Count < 5)
            {
                Console.Write("Please enter a number : ");
                int inputNumberTwo = Convert.ToInt32(Console.ReadLine());
                if (numbersTwo.Contains(inputNumberTwo))
                {
                    Console.WriteLine("You've previously entered {0} please re-try to enter a new number,  ", inputNumberTwo);
                    continue;
                }
                numbersTwo.Add(inputNumberTwo);
            }
            numbers.Sort();
            Console.Write("Sorted List Is : ");
            foreach (var number in numbers)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
        }
    }
}
