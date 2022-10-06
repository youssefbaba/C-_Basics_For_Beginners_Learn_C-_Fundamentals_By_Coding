using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLists
{
    class Program
    {
        public void Test()
        {
            var numbers = new List<int>() { 1, 2, 3, 4};
            numbers.Add(300);
            numbers.AddRange(new int[3] { 100, 200, 300});
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            int indexFirst =  numbers.IndexOf(300);
            Console.WriteLine("The First Index Of 300 is {0}", indexFirst);
            int indexLast = numbers.LastIndexOf(300);
            Console.WriteLine("The Last Index Of 300 is {0}" ,indexLast);
            int numberOfElement = numbers.Count;
            Console.WriteLine("The Number Of Elements is {0}",numberOfElement);
            for (int i = 0; i < numbers.Count ; i++)
            {
                if (numbers[i] == 300)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Clear();
            Console.WriteLine("The Number Of Elements is {0}", numbers.Count);
        }
    }
}
