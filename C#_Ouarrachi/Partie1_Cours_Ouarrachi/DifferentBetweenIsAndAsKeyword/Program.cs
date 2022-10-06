using System;
using System.Collections.Generic;

namespace DifferentBetweenIsAndAsKeyword
{
    public struct Product
    {

    }
    public enum Level
    {
        Low,
        Medium,
        High
    }

    interface IName
    {
        string Name { get; set; }
    }

    class Employee : IName
    {
        public string Name { get; set; }
    }

    public class TutPoint
    {
        public String Name { get; set; }
        public TutPoint()
        {
            Console.WriteLine($"Hello TutPoint");
        }
    }
    public class Tutlover
    {
        public String Name { get; set; }
        public Tutlover()
        {
            Console.WriteLine($"Hello TutLover");
        }
    }
    internal class Program
    {
        static void Main()
        {
            /*
             - At compile-time, the variable (formFieldValue) is of type object - which is why string.IsNullOrWhitespace(formFieldValue) fails to compile.
             - At execution-time the value of the variable (formFieldValue) is a reference to a string. 
             - When you call GetType, you receive the actual type of what is contained in o (which is a string). Similarly, is keyword looks at the actual type.
             - But o itself (not the value contained within!) is still an object, and thus the compiler enforces it as such.
             */


            string str1 = "";
            object formFieldValue = str1;
            Console.WriteLine(formFieldValue.GetType() == typeof(string)); // => true : 
            //Console.WriteLine(string.IsNullOrWhiteSpace(formFieldValue));  // => error CS1503: Argument 1: cannot convert from 'object' to 'string'
            Console.WriteLine(string.IsNullOrWhiteSpace((string)formFieldValue));  // => True
            Console.WriteLine(formFieldValue.GetType()); // => System.String
            Console.WriteLine(formFieldValue == string.Empty);  // =>  True : check for value equality
            Console.WriteLine((string)formFieldValue == string.Empty);  // => True : check for value equality
            Console.WriteLine(formFieldValue == ""); // =>  True : check for value equality
            Console.WriteLine((string)formFieldValue == ""); // =>  True : chack for value equality
            Console.WriteLine(formFieldValue.Equals("")); // => True : check for reference equality (string interned)


            // as operator : 
            // - link1 : https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#as-operator
            // - link3 : https://www.c-sharpcorner.com/uploadfile/mahesh/as-operator-in-C-Sharp/
            /*
             - syntax : Expression as Type  =   Expression is Type ? (Type)Expression : (Type)null
             - 'as' is a keyword used for explicitly converts the result of an expression to a given reference or nullable value type .
             - The as operator explicitly converts the result of an expression to a given reference or nullable value type. In case of the conversion is possible ,
                it will return the value of the new object type else if the conversion isn't possible,
                 the as operator returns null. Unlike a cast expression, the as operator never throws an exception.
             - We cannot perform conversion of value types (int, double, char, bool) and user-defined types (custom struct , custom enum).
             
             */


            string string1 = "Youssef";
            object object1 = string1;
            string string2 = object1 as string;
            if (string2 != null)
            {
                Console.WriteLine($"Successfully Cast");
            }
            else
            {
                Console.WriteLine($"Not Successful");
            }

            //List<string> myList = (List<string>)object1; // Throw Exception

            List<string> myList = object1 as List<string>;
            if (myList != null)
            {
                Console.WriteLine($"Successfully Cast");
            }
            else
            {
                Console.WriteLine($"Not Successful");
            }


            List<string> firstNames = new List<string> { "youssef", "hassna" };
            object object2 = firstNames;
            List<string> lastNames = object2 as List<string>;
            if (lastNames != null)
            {
                Console.WriteLine($"Successfully Cast");
            }
            else
            {
                Console.WriteLine($"Not Successful");
            }

            Person p1 = new Person();
            Person p2 = new Person();
            string str;
            object[] array = new object[] { p1, p2, "Hello", 10.5, null };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] as string != null)
                {
                    str = array[i] as string;
                    Console.WriteLine($"Element[{i}] : '{str}'");
                }
                else
                {
                    Console.WriteLine($"Element[{i}] : is not a string");
                }
            }

            Vehicle v = new Vehicle();
            Animal a = new Animal();
            Car c = new Car();

            List<object> list = new List<object>();
            list.Add("Hello As");
            list.Add("12345");
            list.Add(v);
            list.Add(a);
            list.Add(c);

            foreach (object item in list)
            {
                if ((item as string) != null)
                {
                    Console.WriteLine($"{item} converted successfully.");
                }
                else
                {
                    Console.WriteLine($"{item} conversion failed.");
                }

            }

            // is operator : 
            // - Link1 : https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#is-operator 
            // - link2 : https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/is
            /*
             - sytaxe = Expression is Type
             - The is operator checks if the run-time type of an expression result is compatible with a given type. 
             -  The is operator returns true when an expression result is non-null and any of the following conditions are true:
                - The run-time type of an expression result is T.
                - The run-time type of an expression result derives from type T, implements interface T, or another implicit reference conversion exists from it to T.
                - The run-time type of an expression result is a nullable value type with the underlying type T and the Nullable<T>.HasValue is true.
                - A boxing or unboxing conversion exists from the run-time type of an expression result to type T.
                - 'is' keyword can also check compatibility of value types (int, double, char, bool) and user-defined types(custom struct , custom enum).
                - 'is' evaluates compatibility at runtime.
             */

            Author author = new Author();
            author.Details("omar", 5);
            Work work = new Work();
            work.TotalNo(80, 50);
            bool result = author is Author;
            if (result)
            {
                Console.WriteLine($"author is can be converted to type Author.");
            }
            else
            {
                Console.WriteLine($"author is cannot be converted type Author");
            }
            result = work is Author;
            if (result)
            {
                Console.WriteLine($"work is can be converted to type Author");
            }
            else
            {
                Console.WriteLine($"author is cannot be converted to type Author");
            }

            author = null;
            result = author is Author;
            if (result)
            {
                Console.WriteLine($"work is can be converted to type Author");
            }
            else
            {
                Console.WriteLine($"author is cannot be converted to type Author");
            }


            Car obj1 = new Car();
            Vehicle obj2 = new Vehicle();

            // Car base type and  Vehicle  derived type

            Console.WriteLine($"obj1 is Car : {((obj1 is Car) ? "True" : "False")}"); // obj1 is Car : True

            Console.WriteLine($"obj1 is Object : {((obj1 is Object) ? "True" : "False")}"); // obj1 is Object : True

            Console.WriteLine($"obj1 is Vehicle : {((obj1 is Vehicle) ? "True" : "False")}"); // obj1 is Vehicle : True

            Console.WriteLine($"obj2 is Vehicle : {((obj2 is Vehicle) ? "True" : "False")}"); // obj2 is Vehicle : True

            Console.WriteLine($"obj2 is Object : {((obj2 is Object) ? "True" : "False")}"); // obj2 is Object : True

            Console.WriteLine($"obj2 is Car : {((obj2 is Car) ? "True" : "False")}"); // obj2 is Car : False

            Console.WriteLine($"obj1 is Animal : {((obj1 is Animal) ? "True" : "False")}"); // obj1 is Animal : False

            Console.WriteLine($"obj2 is Animal : {((obj2 is Animal) ? "True" : "False")}"); // obj2 is Animal :  False




            // Syntax of operator is : Expression is T 
            // The is operator returns true when an expression result is non-null and any of the following conditions are true:

            // - The run-time type of an expression result is T.
            int val = 10;
            string strin1 = null;
            Console.WriteLine(val is int); // True
            Console.WriteLine(obj1 is Car); // True
            Console.WriteLine(obj2 is Vehicle); // True
            Console.WriteLine(strin1 is string); // False


            // - The run-time type of an expression result derives from type T, implements interface T, or another implicit reference conversion exists from it to T.
            Console.WriteLine(obj1 is Vehicle); // True
            Console.WriteLine(obj1 is Object); // True
            Console.WriteLine(obj2 is Object); // True
            Employee emp = new Employee();
            Console.WriteLine(emp is IName); // True
            int val1 = 10;
            Console.WriteLine(val1 is IFormattable); // True



            // - The run-time type of an expression result is a nullable value type with the underlying type T and the Nullable<T>.HasValue is true. 
            int? nullableNumber = 1223;
            bool? nullableBoolean = null;
            Console.WriteLine(nullableNumber is int); // True
            Console.WriteLine(nullableBoolean is bool); // False


            // - A boxing or unboxing conversion exists from the run-time type of an expression result to type T. but doesn't consider numeric conversions:
            int val2 = 10;
            object o = val2; // Boxing
            Console.WriteLine(o is int); // True
            Console.WriteLine(o is long); // False


            // - The is operator can be useful in the following scenarios:


            // - To check the run-time type of an expression
            int val3 = 34;
            object iBoxed = val3;
            int? jNullable = 42;
            if ((iBoxed is int number1) && (jNullable is int number2))
            {
                Console.WriteLine(number1 + number2); // 76
            }

            // - To check for null
            string strin2 = null;
            if (strin2 is null)
            {
                Console.WriteLine($"Is null");
            }
            else
            {
                Console.WriteLine($"Is not null");
            }

            Console.WriteLine("Test For Difference");

            // - Difference between Is and As operator  : 
            // - link1 : https://www.c-sharpcorner.com/blogs/is-and-as-keywords-in-c-sharp

            /*

            - The is operator is used to check if the run-time type of an object is compatible with the given type or not whereas as operator is used to perform conversion (explicit) between compatible reference types or Nullable types.
            - The is operator is of boolean type (true or false) whereas as operator is not of boolean type (object or null).
            - The as operator considers only reference, nullable, boxing, and unboxing conversions. 
            - With 'as' keyword We cannot perform conversion of value types (int, double, char, bool) and user-defined types (custom struct and custom enum).
            - With 'is' keyword can also check compatibility of value types (int, double, char, bool , .. ) and user-defined types (custom struct and custom enum).

             */

            Object obj = new Object();
            Console.WriteLine(obj); // System.Object

            //try
            //{
            //    TutPoint tutpoint = (TutPoint)obj;
            //    if (tutpoint != null)
            //    {
            //        Console.WriteLine("tutpoint does not contain null value");
            //    }
            //    else
            //    {
            //        Console.WriteLine("tutpoint contains null value");
            //    }
            //}
            //catch (InvalidCastException exp)
            //{
            //    Console.WriteLine(exp.Message);
            //}


            TutPoint tutpoint = obj as TutPoint;
            if (tutpoint != null)
            {
                Console.WriteLine("tutpoint does not contain null value");
            }
            else
            {
                Console.WriteLine("tutpoint contains null value");
            }

            TutPoint tutPoint = new TutPoint();
            Tutlover tutLover = new Tutlover();

            object[] elements = new object[7];
            elements[0] = tutPoint;
            elements[1] = tutLover;
            elements[2] = "hey..Folks";
            elements[3] = 1000;
            elements[4] = 10.22;
            elements[5] = 'c';
            elements[6] = true;

            for (int i = 0; i < elements.Length; i++)
            {
                if ((elements[i] as string) != null)
                {
                    Console.WriteLine($"{elements[i]}");
                }
                else
                {
                    Console.WriteLine($"Null Value");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < elements.Length; i++)
            {
                if ((elements[i] as Tutlover) != null)
                {
                    Console.WriteLine($"{elements[i]}");
                }
                else
                {
                    Console.WriteLine($"Null Value");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < elements.Length; i++)
            {
                if ((elements[i] as Object) != null)
                {
                    Console.WriteLine($"{elements[i]}");
                }
                else
                {
                    Console.WriteLine($"Null Value");
                }
            }


            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] is string)
                {
                    Console.WriteLine($"{elements[i]}");
                }
                else
                {
                    Console.WriteLine($"Null Value");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] is Tutlover)
                {
                    Console.WriteLine($"{elements[i]}");
                }
                else
                {
                    Console.WriteLine($"Null Value");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] is Object)
                {
                    Console.WriteLine($"{elements[i]}");
                }
                else
                {
                    Console.WriteLine($"Null Value");
                }
            }

            /*
             - Base type  --- Explicit cast (No) ---> Derived type
             - Derived type  --- Implicit cast (Yes) ---> Base type
             */





































        }
    }
}
