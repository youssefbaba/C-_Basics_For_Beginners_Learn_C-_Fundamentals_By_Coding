using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Dynamic;
using System.Net.Http.Headers;
using System.Xml.Linq;

namespace PassingParametersTes1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*
                Link 1 : https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/passing-value-type-parameters
                link 2 : https://codewala.net/2016/05/22/passing-a-reference-type-using-ref-keyword/
                link 3 : https://www.c-sharpcorner.com/UploadFile/ca6c61/concepts-of-C-Sharp-value-type-and-reference-type/
                link 4 : https://www.decodejava.com/csharp-call-by-value.htm
                link 5 : https://www.decodejava.com/csharp-call-by-reference.htm

             */
            int numberOne = 10;
            Console.WriteLine($"{numberOne}"); // 10
            Display(numberOne); // 11
            Console.WriteLine($"{numberOne}"); // 10

            User user1 = new User("Youssef", 25);
            Console.WriteLine($"My name is {user1.name} i'm {user1.age} years old ."); // My name is Youssef i'm 25 years old .
            DisplayFields(user1); // My name is Hassna i'm 29 years old .
            Console.WriteLine($"My name is {user1.name} i'm {user1.age} years old ."); // My name is Hassna i'm 29 years old .



            TheClass testClass = new TheClass(); // Reference type
            TheStruct testStruct = new TheStruct(); // Value type

            testClass.willIChange = "Not Changed";
            testStruct.willIChange = "Not Changed";

            ClassTaker(testClass);
            StructTaker(testStruct);

            Console.WriteLine($"Class field = {testClass.willIChange}"); // Class field = Changed
            Console.WriteLine($"Struct field = {testStruct.willIChange}"); // Struct field = Not Changed



            // Pass a value type by value :
            int n = 5;
            Console.WriteLine($"The value before calling the method : {n}"); // The value before calling the method : 5
            SquareIt(n); // The value inside the method :  25 
            Console.WriteLine($"The value after calling the method : {n}"); // The value after calling the method : 5

            int v1 = 12;
            int v2 = 22;
            v2 = v1;
            Console.WriteLine($"{v2}"); // 12


            User user2 = new User("Youssef", 25); // Reference type
            User user3 = new User("Omar", 24); // Reference type
            user3 = user2;
            Console.WriteLine($"{user2.name} , {user2.age}"); // Youssef , 25
            Console.WriteLine($"{user3.name} , {user3.age}"); // Youssef , 25
            user3.name = "Hassna";
            user3.age = 29;
            Console.WriteLine($"{user2.name} , {user2.age}"); // Hassna , 29
            Console.WriteLine($"{user3.name} , {user3.age}"); // Hassna , 29


            TheStruct struct1 = new TheStruct(); // value type
            struct1.willIChange = "toto";
            ShowRefOne(struct1);
            Console.WriteLine(struct1.willIChange); // toto


            // Pass a reference type by value : 
            int[] arr = new int[3] { 1, 4, 5 }; // array is a refrence type
            Console.WriteLine($"Inside Main, before calling the method, the first element is : {arr[0]}"); // Inside Main, before calling the method, the first element is : 1
            Change(arr); // passing a Reference type by value
            Console.WriteLine($"Inside Main, after calling the method, the first element is : {arr[0]}"); // Inside Main, after calling the method, the first element is : 888


            TheClass class1 = new TheClass(); // Reference type
            class1.willIChange = "bobo";
            ShowRefTwo(class1);
            Console.WriteLine($"{class1.willIChange}"); // koko


            // Pass a value type by reference : 
            TheStruct struct2 = new TheStruct(); // Value type
            struct2.willIChange = "Hello";
            ShowRefThree(ref struct2); // Passing Value type by reference
            Console.WriteLine($"'{struct2.willIChange}'"); // 'Good'

            int num = 5; // n is value type variable
            Console.WriteLine($"The value before calling the method : {num}"); // The value before calling the method : 5
            SquareOne(ref num);
            Console.WriteLine($"The value after calling the method : {num}"); // The value after calling the method : 25


            // Pass reference type by reference
            TheClass class2 = new TheClass(); // Reference type
            class2.willIChange = "Hi";
            ShowRefFour(ref class2); // Passing Reference type by reference
            Console.WriteLine($"'{class2.willIChange}'"); // 'Nice'

            int[] array = new int[3] { 1, 2, 3 }; // Reference type
            Console.WriteLine($"Inside Main, before calling the method, the first element is : {array[0]}"); // Inside Main, before calling the method, the first element is : 1
            ChangeOne(ref array);
            Console.WriteLine($"Inside Main, after calling the method, the first element is : {array[0]}"); // Inside Main, after calling the method, the first element is : -3


        }
        public static void Display(int value)
        {
            value++;
            Console.WriteLine($"{value}");
        }
        public static void DisplayFields(User user)
        {
            user.name = "Hassna";
            user.age = 29;
            Console.WriteLine($"My name is {user.name} i'm {user.age} years old .");
        }

        public static void ClassTaker(TheClass c)
        {
            c.willIChange = "Changed";
        }
        public static void StructTaker(TheStruct s)
        {
            s.willIChange = "Changed";
        }
        public static void SquareIt(int x)
        {
            x *= x;
            Console.WriteLine($"The value inside the method : {x}");
        }
        public static void Change(int[] pArray)
        {
            pArray[0] = 888;
            pArray = new int[5] { -3, -1, -2, -3, -4 };
            Console.WriteLine($"Inside the method, the first element is : {pArray[0]}"); // Inside the method, the first element is : -3
        }
        public static void ShowRefOne(TheStruct obj)
        {
            obj = new TheStruct();
            //Console.WriteLine($"'{obj.willIChange}'");
        }
        public static void ShowRefTwo(TheClass obj)
        {
            obj.willIChange = "koko";
        }
        public static void ShowRefThree(ref TheStruct str)
        {
            //str = new TheStruct();
            str.willIChange = "Good";
        }
        public static void ShowRefFour(ref TheClass class1)
        {
            class1.willIChange = "Nice";
            //class1 = new TheClass();
            //try
            //{
            //    class1 = null;
            //}
            //catch (Exception exp)
            //{
            //    Console.WriteLine(exp.Message);
            //}

        }
        public static void SquareOne(ref int number)
        {
            number *= number;
            Console.WriteLine($"The value inside the method : {number}"); // The value inside the method : 25 
        }
        public static void ChangeOne(ref int[] arr)
        {
            arr[0] = 888;
            arr = new int[5] { -3, -1, -2, -3, -4 };
            Console.WriteLine($"Inside the method, the first element is : {arr[0]}"); // Inside the method, the first element is : -3
        }
    }
}