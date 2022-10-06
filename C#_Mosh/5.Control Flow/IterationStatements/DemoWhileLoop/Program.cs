using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWhileLoop
{
    class Program
    {
        static void Main()
        {
            int i = 1;
            while (i <= 10)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.WriteLine("############### Reverse Order #################");
            int j = 10;
            while (j >= 1 )
            {
                if ((j % 2) == 0)
                {
                    Console.WriteLine(j);
                }
                j--;
            }
            //Console.WriteLine("############### Example One #################");

            //while (true)
            //{
            //    Console.Write("Please Type Your Name :");
            //    string InputNameOne = Console.ReadLine();
            //    if (String.IsNullOrWhiteSpace(InputNameOne))
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Echo : {0}" , InputNameOne);
            //    }
            //}
            Console.WriteLine("############### Example Two #################");

            while (true)
            {
                Console.Write("Please Type Your Name :");
                string InputNameTwo = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(InputNameTwo))
                {
                    Console.WriteLine("Echo : {0}" , InputNameTwo);
                    continue;
                }
                break;
                
            }
        }
    }
}
