using System;
using System.Collections.Generic;

namespace ExerciseOne
{
    class Program
    {
        public string ExerciseOneMethodOne()
        {
            Console.Write("Please enter a few numbers separated by a hyphen (e.g 4-9-7-52-8) : ");
            string inputStringNumbers = Console.ReadLine();
            List<int> numbers = new List<int>();
            foreach (string substring in inputStringNumbers.Split('-'))
            {
                numbers.Add(Convert.ToInt32(substring));
            }
            for (int i = 1; i < numbers.Count; i++)
            {
                if (Math.Abs(numbers[i] - numbers[i - 1]) != 1)
                {
                    return "Not Consecutive";
                }
            }
            return "Consecutive";
        }

        public void ExerciseOneMethodTwo()
        {
            Console.Write("Please enter a few numbers separated by a hyphen (e.g 4-9-7-52-8) : ");
            string inputStringNumbers = Console.ReadLine();
            List<int> numbers = new List<int>();
            string typeList = "Consecutive";
            foreach (string substring in inputStringNumbers.Split('-'))
            {
                numbers.Add(Convert.ToInt32(substring));
            }
            numbers.Sort();
            for (int i = 1 ; i < numbers.Count ; i++)
            {
                if (numbers[i] != (numbers[i-1] + 1))
                {
                    typeList = "Non Consecutive";
                    break;
                }
            }
            Console.WriteLine(typeList);


        }
    }
}
