using System;
using NS1 = ConsoleApp2; // alias for  namespace
using NS2 = ConsoleApp3; // alias for namespace
using NS3.ConsoleApp1;
using Calculators;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) // entry point
        {
            NS1.Quiz.DisplayOne();
            NS2.Qiuz.DisplayOne();
            Console.WriteLine(Quiz.Note);
            Console.WriteLine(Calculator.Addition(10, 4));
            Console.WriteLine(Calculator.Multiplication(10, 4));
        }
    }
}