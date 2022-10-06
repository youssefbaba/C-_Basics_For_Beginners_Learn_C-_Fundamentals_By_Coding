using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseThree
{
    class Test
    {
        public enum ImageOrientation
        {
            Landscape,
            Portrait,
            Square
        }
        static void Main()
        {
            Console.WriteLine("Please Enter The Width Of Image .");
            string InputOne = Console.ReadLine();
            int width = Convert.ToInt32(InputOne);
            Console.WriteLine("Please Enter The Height Of Image .");
            string InputTwo = Console.ReadLine();
            int height = Convert.ToInt32(InputTwo);
            if (width > height)
            {
                Console.WriteLine("The Image Is {0} .", ImageOrientation.Landscape);
            }

            else if(width < height)
            {
                Console.WriteLine("The Image Is {0} .",ImageOrientation.Portrait);
            }
            else
            {
                Console.WriteLine("The Image Is {0} .",ImageOrientation.Square);
            }
        }
    }
}
