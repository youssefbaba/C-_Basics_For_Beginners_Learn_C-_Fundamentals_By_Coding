using System;
using System.Collections.Generic;

namespace ExerciseOne
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter a few numbers separated by a hyphen (e.g 4-9-7-52-8) : ");
            string inputStringNumbers = Console.ReadLine();
            string status = (IsConsecutive(inputStringNumbers)) ? "Consecutive" : "Non Consecutive";
            Console.WriteLine(status);
        }
        public static bool IsConsecutive(string stringNumbers)
        {
            List<int> numbers = new List<int>();
            foreach (string substring in stringNumbers.Split('-'))
            {
                numbers.Add(Convert.ToInt32(substring));
            }
            numbers.Sort();
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != (numbers[i - 1] + 1))
                {
                    return  false; // "Non Consecutive"
                }
            }
            return true; // "Consecutive"
        }
    }
}
