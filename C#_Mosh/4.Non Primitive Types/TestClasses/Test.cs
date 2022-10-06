using System;
using TestClasses.Math;
namespace TestClasses
{
    class Test
    {
        public static void Main()
        {
            Person personOne = new Person()
            {
                FirstName = "Youssef",
                LastName = "Baba"
            };
            personOne.Introduce();

            Calculator calculator = new Calculator();
            int resultAdd =  calculator.Add(2 , 3);
            Console.WriteLine(resultAdd);

            int resultMulti = Calculator.Multi(2 , 4) ;
            Console.WriteLine(resultMulti);
        }
    }
}
