
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Security.AccessControl;

namespace ControlFlowCondionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - link1 : https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements#the-if-statement
             - link2 : https://dotnettutorials.net/lesson/control-flow-statements-in-csharp/


             */

            /*

            // If Statement 
            Console.Write("Please Enter a integer number : ");
            try
            {
                int intNumber = Convert.ToInt32(Console.ReadLine());
                if (intNumber >= 10)
                {
                    Console.WriteLine($"{intNumber} is greater than or equal 10 ");
                    Console.WriteLine("End of if block");
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            Console.WriteLine("End of Main Method");

            // If Statement without curly braces
            Console.Write("Please Enter other integer number : ");
            int result;
            bool converted = int.TryParse(Console.ReadLine(), out result);
            if (converted)
                Console.WriteLine("Convert string to integer ."); // Statement of if block
            Console.WriteLine("End of Main Method");

            // If-Else Statements 

            Console.Write("Please enter integer number : ");
            int result1;
            bool checkNumber = Int32.TryParse(Console.ReadLine(), out result1);
            if (checkNumber)
            {
                if ((result1 % 2) == 0)
                {
                    Console.WriteLine($"{result1} is an even number");
                }
                else
                {
                    Console.WriteLine($"{result1} is an odd number");
                }
            }
            else
            {
                Console.WriteLine("Conversion Failed");
            }

            // If-Else without curly braces

            int number = 10;
            if (number == 10)
                Console.WriteLine("Hi"); // This Statement belongs to If Block
                                         //Console.WriteLine("Good"); //  Error
            else
                Console.WriteLine("Hello");
            Console.WriteLine("Bye");

            // f-Else wityh curly braces 

            number = 20;
            if (number == 20)
            {
                Console.WriteLine("Hi");
                Console.WriteLine("Hello");
            }
            else
            {
                Console.WriteLine("Bye");
            }

            DisplayWeartherReport(25); // Perfect!
            DisplayWeartherReport(15); // Cold.

            DisplayMeasurement(40); // The measurement value is 45
            DisplayMeasurement(-5); // Warning not acceptable value! The measurement value is -5

            DisplayCharacter('i'); // A lowercase letter : i
            DisplayCharacter('G'); // An uppercase letter : G
            DisplayCharacter('4'); // A digit : 4
            DisplayCharacter(';'); // Not alphanumeric character : ; 

            WeartherReport(30); // Perfect!
            WeartherReport(10); // Cold .






            // Example of Nested If-Else statement : for finding large number betweeen three numbers

            // First Way
            int numberOne = 15;
            int numberTwo = 25;
            int numberThree = 10;
            int largeNumber = 0;

            if (numberOne > numberTwo)
            {
                if (numberOne > numberThree)
                {
                    largeNumber = numberOne;
                    Console.WriteLine($"Large Number is {largeNumber}");
                }
                else
                {
                    largeNumber = numberThree;
                    Console.WriteLine($"Large Number is {largeNumber}");
                }
            }
            else
            {
                if (numberTwo > numberThree)
                {
                    largeNumber = numberTwo;
                    Console.WriteLine($"Large Number is {largeNumber}");
                }
                else
                {
                    largeNumber = numberThree;
                    Console.WriteLine($"Large Number is {largeNumber}");
                }
            }

            // Second Way 
            if (numberOne > numberTwo)
            {
                largeNumber = numberOne;
                if (numberThree > largeNumber)
                {
                    largeNumber = numberThree;
                }
            }
            else
            {
                largeNumber = numberTwo;
                if (numberThree > largeNumber)
                {
                    largeNumber = numberThree;
                }
            }
            Console.WriteLine($"Large Number is {largeNumber}");

            // Third Way 

            largeNumber = (numberOne > numberTwo) ? ((numberOne > numberThree) ? numberOne : numberThree) : ((numberTwo > numberThree) ? numberTwo : numberThree);
            Console.WriteLine($"Large Number is {largeNumber}");


            // Example of Ladder If-Else statement

            int Value = 20;
            if (Value == 10)
            {
                Console.WriteLine($"Value is : {Value} .");
            }
            else if (Value == 15)
            {
                Console.WriteLine($"Value is : {Value} .");
            }
            else if (Value == 20)
            {
                Console.WriteLine($"Value is : {Value} .");
            }
            else
            {
                Console.WriteLine("Value is not present .");
            }

            */





            /*
             switch (test)
            {

                case 1:
                    // Execute your code
                    break;
                case 2:
                    // Execute your code
                    break;
                case n:
                    // Execute your code
                    break;
                default:
            }
             
             */

            // Switch Statement Example 

            int valueOne = 2;
            switch (valueOne)
            {
                case 1:
                    Console.WriteLine("Choice is 1");
                    break;
                case 2:
                    Console.WriteLine("Choice is 2");
                    break;
                case 3:
                    Console.WriteLine("Choice is 3");
                    break;
                default:
                    Console.WriteLine("Choice other than 1, 2 and 3");
                    break;
            }

            string stringOne = "C#";
            switch (stringOne)
            {
                case "JAVA":
                case "C#":
                case "C":
                    Console.WriteLine("It’s a Programming Langauge");
                    break;
                case "MSSQL":
                case "MYSQL":
                case "ORACLE":
                    Console.WriteLine("It’s a Database");
                    break;
                case "MVC":
                case "WEB API":
                    Console.WriteLine("It’s a Framework");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

            //  Optional default block

            string stringTwo = "Python";
            Console.WriteLine("Switch Statement Started");
            switch (stringTwo)
            {
                case "JAVA":
                case "C#":
                case "C":
                    Console.WriteLine("It’s a Programming Langauge");
                    break;
                case "MSSQL":
                case "MYSQL":
                case "ORACLE":
                    Console.WriteLine("It’s a Database");
                    break;
                case "MVC":
                case "WEB API":
                    Console.WriteLine("It’s a Framework");
                    break;
            }
            Console.WriteLine("Switch Statement Ended");

            // Why do we use Switch Statements instead of if-else statements in C#?
            string category;
            string topic = "Inheritance";

            if (topic.Equals("Introduction to C#") ||
                topic.Equals("Variables") ||
                topic.Equals("Data Types"))
            {
                category = "Basic";
            }
            else if (topic.Equals("Loops") ||
                topic.Equals("If Else Statements")||
                topic.Equals("Jump Statements"))
            {
                category = "Control Flow";
            }
            else if (topic.Equals("Inheritance")||
                topic.Equals("Polymorphisme")||
                topic.Equals("Abstraction")||
                topic.Equals("Encapsulation"))
            {
                category = "OOPS Conception";
            }
            else
            {
                category = "Invalid";
            }
            Console.WriteLine($"{topic} Category is {category}");


            switch (topic)
            {
                case "Introduction to C#":
                case "Variables":
                case "Data Types":
                    category = "Basic";
                    break;
                case "Loops":
                case "If Else Statements":
                case "Jump Statements":
                    category = "Control Flow";
                    break;
                case "Inheritance":
                case "Polymorphisme":
                case "Abstraction":
                case "Encapsulation":
                    category = "OOPS Conception";
                    break;
                default:
                    category = "Invalid";
                    break;
            }
            Console.WriteLine($"{topic} Category is {category}");

            // Nested Switch Statement in C#:

            Console.Write("Enter a number between 1 and 3 : ");
            int number;
            if (Int32.TryParse(Console.ReadLine() , out number))
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("You Entered One");
                        Console.Write("Enter Color Code (R/G/B) : ");
                        char charColor;
                        if (Char.TryParse(Console.ReadLine() ,out charColor))
                        {

                            switch (Char.ToUpper(charColor))
                            {
                                case 'R':
                                    Console.WriteLine("You have Selected Red Color");
                                    break;
                                case 'G':
                                    Console.WriteLine("You have Selected Green Color");
                                    break;
                                case 'B':
                                    Console.WriteLine("You have Selected Blue Color");
                                    break;
                                default:
                                    Console.WriteLine($"You Have Enter Invalid Color Code: {Char.ToUpper(charColor)}");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Conversion from string to char failed");
                        }
                        break;

                    case 2:
                        Console.WriteLine("You Entered Two");
                        break;
                    case 3:
                        Console.WriteLine("You Entered Three");
                        break;
                    default:
                        Console.WriteLine("Invalid number");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Conversion from string to int failed");
            }

            PrintNumberOne(10); // Your number is 10
            PrintNumberOne(15); // number isn't 10 , 20 & 30

            PrintNumberTwo(40); // number isn't 10 , 20 & 30
            PrintNumberTwo(30); // Your number is 30

            DisplayMeasure(-4); // Measured value is -4 : too low.
            DisplayMeasure(5); // Measured value is 5
            DisplayMeasure(30); // Measured value is -4 : too high.
            DisplayMeasure(Double.NaN); //  Failed measurement

            Console.WriteLine(Classify(-8)); // Too low
            Console.WriteLine(Classify(19.6)); // Too high
            Console.WriteLine(Classify(1.5)); // Acceptable
            Console.WriteLine(Classify(Double.NaN)); // Unknown

            Console.WriteLine(GetCalendarSeason(new DateTime(2021, 3, 14)));   // Spring
            Console.WriteLine(GetCalendarSeason(new DateTime(2021, 7, 19)));   // Summer 
            Console.WriteLine(GetCalendarSeason(new DateTime(2021, 2, 17)));  // Winter

            Console.WriteLine(GetGroupTicketPrice(1)); // 12.0
            //Console.WriteLine(GetGroupTicketPrice(5)); // Not supported number of visitors: 5 , visitorCount



            Console.WriteLine("###############");



















        }

        public static void DisplayWeartherReport(double tempInCelsius)
        {
            if (tempInCelsius > 20.0)
            {
                Console.WriteLine("Cold.");
            }
            else
            {
                Console.WriteLine("Perfect!");
            }
        }
        public static void DisplayMeasurement(double value)
        {
            if (value < 0 || value > 100)
            {
                Console.WriteLine("Warning: not acceptable value!");
            }
            Console.WriteLine($"The measurement value is {value}");
        }
        public static void DisplayCharacter(char letter)
        {
            if (char.IsUpper(letter))
            {
                Console.WriteLine($"An uppercase letter : {letter}");
            }
            else if (char.IsLower(letter))
            {
                Console.WriteLine($"A lowercase letter : {letter}");
            }
            else if (char.IsDigit(letter))
            {
                Console.WriteLine($"A digit : {letter}");
            }
            else
            {
                Console.WriteLine($"Not alphanumeric character : {letter}");
            }
        }
        public static void WeartherReport(double temperature)
        {
            string weatherCondition = (temperature < 20.0) ? "Cold ." : "Perfect!";
            Console.WriteLine(weatherCondition);
        }

        public static void PrintNumberOne(int number)
        {
            switch (number)
            {
                case 10:
                    Console.WriteLine($"Your number is {number}");
                    break;
                case 20:
                    Console.WriteLine($"Your number is {number}");
                    break;
                case 30:
                    Console.WriteLine($"Your number is {number}");
                    break;
                default:
                    Console.WriteLine("number isn't 10 , 20 & 30");
                    break;
            }
        }
        public static void PrintNumberTwo(int number)
        {

            switch (number)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine($"Your number is {number}");
                    break;
                default:
                    Console.WriteLine("Your number isn't 10 , 20 & 30");
                    break;
            }
        }

        // Switch Statement using relational pattern and constant pattern
        /*
         - relational pattern : to compare an expression result with a constant ( < , > , <= , >= ).
         - constant pattern : to test if an expression result equals a constant ( == ).
         */

        public static void DisplayMeasure(double measure)
        {
            switch (measure)
            {
                case < 0.0: // measure < 0.0 => relational pattern
                    Console.WriteLine($"Measured value is {measure} : too low.");
                    break;
                case > 15.0: // measure > 15.0 => relational pattern
                    Console.WriteLine($"Measured value is {measure} : too high.");
                    break;
                case double.NaN: // measure  == double.NaN => constant patern
                    Console.WriteLine("Failed measurement");
                    break;
                default:
                    Console.WriteLine($"Measured value is {measure}");
                    break;
            }
        }


        public static string Classify( double value ) 
        {
            switch (value)
            {
                case < -4.0: // value < -4.0 => relational pattern 
                    return  "Too low";
                case > 15.0: // value > 15.0 => relational pattern 
                    return "Too high";
                case Double.NaN: // value == Double.NaN => constant pattern
                    return "Unkonwn";
                default:
                    return "Acceptable";
            }
        }

        /*
        Spring runs from March 1 to May 31;
        summer runs from June 1 to August 31;
        fall (autumn) runs from September 1 to November 30; and
        winter runs from December 1 to February 28 (February 29 in a leap year).
         */

        public static string GetCalendarSeason(DateTime dateTime)
        {
            switch (dateTime.Month)
            {
                case <= 5 and >= 3:  //     3 <= Spring <= 5
                    return "Spring";
                case <= 8 and >= 6:  //     6 <= Summer <= 8
                    return "Summer";
                case <= 11 and >= 9: //    9 <= Autumn <= 11
                    return "Autumn";
                case  12 or <= 2 and >= 1: // 12 or 1 <= Spring <= 2  
                    return "Winter";
                default:
                   throw new ArgumentOutOfRangeException(nameof(dateTime), $"Date with unexpected month: {dateTime.Month}.");
            }

        }

        public static decimal GetGroupTicketPrice(int visitorCount)
        {
            switch (visitorCount)
            {
                case 1:
                    return 12.0m;
                case 2:
                    return 20.0m;
                case 3:
                    return 27.0m;
                case 4:
                    return 32.0m;
                case 0:
                    return 0.0m;
                default:
                    throw new ArgumentException($"Not supported number of visitors: {visitorCount}", nameof(visitorCount));
            }


        }







    }
}
