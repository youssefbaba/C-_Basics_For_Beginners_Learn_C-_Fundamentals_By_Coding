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
            int counter = 0;
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3) == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", counter);
        }
    }
}
