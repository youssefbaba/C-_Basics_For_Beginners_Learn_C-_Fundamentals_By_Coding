

using System.Runtime.InteropServices;

namespace OptionalParametersAndNamedParameters
{
    internal class Program
    {
        /*
         - link1 : https://www.youtube.com/watch?v=DKg0MB33qdg
         - link2 : https://www.youtube.com/watch?v=z6MFBBuX7IA
         - link3 : https://www.youtube.com/watch?v=YY7w1Bie-lI


        - link4 : https://www.c-sharpcorner.com/UploadFile/manas1/named-and-optional-parameter-in-C-Sharp/
        - link5 : https://dotnettutorials.net/lesson/named-parameters-in-csharp/
        - link6 : https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments
         


        - link7 : https://www.youtube.com/watch?v=jbtjGii300k&list=PLAC325451207E3105&index=67
        - link8 : https://www.youtube.com/watch?v=khcOI3-Kh84&list=PLAC325451207E3105&index=68
        - link9 : https://www.youtube.com/watch?v=Dmycz0ro1Yc&list=PLAC325451207E3105&index=69
        - link10 : https://www.youtube.com/watch?v=p_9f5SSXxLw&list=PLAC325451207E3105&index=70
        - link : https://dotnettutorials.net/lesson/how-to-make-method-parameters-optional-csharp/
         
         */
        static void Main(string[] args)
        {
            //Display("rectangle");
            Display(height: 1.45, width: 1.25, shape: "rectangle"); // the order of arguments when we use Named Parameters doesn't matter, but in normal case the order is very important


            //we can use Named Parameters for more readability and also the order doesn't matter
            PersonalDetails personeDetails = new PersonalDetails();
            personeDetails.AddPersonalDetails(firstName: "Hari", lastName: "Koirala", petName: "Shivdya", shortName: "Shiv");


            Console.WriteLine(SumOne(10, 20, 30));
            Console.WriteLine(SumOne(10, 20, number3: 30)); // True
            Console.WriteLine(SumOne(10, number2: 20, 30)); // True
            Console.WriteLine(SumOne(number1: 10, 20, 30)); // True
            Console.WriteLine(SumOne(100, number2: 200, number3: 300)); // True
            Console.WriteLine(SumOne(100, number3: 200, number2: 300)); // True
            Console.WriteLine(SumOne(number1: 100, number2: 200, 300)); // True
            //Console.WriteLine(SumOne(number2:100, number1:200, 300)); // Error
            //Console.WriteLine(SumOne(number3:100, 200, 300)); // Error
            Console.WriteLine(SumTwo(200, 40));
            Console.WriteLine(SumTwo(10));
            Console.WriteLine(SumTwo(10, number3: 1000));


            Console.WriteLine($"{Currency(500)}"); // amount = 500 and rate = 1.18 (default value)
            Console.WriteLine($"{Currency(500, 2)}"); // amount = 500 and rate = 2
            Console.WriteLine($"{Currency(rate: 2.5, amount: 600)}");

            // Named Parameters :


            // The syntax of parameter names is => parametername: value.
            Console.WriteLine(AddNumber(12, 13));// Normal way for passing parameters in a method (positional arguments) which firstNmae = 12 , lastName = 13
            //Console.WriteLine(AddString(25, "Youssef")); // Error Compilation
            Console.WriteLine(AddString("Youssef", 25)); // text = Youssef , age = 25
            Console.WriteLine(AddNumber(firstNumber: 12, secondNumber: 13)); // first way of Named arguments
            Console.WriteLine(AddNumber(secondNumber: 13, firstNumber: 12)); // second way of Named arguments which the order of arguments doesn't matter
            Console.WriteLine(AddNumber(12, secondNumber: 13)); // Positional arguments and Named arguments
            Console.WriteLine(AddNumber(firstNumber: 12, 13)); // Named arguments and Positional arguments

            Employee employee1 = new Employee();
            employee1.AddEmployeeInfo(1001, "Pranaya", true, "1234567890", "IT"); // Here wa are using the Normal Way (Positional arguments ) which the argument order of what we are passing is important.

            // when we pass the arguments in random order, then we may store the wrong data in the database or we may get some compiler error if the parameter type is not matched.
            employee1.AddEmployeeInfo(1001, "1234567890", true, "Pranaya", "IT"); // store the wrong data in the database
            //employee1.AddEmployeeInfo("IT", "Pranaya", true, "1234567890", 1001); // get some compiler error if the parameter type is not matched
            //employee1.AddEmployeeInfo(true, "Pranaya", 1001, "IT", "1234567890"); // get some compiler error if the parameter type is not matched
            employee1.AddEmployeeInfo(isPermanent: true, name: "Pranaya", empId: 1001, departement: "IT", mobile: "1234567890");// Using Named Parameters

            /*
             - Named arguments, when used with positional arguments, are valid as long as : 
                - they're not followed by any positional arguments
                - they're used in the correct position
             */
            employee1.AddEmployeeInfo(1001, "Pranaya", isPermanent: true, mobile: "1234567890", departement: "IT"); // Named Arguments not followed by any positional arguments
            employee1.AddEmployeeInfo(1001, "Pranaya", departement: "IT", isPermanent: true, mobile: "1234567890"); // Named Arguments not followed by any positional arguments
            employee1.AddEmployeeInfo(1001, "Pranaya", departement: "IT", mobile: "1234567890", isPermanent: true); // Named Arguments not followed by any positional arguments

            employee1.AddEmployeeInfo(1001, "Pranaya", isPermanent: true, mobile: "1234567890", "IT"); // they're used in the correct position
                                                                                                       //employee1.AddEmployeeInfo(1001, "Pranaya", "1234567890", isPermanent: true,departement: "IT"); // Named arguments followed by positional argument but thye aren't used in the correct position

            employee1.AddEmployeeInfoOne(empId: 1002, name: "Prana", mobile: "12347890"); // because isPermanent and Departement are optional parameters so thaey takes their default value
            employee1.AddEmployeeInfoOne(empId: 1002, name: "Prana", mobile: "12347890", departement: "Sales");

            // Optional Parameters
            // - Use parameter array :
            //AddNumbers(10); // Error Because we have two required parameters
            AddNumbers(10, 20);
            AddNumbers(10, 20, 30, 40, 50);
            AddNumbers(10, 20, new int[3] { 30, 40, 50 });


            // - Method Overloading :
            //AddNumbersOne(10); // Error
            //AddNumbersOne(10, 20); // Error if overload method AddNumbersOne(parm1 , parm2) doesn't exist
            AddNumbersOne(10, 20, null);
            AddNumbersOne(10, 20);
            AddNumbersOne(10, 20, new int[3] { 30, 40, 50 });


            // - Specify Parameter defaults : 
            //AddNumbersTwo(10); // Error Because we have two required parameters
            AddNumbersTwo(10, 20); // Here int[] restOfNumbers = null
            AddNumbersTwo(10, 20, new int[3] { 30, 40, 50 }); // Here int[] restOfNumbers = new int[3] { 30, 40, 50 }
            TestNamedParameters(30); // Here numberOne = 30 , numberTwo = 10 , numberThree = 20  
            TestNamedParameters(30, 40); // Here numberOne = 30 , numberTwo = 40 , numberThree = 20  
            TestNamedParameters(1,2,3); // Here numberOne = 1 , numberTwo = 2 , numberThree = 3
            TestNamedParameters(30, numberThree: 50); // Here numberOne = 30 , numberTwo = 10 , numberThree = 50  


            // - Use OptionalAttribute that is present in System.Runtime.InteropServices namespace
            //AddNumbersThree(10);// Error Because we have two required parameters
            AddNumbersThree(10, 20);
            AddNumbersThree(10, 20, new int[3] { 30, 40, 50 });
        }
        public static void Display(string shape, double width = 1, double height = 1)
        {
            // Here the parameters width and height are optional and shape is required
            shape = shape.ToUpper();
            if (width == height && shape.Equals("RECTANGLE"))
            {
                shape = "SQUARE";
            }
            Console.WriteLine($"Area of {shape} which his width = {width} and his height = {height} : {height * width}");

        }
        public static string SumOne(int number1, int number2, int number3)
        {
            // Here all parameters (number1 , number2 , number3) are required 
            return $"number1 = {number1} , number2 = {number2} , number3 = {number3} , number1 + number2 + number3 = {number1 + number2 + number3}";
        }

