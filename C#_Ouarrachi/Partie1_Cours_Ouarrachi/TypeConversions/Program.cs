using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace TypeConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             - Implicit and Explicit conversion
                - link1 : https://www.c-sharpcorner.com/UploadFile/puranindia/type-conversions-in-C-Sharp/
                - link2 : https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/numeric-conversions
                - link3 : https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/char#conversions 
                - link4 : https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions

             - user-defined conversion
                - link5 : https://www.youtube.com/watch?v=sGkqd0aTb-k
                - link6 : https://www.c-sharpcorner.com/blogs/userdefined-conversion
                - link7 : https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/user-defined-conversion-operators

             - Conversions with helper classes
            



             */
            /*
             
            - Conversion is based on type compatibility and data compatibility.

            - There are two types of conversions: 
                - Implicit Conversion
                - Explicit Conversion


             */

            // Implicit conversion : char -> int -> float : example for data compatibility

            int valueOne = 10;
            float valueTwo = valueOne; // Implicit Conversion
            Console.WriteLine(valueTwo); // 10

            char letterOne = 'A';
            int valueThree = letterOne; // Implicit Conversion
            Console.WriteLine($"value of valueThree is : {valueThree} and his type is : {valueThree.GetType()}"); // value of valueThree is : 65 and his type is : System.Int32
            float valueFour = letterOne; // Implicit Conversion
            Console.WriteLine($"value of valueFour is : {valueFour} and his type is : {valueFour.GetType()}"); // value of valueFour is : 65 and his type is : System.Single
            char letterTwo = '2';
            int test1 = letterTwo;
            Console.WriteLine($"value of test1 is : {test1} and his type is : {test1.GetType()}"); // value of test1 is : 50 and his type is : System.Int32
            float test2 = letterTwo;
            Console.WriteLine($"value of test2 is : {test2} and his type is : {test2.GetType()}"); // value of test2 is : 50 and his type is : System.Single

            int num1 = 1000;
            int num2 = 2000;
            long total;
            // In this the int values are implicitly converted to long data type;  
            //you don't need to tell compiler to do the conversion, it automatically does.
            total = num1 + num2;
            Console.WriteLine($"total is {total}"); // total is 3000


            // explicit conversion
            /*
            - Microsoft.NET provides three ways of type conversion:
                - Explicit Cast Operator()
                - Parsing
                - Convert Class
            */
            int amount = 66;
            char alphaOne = (char)amount; // explicit conversion with Explicit Cast Operator()
            char alphaTwo = Convert.ToChar(amount); // explicit conversion with Convert Class
            // In this the int value is explicitly converted to char data type;  
            //you have to tell compiler to do the conversion, it uses casting.  
            Console.WriteLine($"alphaOne is {alphaOne}"); // alphaOne is B
            Console.WriteLine($"alphaTwo is {alphaTwo}"); // alphaTwo is B

            // - Parsing : Parsing is used to convert string type data to primitive value type. For this we use parse methods with value types.

            int age;
            double weight;
            Console.Write($"Enter your age : ");
            age = int.Parse(Console.ReadLine());
            Console.Write($"Enter your weight : ");
            weight = double.Parse(Console.ReadLine());
            Console.WriteLine($"Your age is : {age} year(s)");
            Console.WriteLine($"Your weight is : {weight} kg(s) ");


            // - Convert Class : One primitive type to another primitive type. this class (Convert) contains different static methods like ToInt32(), ToInt16(), ToString() ...

            string ageString = "24";
            int ageOne = Convert.ToInt32(ageString);
            double weightOne = 65.9;
            string weightString = Convert.ToString(weightOne);
            Console.WriteLine($"Your age is : {ageOne} year(s)");
            Console.WriteLine($"Your weight is : {weightString} kg(s)");

            // - Explicit Cast Operator

            int numberOne = 10;
            int numberTwo = 21;
            //var test = (numberOne + numberTwo) / 2; // is of type int
            double average = (double)(numberOne + numberTwo) / 2;
            Console.WriteLine($"average is : {average}");


            int var;
            //var = 10; // Correct
            //var = "Hello" // Incorrect : because cannot implicilty convert string to int

            // - Implicit conversion
            int num = 1254658;
            long bigNum = num; // implicit conversion
            Console.WriteLine($"{bigNum}");

            Employee emp = new Employee();
            Person p1 = emp;
            Console.WriteLine(p1.GetType());
            Teacher tch = new Teacher();
            Person p2 = tch;
            Console.WriteLine(p2.GetType());


            // - Explicit conversion
            double x = 1234.7;
            int a;
            a = (int)x; // Explicit cast from double to int
            Console.WriteLine($"{a}");



            // - Type conversion exceptions at run time

            /*
              - Implicit conversion : derived class to base class 
              - Explicit conversion : base class to derived class 
              - an explicit cast is required if you need to convert from a base type to a derived type:
              - Note: This will compile but wil throw an exception at run time if the right-side
                object is not in fact a Giraffe 
            */
            Giraffe giraffeOne = new Giraffe();// Create a new derived type
            Animal animalOne = new Animal(); // Create a new base type
            Console.WriteLine($"{animalOne.GetType().Name}"); // Animal
            Console.WriteLine($"{giraffeOne.GetType().Name}"); // Giraffe
            try
            {
                Giraffe giraffeTwo = (Giraffe)animalOne; // Throw an exception
            }
            catch (InvalidCastException exp)
            {
                Console.WriteLine(exp.Message);
            }

            Animal animalTwo = giraffeOne; // Implicit conversion
            Console.WriteLine($"{animalTwo.GetType().Name}"); // Giraffe
            Giraffe giraffeThree = (Giraffe)animalTwo; // No Exception

            Test1(new Mammal());
            Test2(new Reptile());

            // - User-defined Conversions

            Student student = new Student(); // Object of student class is initialized
            int value = 25;
            student = value; // Implicit user-defined conversion from int to Student type
            Console.WriteLine($"Student name : {student.name} , Student age : {student.age}"); // Student name : youssef , Student age : 25 
            value = student.age;
            Console.WriteLine($"age : {value}"); // age : 25
            value = (int)student; // Explicit user-defined conversion from Student to int type
            Console.WriteLine($"age : {value}"); // age : 25

            //For checking the size of Digit and Byte
            Console.WriteLine("Size of type Digit in bytes is: {0} byte(s)", Marshal.SizeOf(typeof(Digit)));
            Console.WriteLine("Size of type Byte in bytes is: {0} byte(s)", sizeof(Byte));

            Digit d = new Digit(7);
            byte number = (byte)d; // Explicit user-defined conversion from Digit type to byte type
            Console.WriteLine(number); // 7
            Digit digit = number; // Implicit user-defined conversion from type byte to Digit type
            Console.WriteLine($"{digit}"); // 7


            // - Conversions with helper classes : To convert between non-compatible types

            ////// Conversion between string and an System DateTime using Parse method and Convert Class
            string stringTime = "01/12/1996";
            DateTime timeOne = DateTime.Parse(stringTime); // Conversion from string to DateTime using Parse method
            DateTime timeTwo = Convert.ToDateTime(stringTime); // Conversion from string to DateTime using Convert Class
            Console.WriteLine($"timeOne : {timeOne}");
            Console.WriteLine($"timeTwo : {timeTwo}");

            ////// Conversion between string and an integer using Parse method and Convert Class
            string stringAge = "25";
            int myAgeOne = Int32.Parse(stringAge); // Conversion from string to integer using Parse method
            int myAgeTwo = Convert.ToInt32(stringAge); // Conversion from string to integer using Parse method
            Console.WriteLine($"myAgeOne : {myAgeOne}");
            Console.WriteLine($"myAgeTwo : {myAgeTwo}");

            ////// Conversion between string and an double using Parse method and Convert Class
            string stringPrice = "15.5";
            double priceOne = Double.Parse(stringPrice); // Conversion from string to double using Parse method
            double priceTwo = Convert.ToDouble(stringPrice); // Conversion from string to double using Convert Class
            Console.WriteLine($"priceOne : {priceOne}");
            Console.WriteLine($"priceTwo : {priceTwo}");

            ////// Conversion between integers and System.DateTime 

            int dayOne = Int32.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int DayTwo = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
            Console.WriteLine($"dayOne : {dayOne}");
            Console.WriteLine($"dayTwo : {DayTwo}");


            int day = 25;
            int month = 08;
            int currentYear = DateTime.Now.Year;
            string scheduleDate = "25/08/2020";
            DateTime dtScheduleDate = DateTime.ParseExact(scheduleDate, "dd/MM/yyyy", null);
            DateTime dtCurrentDate = new DateTime(currentYear, month, day);
            Console.WriteLine($"dtScheduleDate : {dtScheduleDate}");
            Console.WriteLine($"dtCurrentDate : {dtCurrentDate}");
















        }

        public static void Test1(Animal a)
        {
            Console.WriteLine(a.GetType().Name); // Mammal
            try
            {
                Reptile r = (Reptile)a;  // Explicit Conversion and Throw an Exception at run-time
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        // C# provides the is operator to enable you to test for compatibility before actually performing a cast to avoid Exception
        public static void Test2(Animal a)
        {
            Console.WriteLine(a.GetType().Name);
            if (a is Reptile)
            {
                Reptile r = (Reptile)a; // Explicit Conversion and Not Exception
            }
        }
    }
}
