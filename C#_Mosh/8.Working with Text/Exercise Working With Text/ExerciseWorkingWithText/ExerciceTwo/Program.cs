using System;
using System.Collections.Generic;
namespace ExerciceTwo
{
    class Program
    {
        public void ExerciseTwoMethodOne()
        {
            Console.Write("Please enter a few numbers separated by a hyphen (eg 5-6-9-8-4) : ");
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            bool isDuplicate = false;
            if (String.IsNullOrWhiteSpace(input))
            {
                return;
            }
            foreach (string substring in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(substring));
            }

            numbers.Sort();
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    isDuplicate = true;

                }
            }

            string status = (isDuplicate) ? "Duplicate" : "Unique";
            Console.WriteLine(status);
        }

        public void ExerciseTwoMethodTwo()
        {
            Console.Write("Please enter a few numbers separated by a hyphen (eg 5-6-9-8-4) : ");
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            List<int> uniqueNumbers = new List<int>();
            if (!String.IsNullOrWhiteSpace(input))
            {
                foreach (string substring in input.Split('-'))
                {
                    numbers.Add(Convert.ToInt32(substring));
                }
                foreach (int number in  numbers)
                {
                    if (!uniqueNumbers.Contains(number))
                    {
                        uniqueNumbers.Add(number);
                    }
                    else
                    {
                        Console.WriteLine("Duplicate");
                        break;
                    }
                }
            }            
        }
    }
}
