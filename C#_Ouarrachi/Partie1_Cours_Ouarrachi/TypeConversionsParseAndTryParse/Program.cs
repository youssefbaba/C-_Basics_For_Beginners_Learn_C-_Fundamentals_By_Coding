using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TypeConversionsParseAndTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - link1 : https://www.youtube.com/watch?v=a4hemCY0s5M
             - link2 : http://net-informations.com/faq/netfaq/parse.htm
             */
            // Difference between Parse and TryParse
            /*
             - we use Parse and TryParse methods to convert form string to any other data type.
             - usually we use Parse and TryParse methods with buil-in number and System DateTime
             - Parse() method throws an exception if it cannot parse the value (if your parameter is null or there is incorrect format exception or overflow exception ),
              whereas TryParse() returns a bool indicating whether it succeded or failed (if your string parameter is null or System.String.Empty,
              is not of the correct format, or represents a number less than System.Int32.MinValue or greater than System.Int32.MaxValue)
             - Use Parse() if you are sure the value will be valid , otherwise use TryParse()
             */


            string string1 = "1000";
            string string2 = null;
            string string3 = "1000.53";
            string string4 = "99999999999999999999999999999999";

            int result;
            result = Int32.Parse(string1);
            Console.WriteLine($"result : {result}"); // 1000

            try
            {
                result = Int32.Parse(string2);
                Console.WriteLine($"result : {result}"); // ArgumentNullException : string2 is null
            }
            catch (ArgumentNullException exp)
            {
                Console.WriteLine(exp.Message);
            }

            try
            {
                result = Int32.Parse(string3);
                Console.WriteLine($"result : {result}"); // FormatException : string3 is not in the correct format
            }
            catch (FormatException exp)
            {
                Console.WriteLine(exp.Message);
            }

            try
            {
                result = Int32.Parse(string4);
                Console.WriteLine($"result : {result}"); // OverflowException : string4 is less than Int32.MinValue  or grather than  Int32.MaxValue
            }
            catch (OverflowException exp)
            {
                Console.WriteLine(exp.Message);
            }


            int numberResult;
            bool isConverted;
            isConverted = Int32.TryParse(string1, out numberResult);
            if (isConverted)
            {
                Console.WriteLine($"IsConverted : {isConverted} , NumberResult : {numberResult}"); // IsConverted : True , NumberResult : 1000
            }
            else
            {
                Console.WriteLine($"IsConverted : {isConverted} , NumberResult : {numberResult}");
            }


            isConverted = Int32.TryParse(string2, out numberResult);
            if (isConverted)
            {
                Console.WriteLine($"IsConverted : {isConverted} , NumberResult : {numberResult}");
            }
            else
            {
                Console.WriteLine($"IsConverted : {isConverted} , NumberResult : {numberResult}"); // IsConverted : False , NumberResult : 0
            }

            isConverted = Int32.TryParse(string3, out numberResult);
            if (isConverted)
            {
                Console.WriteLine($"IsConverted : {isConverted} , NumberResult : {numberResult}");
            }
            else
            {
                Console.WriteLine($"IsConverted : {isConverted} , NumberResult : {numberResult}"); // IsConverted : False , NumberResult :0
            }

            isConverted = Int32.TryParse(string4, out numberResult);
            if (isConverted)
            {
                Console.WriteLine($"IsConverted : {isConverted} , NumberResult : {numberResult}");

            }
            else
            {
                Console.WriteLine($"IsConverted : {isConverted} , NumberResult : {numberResult}"); // IsConverted : False , NumberResult :0

            }


            //// Difference Between Casting and Parsing and Converting

            /*
             - link1 : https://www.youtube.com/watch?v=xi70YZz3Fd4
             */
            // 1 .Implicit Conversion :
            /////// Value Types
            int myInt = 5;
            float myFloat = myInt; // implicit conversion from int type to float type
            Console.WriteLine(myInt);
            Console.WriteLine(myFloat);
            ////// Reference Types
            IEmployee iEmployee = new Employee();
            Console.WriteLine($"{iEmployee.GetType().Name}"); //Employee
            iEmployee.Display(); // Display Employee

            Employee employee = new Customer();
            Console.WriteLine($"{employee.GetType().Name}"); // Customer
            employee.Display(); // Display Customer


            // 2 .Explicit Conversion or Casting :
            float floatVal = 4.5f;
            int myValue = (int)floatVal; // explicit conversion from float type to int type
            Console.WriteLine(floatVal);
            Console.WriteLine(myValue);
            Console.WriteLine("#########################");

 
            // 3 .non-existant of explicit conversion :
            //double doubleValue = 28.05;
            //string stringValue = (string)doubleValue; // connot implicitly and explicitly convert double type string because they are incompatible
            //string data = "2022";
            //int convertedNumber = (int)data; // connot implicitly and explicitly convert String type int because they are incompatible
            try
            {
            object obj = 25; // because Object Class is base class for all tohet types
            Console.WriteLine($"{obj.GetType().Name}"); // Int32 : at run-time but object at compile-time
            string strObject = (string)obj;
            Console.WriteLine($"{strObject}");
            }
            catch (InvalidCastException exp)
            {
                Console.WriteLine($"{exp.Message}");
            }

            // 4 .Convert Class :
            string stringNumber = "30.08";
            try
            {
            int stringToNumber = Convert.ToInt32(stringNumber);
            Console.WriteLine($"{stringNumber}");
            }
            catch (FormatException exp)
            {
                Console.WriteLine(exp.Message);
            }

            double stringToDouble = Convert.ToDouble(stringNumber);
            Console.WriteLine($"{stringToDouble}");


            string dataOne = "123";
            int convertedNumberOne = Convert.ToInt32(dataOne);
            Console.WriteLine(convertedNumberOne);
            try
            {
                string dateTwo = "12A";
                int convertedNumberTwo = Convert.ToInt32(dateTwo);
                Console.WriteLine(convertedNumberTwo);
            }
            catch (FormatException exp)
            {
                Console.WriteLine(exp.Message);
            }

            // 5 .Parse or TryParse : 
            string dateStringOne = "01/28/2020";
            DateTime dateTime = DateTime.Parse(dateStringOne); // In current culture "en-US" date represent like that Month/Day/Year
            Console.WriteLine(dateTime);

            try
            {
                string dateStringTwo = "28/01/2020";
                DateTime dateTimeTwo = DateTime.Parse(dateStringTwo); // In current culture "en-US" date represent like that Month/Day/Year
                Console.WriteLine(dateTimeTwo);
            }
            catch (FormatException exp)
            {
                Console.WriteLine(exp.Message);
            }

            string data = "123B";
            int resultOne;
            bool check = Int32.TryParse(data , out resultOne);
            Console.WriteLine($"check : {check} , result : {resultOne}");

         
        }


    }
}
