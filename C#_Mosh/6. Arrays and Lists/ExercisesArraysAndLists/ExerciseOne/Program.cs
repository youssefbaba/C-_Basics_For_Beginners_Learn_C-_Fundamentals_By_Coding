using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOne
{
    class Program
    {
        public void ExerciseOne()
        {
            List<String> names = new List<String>();
            while (true)
            {
                Console.Write("Please type a name (or hit ENTER to quit): ");
                string input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                names.Add(input);
            }
            switch (names.Count)
            {
                case 0 :
                    Console.WriteLine("");
                    break;
                case 1:
                    Console.WriteLine("{0} likes your post" , names[0]);
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} like your post" , names[0], names[1]);
                    break;
            }
            if (names.Count >= 3)
            {
                Console.WriteLine("{0},{1} and {2} others like your post", names[0], names[1] , (names.Count)-2); 
            }
        }
    }
}
