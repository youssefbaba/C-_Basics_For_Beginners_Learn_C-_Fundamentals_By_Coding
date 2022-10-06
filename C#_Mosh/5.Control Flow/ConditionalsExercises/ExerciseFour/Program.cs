using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The Speed Limit .");
            string inputOne = Console.ReadLine();
            int SpeedLimit = Convert.ToInt32(inputOne);
            Console.WriteLine("Please Enter The Speed Of Car .");
            string inputTwo = Console.ReadLine();
            int SpeedCar = Convert.ToInt32(inputTwo);
            if (SpeedCar < SpeedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int DemeritPoints = ( SpeedCar - SpeedLimit ) / 5;
                if (DemeritPoints < 12)
                {
                    Console.WriteLine("Demerit Points = {0}", DemeritPoints);
                }
                else
                {
                    Console.WriteLine("License Suspended");
                }
            }

        }
    }
}
