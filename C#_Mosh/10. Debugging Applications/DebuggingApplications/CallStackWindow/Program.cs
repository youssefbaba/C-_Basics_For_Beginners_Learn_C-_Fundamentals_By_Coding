using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallStackWindow
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6};
            List<int> smallests = GetSmallests(numbers, 3);
            foreach (int number in smallests)
            {
                Console.WriteLine(number);
            }
        }
        public static List<int> GetSmallests(List<int> list, int count)
        {
            if (count > list.Count)
            {
                throw new ArgumentOutOfRangeException("count", "Count cannot be greater than the number of the element list.");
            }
            List<int> buffer = new List<int>(list);
            List<int> smallests = new List<int>();
            while (smallests.Count < count)
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
