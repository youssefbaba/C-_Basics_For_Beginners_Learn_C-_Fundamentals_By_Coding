using System;
using System.Collections.Generic;

namespace ExerciseTwo
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter a few numbers separated by a hyphen (eg 5-6-9-8-4) : ");
            string input = Console.ReadLine();
            if (IsDuplicate(input))
            {
                Console.WriteLine("Duplicate");
            }
        }
        public static bool IsDuplicate(string stringNumbers)
        {
            List<int> numbers = new List<int>();
            List<int> uniqueNumbers = new List<int>();
            
            if (!String.IsNullOrWhiteSpace(stringNumbers))
            {
                foreach (string substring in stringNumbers.Split('-'))
                {
                    numbers.Add(Convert.ToInt32(substring));
                }
                foreach (int number in numbers)
                {
                    if (!uniqueNumbers.Contains(number))
                    {
                        uniqueNumbers.Add(number);
                    }
                }
                if (numbers.Count != uniqueNumbers.Count)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
