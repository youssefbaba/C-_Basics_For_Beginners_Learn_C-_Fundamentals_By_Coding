using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFour
{
    class Program
    {
        public void ExerciseFour()
        {
            Random random = new Random();
            int number = random.Next(1 , 10);
            Console.WriteLine("The Secret is : {0}" , number);
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Please Try To Guess The Secret Number : ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (number == input)
                {
                    Console.WriteLine("You won");
                    return;
                }
            }
            Console.WriteLine("You lost");
        }
    }
}
