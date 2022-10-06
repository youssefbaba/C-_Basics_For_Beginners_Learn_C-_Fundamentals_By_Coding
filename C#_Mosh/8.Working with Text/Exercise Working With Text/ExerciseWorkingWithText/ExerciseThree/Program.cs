using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseThree
{
    class Program
    {
       public void ExerciseThreeMethodOne()
        {
            Console.Write("Please enter a time value in the 24-hour time format (e.g. 19:00) : ");
            string inputTime = Console.ReadLine();
            List<int> numbers = new List<int>();
            if (!String.IsNullOrWhiteSpace(inputTime))
            {
                foreach (string substring in inputTime.Split(':'))
                {
                    numbers.Add(Convert.ToInt32(substring));
                }
                if ((numbers[0] >= 0 && numbers[0] <= 23) && (numbers[1] >= 0 && numbers[1] <= 59))
                {
                    Console.WriteLine("Ok");
                    return;
                }
            }
            Console.WriteLine("Invalid Time");
        }
        public void ExerciseThreeMethodTwo()
        {
            Console.Write("Please enter a time value in the 24-hour time format (e.g. 19:00) : ");
            string inputTime = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(inputTime))
            {
                int index = inputTime.IndexOf(':');
                int hour = Convert.ToInt32(inputTime.Substring(0, index));
                int minute = Convert.ToInt32(inputTime.Substring(index + 1));
                if ((hour >= 0 && hour <= 23) && (minute >= 0 && minute <= 59))
                {
                    Console.WriteLine("Ok");
                    return;
                }
            }
            Console.WriteLine("Invalid Time");
        }
    }
}
