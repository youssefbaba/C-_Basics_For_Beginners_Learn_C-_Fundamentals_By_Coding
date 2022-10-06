using System;

namespace ObjectTypeGetTypeMethod
{
    public class MyBaseClass
    {

    }
    public class MyDerivedClass : MyBaseClass
    {

    }
    public class Person
    {

    }

    public class Program
    {
        static void Main(string[] args)
        {

            // Signature : public Type GetType ();
            // Gets the Type of the current instance.


            object ob = "hiho";
            Console.WriteLine(ob.GetType());
            Console.WriteLine(ob.GetType().Name);


            MyBaseClass myBaseOne = new MyBaseClass();
            MyDerivedClass myDerived = new MyDerivedClass();
            object obj = myDerived;
            MyBaseClass myBaseTwo = myDerived;

            Console.WriteLine($"myBaseOne : Type is {myBaseOne.GetType().Name}"); // myBaseOne : Type is MyBaseClass
            Console.WriteLine($"myDerived : Type is {myDerived.GetType().Name}"); // myDerived : Type is MyDerivedClass
            Console.WriteLine($"obj : Type is {obj.GetType().Name}"); // obj : Type is MyDerivedClass
            Console.WriteLine($"myBaseTwo : Type is {myBaseTwo.GetType().Name}"); // myBaseTwo : Type is MyDerivedClass



            int num1 = 10;
            int num2 = 12;
            Console.WriteLine(num1.GetType()); // System.Int32
            Console.WriteLine(num2.GetType()); // System.Int32
            Console.WriteLine($"{nameof(num1)} and {nameof(num2)} are the same type : {(Object.ReferenceEquals(num1.GetType(), num2.GetType()) ? "True" : "False")}");


            string str1 = "Hello";
            string str2 = "World";
            Console.WriteLine(str1.GetType().Name); // String
            Console.WriteLine(str2.GetType().Name); // String
            Console.WriteLine($"{nameof(str1)} and {nameof(str2)} are the same type : {(Object.ReferenceEquals(str1.GetType(), str2.GetType()) ? "True" : "False")}");


            Person person1 = new Person();
            Person person2 = new Person();
            Console.WriteLine(person1.GetType().Name); // Person
            Console.WriteLine(person2.GetType().Name); // Person
            Console.WriteLine($"{nameof(person1)} and {nameof(person2)} are the same type : {(Object.ReferenceEquals(person1.GetType(), person2.GetType()) ? "True" : "False")}");


            char n1 = 'e';
            char n2 = 'h';
            string n3 = "hiho";
            Console.WriteLine($"{nameof(n1)} and {nameof(n2)} are the same type:{Object.ReferenceEquals(n1.GetType(), n2.GetType())}");
            Console.WriteLine($"{nameof(n1)} and {nameof(n3)} are the same type:{Object.ReferenceEquals(n1.GetType(), n3.GetType())}");


            // Using the GetType method to determine the type of a particular object

            object[] values = new object[] { 12, (long)10653, (byte)12, (sbyte)-5, 16.3, "string" };

            foreach (var value in values)
            {
                Type type = value.GetType();
                if (type.Equals(typeof(int)))
                {
                    Console.WriteLine($"{value} is Signed 32-bit integer.");
                }
                else if (type.Equals(typeof(long)))
                {
                    Console.WriteLine($"{value} is Signed 64-bit integer.");
                }
                else if (type.Equals(typeof(byte)))
                {
                    Console.WriteLine($"{value} is Unsigned byte.");
                }
                else if (type.Equals(typeof(sbyte)))
                {
                    Console.WriteLine($"{value} is Signed byte.");
                }
                else if (type.Equals(typeof(double)))
                {
                    Console.WriteLine($"{value} is a double-precision floating point.");
                }
                else
                {
                    Console.WriteLine($"{value} is another data type.");
                }
            }
        }
    }
}
