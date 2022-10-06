using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Function.Addition(10,4));
            Console.WriteLine(Function.Substraction(10,4));
            Console.WriteLine(Function.Multiplication(2, 5));
            Console.WriteLine(Function.Division(2, 5));
        }
    }
}
