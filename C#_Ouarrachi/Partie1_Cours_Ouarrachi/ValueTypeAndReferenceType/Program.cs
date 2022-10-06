using System;

namespace ValueTypeAndReferenceType
{

    // value type and refrence type :
    // - link1 : https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types
    // - link2 : https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types
    // - link3 : https://www.youtube.com/watch?v=mvieNUe9Urs&t=1s
    // - link4 : https://www.youtube.com/watch?v=dYxT5NOoQlQ&t=329s

    /*
     - Value types are fixed size like integer require 32bits of memory , generally stored in stack but not always and passed by copying .
        - integer numbers , real numbers , bool , char . Date
        - custom enum .
        - custom struct .
     - Reference types are variable size , always stored in heap and passed by reference.
        - string , object , custom classes , delegates  , arrays , custom inteface . 
     */
    public class A
    {
        public int Value { get; set; }
        public A() { }
        public A(int passbyref)
        {
            this.Value = passbyref;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A obj1 = new A(12);
            Console.WriteLine(obj1.Value); // 12
            int value1 = 12;
            int value2 = 22;
            value2 = value1;
            Console.WriteLine($"the value in value1 : {value1}"); // the value in value1 : 12
            Console.WriteLine($"the value in value2 : {value2}"); // the value in value2 : 12


            A obj2 = new A(12);
            A obj3 = new A(22);
            obj3 = obj2;
            Console.WriteLine(obj2.Value); // 12
            Console.WriteLine(obj3.Value); // 12


            // Passing Arguments


            A obj4 = new A();
            obj4.Value = 10;
            MethodToShowRef(obj4);
            Console.WriteLine(obj4.Value); // 10


            A obj5 = new A();
            obj5.Value = 10;
            MethodToShowRefOne(ref obj5);
            Console.WriteLine(obj5.Value); // 0

            try
            {
                A obj6 = new A();
                obj6.Value = 10;
                MethodToShowRefTwo(obj6);
                Console.WriteLine(obj6.Value); // 10
            }
            catch (NullReferenceException exp)
            {
                Console.WriteLine(exp.Message);
            }


            try
            {
                A obj7 = new A();
                obj7.Value = 20;
                MethodToShowRefThree(ref obj7);
                Console.WriteLine(obj7.Value); // Throw Exception
            }
            catch (NullReferenceException exp)
            {
                Console.WriteLine(exp.Message);
            }

            CreateObjects();
            int x = 1; // x is value type declared as variable in method so is stored on stack



        }
        public static void MethodToShowRef(A obj)
        {
            obj = new A();
        }
        public static void MethodToShowRefOne(ref A obj)
        {
            obj = new A();
        }
        public static void MethodToShowRefTwo(A obj)
        {
            obj = null;
        }
        public static void MethodToShowRefThree(ref A obj)
        {
            obj = null;
        }

        public static void CreateObjects()
        {
            Point p1 = new Point { X = 4, Y = 5 }; // p1 is value type declared as variable in method so is stored on stack , and then thier members ( X and Y) are stored also in stack
            Point p2 = new Point { X = 5, Y = 5 }; // p2 is value type declared as variable in method so is stored on stack , and then thier members ( X and Y) are stored also in stack
            Point p3 = p1;


            Person fred = new Person { Name = "Fred" }; // fred is reference type so is stored in heap also its member (Name) also stored in heap

            Console.WriteLine(fred.Name); // Fred
            Console.WriteLine(p1.X); // 4
            Console.WriteLine(p3); // (4 , 5)
            p1.X++;
            Console.WriteLine(p3); // (4 , 5)

            ProcessPerson(fred);
            Console.WriteLine(fred.Name); // Barney

            ProcessPoint(p1);
            Console.WriteLine(p1);//(5 , 5)

            Person youssef = fred;
            Console.WriteLine(youssef);  // Barney
            youssef.Name = "Youssef";
            Console.WriteLine(fred); // Youssef
            Console.WriteLine(youssef); // Youssef


            Person omar = new Person { Name = "Omar" };
            Person mohamed = omar;
            Person hassna = new Person { Name = "Hassna" };
            Console.WriteLine(mohamed == omar ? "Equal" : "Not Equal");  // Equal : check for reference equality
            Console.WriteLine(hassna == omar ? "Equal" : "Not Equal");  // Not Equal : check for reference equality
            Console.WriteLine(mohamed.Equals(omar) ? "Equal" : "Not Equal"); // Equal : check for value equality
            Console.WriteLine(hassna.Equals(omar) ? "Equal" : "Not Equal"); // Not Equal : check for value equality


            Point p4 = new Point { X = 6, Y = 7 };
            Point p5 = new Point { X = 6, Y = 7 };
            Point p6 = new Point { X = 5, Y = 3 };
            Console.WriteLine(p4 == p5 ? "Equal" : "Not Equal"); // Equal
            Console.WriteLine(p5 == p6 ? "Equal" : "Not Equal"); // Not Equal




        }

        public static void ProcessPerson(Person p)
        {
            p.Name = "Barney";
        }

        public static void ProcessPoint(Point p)
        {
            p.X++;
            Console.WriteLine(p); //(6 , 5)
        }


    }
}
