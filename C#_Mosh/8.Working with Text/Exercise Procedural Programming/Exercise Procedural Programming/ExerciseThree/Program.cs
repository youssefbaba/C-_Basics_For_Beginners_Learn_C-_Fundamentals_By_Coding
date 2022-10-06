using System;
using System.Collections.Generic;


namespace ExerciseThree
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter a time value in the 24-hour time format (eg 19:00) : ");
            string inputTime = Console.ReadLine();
            string status = (IsValidTime(inputTime)) ? "Valid Time" : "Invalid Time";
            Console.WriteLine(status);
        }
        public static bool IsValidTime(string time)
        {
            List<int> numbers = new List<int>();
            if (time.Split(':').Length != 2)
            {
                return false;
            }
            if (!String.IsNullOrWhiteSpace(time))
            {
                int index = time.IndexOf(':');
                int hour = Convert.ToInt32(time.Substring(0, index));
                int minute = Convert.ToInt32(time.Substring(index + 1));
                if ((hour >= 0 && hour <= 23) && (minute >= 0 && minute <= 59))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
