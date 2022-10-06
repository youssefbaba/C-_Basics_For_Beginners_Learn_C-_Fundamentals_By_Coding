using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFour
{
    class Program
    {
        public void ExerciseFour()
        {
            Console.WriteLine("############# Method One ##############");
            List<int> numbers = new List<int>();
            while (true)
            {
                Console.Write("Please enter a number or type 'Quit' to exit : ");
                string input = Console.ReadLine();
                if (char.ToUpper(input[0]) + input.Substring(1) == "Quit")
                {
                    break;
                }
                if (numbers.Contains(Convert.ToInt32(input)))
                {
                    continue;
                }
                numbers.Add(Convert.ToInt32(input));
            }

            Console.Write("Unique numbers : ");
            foreach (int number in numbers)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();



            Console.WriteLine("############# Method Two ################");
            List<int> listNumbers = new List<int>();
            while (true)
            {
                Console.Write("Please enter a number or type 'Quit' to exit : ");
                string input = Console.ReadLine();
                if (char.ToUpper(input[0]) + input.Substring(1) == "Quit")
                {
                    break;
                }
                listNumbers.Add(Convert.ToInt32(input));
            }
            List<int> newListNumbers = new List<int>();
            foreach (int number in listNumbers)
            {
                if (!newListNumbers.Contains(number))
                {
                    newListNumbers.Add(number);
                }
            }
            Console.Write("Unique Numbers : ");
            foreach (int number in newListNumbers)
            {
                Console.Write("{0} ",number);
            }
            Console.WriteLine();
        }
    }
}
