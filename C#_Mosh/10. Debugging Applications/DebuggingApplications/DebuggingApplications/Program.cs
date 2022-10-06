using System;
using System.Collections.Generic;

namespace DebuggingApplications
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 1, 2};
            List<int> smallests = GetSmallests(null, 1);
            foreach (int number in  smallests)
            {
                Console.WriteLine(number);
            }
        }
        public static List<int> GetSmallests(List<int> list , int count)
        {
            if (list == null)
            {
                throw new ArgumentNullException("list");
            }
            if (count > list.Count || count <= 0)
            {
                throw new ArgumentOutOfRangeException("count", "Count should be between 1 and number of the elments in the list .");
            }
            List<int> buffer = new List<int>(list); // 1 2 3 4 5 6
            List<int> smallests = new List<int>();
            while (smallests.Count < count )
            {
                int min = GetSmallest(buffer); 
                smallests.Add(min); 
                buffer.Remove(min); 
            }
            return smallests;
        }
        public static int GetSmallest(List<int> list)
        {
            // Assume the first number is the smallast
            int min = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                {
                    min = list[i];
                }
            }
            return min;
        }
    }
}

// breakpoints
// defensive programming
// watch window
// auto window and local window
// call stack 