        public static string SumTwo(int number1, int number2 = 16, int number3 = 100)
        {
            // Here all parameters (number2 , number3) are optional  and number1 is required
            return $"number1 = {number1} , number2 = {number2} , number3 = {number3} , number1 + number2 + number3 = {number1 + number2 + number3}";
        }

        public static double Currency(int amount, double rate = 1.18)
        {
            return amount * rate;
        }

        public static int AddNumber(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public static string AddString(string text, int age)
        {
            return $"Name : {text} , Age : {age}";
        }

        // a parameter array must be the last parameter in a formal parameter list .
        //public static void AddNumbers(int firstNumber, params int[] restOfParameters , int secondNumber, )  // Error
        //{
        //     // Statements ...
        //}
        public static void AddNumbers(int firstNumber, int secondNumber, params int[] restOfNumbers)
        {
            //  Here firstNumber and secondNumber are required parameters but restOfNumbers is optional parameter
            int Sum = firstNumber + secondNumber;
            Console.Write($"Sum of {firstNumber} + {secondNumber}");
            if (restOfNumbers != null)
            {
                foreach (int number in restOfNumbers)
                {
                    Sum += number;
                    Console.Write($" + {number}");
                }
            }
            Console.Write($" = {Sum}");
            Console.WriteLine();
        }
        public static void AddNumbersOne(int firstNumber, int secondNumber, int[] restOfNumbers)
        {
            // Here all parameters are required
            int Sum = firstNumber + secondNumber;
            Console.Write($"Sum of {firstNumber} + {secondNumber}");
            if (restOfNumbers != null)
            {
                foreach (int number in restOfNumbers)
                {
                    Sum += number;
                    Console.Write($" + {number}");
                }
            }
            Console.Write($" = {Sum}");
            Console.WriteLine();

        }
        public static void AddNumbersOne(int firstNumber, int secondNumber)
        {
            AddNumbersOne(firstNumber, secondNumber, null);
        }
        // The Optional parameters in C# must appear after all the required parameters.
        public static void AddNumbersTwo(int firstNumber , int secondNumber , int[] restOfNumbers = null)
        {
            // Here firstNumber and secondNumber are required parameters but restOfNumbers is optional parameters
            int Sum = firstNumber + secondNumber;
            Console.Write($"Sum of {firstNumber} + {secondNumber}");
            if (restOfNumbers != null)
            {
                foreach (int number in restOfNumbers)
                {
                    Sum += number;
                    Console.Write($" + {number}");
                }
            }
            Console.Write($" = {Sum}");
            Console.WriteLine();
        }
        public static void TestNamedParameters(int numberOne , int numberTwo = 10 , int numberThree = 20)
        {
            // Here numberOne is required parameter but numberTwo and numberThree are optional parameters
            Console.WriteLine($"NumberOne = {numberOne}\nNumberTwo = {numberTwo}\nNumberThree = {numberThree}\n-------------");
        }
        public static void AddNumbersThree(int firstNumber, int secondNumber, [Optional]int[] restOfNumbers)
        {
            // Here firstNumber and secondNumber are required parameters but restOfNumbers is optional parameters
            int Sum = firstNumber + secondNumber;
            Console.Write($"Sum of {firstNumber} + {secondNumber}");
            if (restOfNumbers != null)
            {
                foreach (int number in restOfNumbers)
                {
                    Sum += number;
                    Console.Write($" + {number}");
                }
            }
            Console.Write($" = {Sum}");
            Console.WriteLine();
        }
    }
}