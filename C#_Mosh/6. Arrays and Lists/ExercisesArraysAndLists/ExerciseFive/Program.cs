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
            Console.WriteLine("############### Method One #############");
            List<int> numbers = new List<int>();
            while (true)
            {
                Console.Write("Please enter a list of comma separated numbers (e.g 5,1,9,2,10) : ");
                string input = Console.ReadLine();
                string[] substrings = input.Split(',');
                if (substrings.Length == 0 || substrings.Length < 5)
                {
                    Console.WriteLine("Invalid List");
                    continue;
                }
                foreach (string substring in substrings)
                {
                    numbers.Add(Convert.ToInt32(substring));
                }
                break;
            }
            numbers.Sort();
            Console.Write("The three smallest number in the list is : ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0} " ,numbers[i]);
            }
            Console.WriteLine();



            Console.WriteLine("############# Method Two ############");
            List<int> listNumbers = new List<int>();
            while (true)
            {
                Console.Write("Please enter a list of comma separated numbers (e.g 5,1,9,2,10) : ");
                string input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                {
                    string[] substrings = input.Split(',');
                    foreach (string substring in substrings)
                    {
                        listNumbers.Add(Convert.ToInt32(substring));
                    }
                    if (listNumbers.Count >= 5 )
                    {
                        break;
                    }
                    Console.WriteLine("Invalid List");
                    continue;
                }
            }
            listNumbers.Sort();
            Console.Write("The three smallest number in the list is : ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0} ", listNumbers[i]);
            }
            Console.WriteLine();
        }
    }
}
