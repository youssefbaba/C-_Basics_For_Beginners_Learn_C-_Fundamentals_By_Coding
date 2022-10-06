using ClassLibraryCalculator; // Importation Of Class Library
using Namespace1.ChildNameSpace;
using System;
using System.Collections.Generic;
using Nst3 = NamespaceAliasAndFullyQualifiesNameTest3;
using Nst4 = NamespaceAliasAndFullyQualifiesNameTest4;


namespace NamespaceAliasAndFullyQualifiesNameTest2
{
    internal class Program
    {
        // - link2 : https://www.youtube.com/watch?v=x_SfUb4R5rc 
        // - link3 : https://www.youtube.com/watch?v=x_SfUb4R5rc&t=393s

        static void Main(string[] args) // Method Main represent entry point of code
        {
            //System.Console.WriteLine($"Hello Youssef"); // Fully Qualifies Name
            Console.WriteLine($"Hello Youssef");

            Quiz1 qz1 = new Quiz1();
            Quiz2 qz2 = new Quiz2();

            //NamespaceAliasAndFullyQualifiesNameTest3.Test test1 = new NamespaceAliasAndFullyQualifiesNameTest3.Test(); // Fully Qualifies Name
            //Console.WriteLine(test1.Add(2 , 3));
            //NamespaceAliasAndFullyQualifiesNameTest4.Test test2 = new NamespaceAliasAndFullyQualifiesNameTest4.Test(); // Fully Qualifie Name
            //Console.WriteLine(test2.Mult(2 , 3));
            //NamespaceAliasAndFullyQualifiesNameTest3.Test.Display(); // Fully Qualifies Name
            //NamespaceAliasAndFullyQualifiesNameTest4.Test.Display(); // Fully Qualifies Name

            Nst3.Test test1 = new Nst3.Test();
            Console.WriteLine(test1.Add(2, 3));
            Nst3.Test.Display();
            Nst4.Test test2 = new Nst4.Test();
            Console.WriteLine(test2.Mult(2, 3));
            Nst4.Test.Display();

            List<int> myList = new List<int> { 10, 20, 30, 40, 50, 60 };
            Nested1.PrintElementList(myList);
            Nested2.Print();

            Console.WriteLine(Calculator.Add(10.3, 10.2, 100));
            Console.WriteLine(Calculator.Mult(10.3, 10.2, 100));
        }
    }
    //internal class Quiz1
    //{
    //    // Some Code Here
    //}
    //internal class Quiz2
    //{
    //    // Some Code Here
    //}
}


