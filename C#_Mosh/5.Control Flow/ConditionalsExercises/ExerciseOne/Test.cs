using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeciseOne
{
    class Test
    {
        static void Main()
        {
            Console.WriteLine("Please Enter A Number Between 1 to 10 .");
            string input = Console.ReadLine();
            int number = Int32.Parse(input);
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
