using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForeachLoop
{
    class Program
    {
        static void Main()
        {
            string Name = "Youssef Baba";
            for (int i = 0; i < Name.Length; i++)
            {
                if (!Char.IsWhiteSpace(Name[i]))
                {
                    Console.WriteLine(Name[i]);
                }
            }
            Console.WriteLine("############# Using Foreach Loop ################");
            foreach (char character in Name)
            {
                if (!Char.IsWhiteSpace(character))
                {
                    Console.WriteLine(character);
                }
            }
            Console.WriteLine("########### Using Array For numbers ################");
            int[] numbers = new int[] { 15 , 4 , 98 , 35 , 8 };
            foreach (int number in numbers)
            {
                if ((number % 2) == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
