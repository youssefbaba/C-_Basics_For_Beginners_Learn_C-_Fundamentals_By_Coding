using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTwo
{
    class Program
    {
        public void ExerciseTwo()
        {
            Console.WriteLine("######### Method One ##########");
            Console.Write("Please enter your name : ");
            string inputNameOne = Console.ReadLine();
            char[] arrayCharOne = new char[inputNameOne.Length];
            int j = 1;
            for (int i = 0; i < inputNameOne.Length; i++)
            {
                arrayCharOne[(inputNameOne.Length) - j] = inputNameOne[i];
                j++;
            }
            Console.WriteLine("Reversed name is : {0}" , new string(arrayCharOne));


            Console.WriteLine("######### Method Two ##########");
            Console.Write("Please enter your name : ");
            string inputNameTwo = Console.ReadLine();
            char[] arrayCharTwo = inputNameTwo.ToCharArray();
            Array.Reverse(arrayCharTwo);
            Console.WriteLine("Reversed name is : {0}", new string(arrayCharTwo));
        }
    }
}
