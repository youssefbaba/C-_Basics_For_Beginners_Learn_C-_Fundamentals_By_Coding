using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Function
    {
       public static double Addition(double numberOne , double numverTwo)
       {
            return numberOne + numverTwo;   
       }
        public static double Substraction(double numberOne, double numverTwo)
        {
            return numberOne - numverTwo;
        }
        public static double Multiplication(double numberOne, double numverTwo)
        {
            return numberOne * numverTwo;
        }
        public static double Division(double numberOne, double numverTwo)
        {
            return numberOne / numverTwo;
        }
    }
}
