using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputAndInput
{
    internal class Program
    {
        enum Color { Yellow = 1, Blue, Green };
        static DateTime thisDate = DateTime.Now;

        static void Main(string[] args)
        {
            /*
             - link1 : https://www.worldofitech.com/csharp-basic-input-output/
             - link2 : https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline?view=netframework-4.8#system-console-writeline(system-string-system-object())
             - link3 : https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=netframework-4.8#system-string-format(system-string-system-object())
             */


            Console.WriteLine("Display Something ..."); // Display with a break in a new line
            Console.WriteLine($"Display Something ...");
            Console.Write($"Youssef "); // Display without a break in a new line
            Console.Write("Baba"); // Display without a break in a new line 
            Console.WriteLine();

            // Concatenation
            int number = 10;
            Console.WriteLine("number : " + number);

            int numberOne = 123;
            int numberTwo = 145;
            int result = numberOne + numberTwo;
            Console.WriteLine("Result : {0} + {1} = {2}", numberOne, numberTwo, result);
            Console.WriteLine($"Result : {numberOne} + {numberTwo} = {result}"); // Very easy


            Console.Write($"Please enter an integer number : ");
            string stringNumber = Console.ReadLine();
            int resultOne;
            // By using TryParse Method to convert string to int
            if (Int32.TryParse(stringNumber, out resultOne))
            {
                Console.WriteLine($"Result By using TryParse Methode : {resultOne}");
            }
            else
            {
                Console.WriteLine($"conversion failed");
            }

            // By using Convert Class to convert string to int
            try
            {
                int res = Convert.ToInt32(stringNumber);
                Console.WriteLine($"Result By using Convert Class : {res}");
            }
            catch (FormatException exp)
            {
                Console.WriteLine(exp.Message);
            }


            // Difference Between Writeline() and Write() method : 
            Console.WriteLine("Prints on "); // Prints with NewLine
            Console.WriteLine("New Line"); // Prints with NewLine

            Console.Write("Prints on "); // Prints without NewLine
            Console.Write("Same Line"); // Prints without NewLine
            Console.WriteLine(); // Just For a line Break


            // Printing Variables and Literals
            double doubleVariable = 120.36;
            Console.WriteLine(doubleVariable); // Printing Variable
            Console.WriteLine(100.12); // Printing Literal
            string stringVariable = "Youssef Baba";
            Console.WriteLine(stringVariable); // Printing Variable
            Console.WriteLine("Hello World"); // Printing Literal


            // Printing Concatenated String using + operator
            int val = 20;
            string testOne = "Youssef " + "Baba"; // Concatenation
            string testTwo = "Value : " + val; // Concatenation

            Console.WriteLine("Youssef " + "Baba"); // Concatenation
            Console.WriteLine(testOne);
            Console.WriteLine("Value : " + val); // Concatenation
            Console.WriteLine(testTwo);

            // Printing Concatenated string using String formatting
            int firstNumber = 10;
            int secondNumber = 11;
            int resultTwo = firstNumber + secondNumber;
            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, resultTwo);
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");


            // Get String from the user 
            Console.Write("Enter a string : ");
            string stringOne = Console.ReadLine();
            Console.WriteLine($"You entered : {stringOne}");

            // Get Integer form the user
            Console.Write("Enter a number(Integer) : ");
            string stringTwo = Console.ReadLine();
            int resultThree;
            bool converted = Int32.TryParse(stringTwo, out resultThree);
            if (converted)
            {
                Console.WriteLine($"Value : {resultThree}");
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }


            // Difference between ReadLine() and Read() and ReadKey() 
            Console.Write("Enter something here : ");
            string stringThree = Console.ReadLine(); // reads the next line of input from the standard input stream. It returns a similar string.
            Console.WriteLine($"You entered : {stringThree}");

            Console.Write("Input using Read() : ");
            int asciValue = Console.Read(); // reads the next character from the standard input stream.It returns the ascii value of the first character.
            Console.WriteLine($"You entered : {asciValue}");

            //Console.Write("Enter the key to clear console ...");
            ConsoleKeyInfo key = Console.ReadKey(true);
            string stringFour = key.ToString();
            if (!string.IsNullOrEmpty(stringFour))
            {
                Console.Clear();
            }
            Console.WriteLine();


            // Reading a string and character :
            Console.Write("Enter a string : ");
            string stringFive = Console.ReadLine();
            Console.WriteLine($"String value is : {stringFive}");

            Console.Write("Enter a character : ");
            char charTwo = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine($"Character value is : {charTwo}");

            // Reading Numeric Values from User using Convert class
            Console.Write("Enter a integer value : ");
            string integerString = Console.ReadLine();
            int stringToInteger = Convert.ToInt32(integerString); // Converts to integer type
            Console.WriteLine($"You Intered : {stringToInteger}");

            Console.Write("Enter a double value : ");
            string doubleString = Console.ReadLine();
            double stringToDouble = Convert.ToDouble(doubleString); // Converts to double type
            Console.WriteLine($"You Intered : {stringToDouble}");


            // Reading Numeric Values from User using TryParse method

            Console.WriteLine("Enter a ineger value : ");
            int resultFour;
            string string1 = Console.ReadLine();
            bool convert1 = Int32.TryParse(string1, out resultFour);
            if (convert1)
            {
                Console.WriteLine($"You intered : {resultFour}");
            }
            else
            {
                Console.WriteLine("Conversion Failed");
            }

            Console.WriteLine("Enter a double value : ");
            double resultFive;
            string string2 = Console.ReadLine();
            bool convert2 = Double.TryParse(string1, out resultFive);
            if (convert2)
            {
                Console.WriteLine($"You intered : {resultFive}");
            }
            else
            {
                Console.WriteLine("Conversion Failed");
            }

            Console.WriteLine("########");























            //// Test for all Overloads Method
            /*
             \r = Carriage return means to return to the beginning of the current line without advancing downward. This is commonly escaped as "\r", abbreviated CR, and has ASCII value 13 or 0xD.

             \n = Linefeed means to advance downward to the next line; however, it has been repurposed and renamed. Used as "newline", it terminates lines (commonly confused with separating lines). This is commonly escaped as "\n", abbreviated LF or NL, and has ASCII value 10 or 0xA. CRLF (but not CRNL) is used for the pair "\r\n".
             */

            ////// Writeline(String s) and WriteLine()
            string[] lines = { "First line", "Second line" };
            Console.WriteLine("With the default new line characters : ");
            Console.WriteLine();
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.Out.NewLine = "\r\n\r\n"; // Redefine the newline characters to double space.

            Console.WriteLine("With redefined new line characters : ");
            Console.WriteLine();
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            /*
             - default line terminator (newline characters) is \r\n
             With the default new line characters :
             
             First Line
             Second Line
             With redefined new line characters : 
             
             
             
             FirstLine
             
             Second Line


             */

            Console.Out.NewLine = "\r\n"; // Redefine the newline characters to single space.

            ////// WriteLine(char[] buffer , int index , int count)
            char[] letters = { 'y', 'o', 'u', 's', 's', 'e', 'f' };
            Console.WriteLine($"Length of letters : {letters.Length}");
            try
            {
                Console.WriteLine(letters, 2, 4); //  usse
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            //// WriteLine (string format, params object[] arg)


            /*
             
            int firstAmount = 10;
            double secondAmount = 10.05;
            string myString = String.Format("(C) Currency .......... {0,15:C} , (P) Percent ......... {1,20:P}" , firstAmount , secondAmount);

            Is Simular To

            int firstAmount = 10;
            double secondAmount = 10.05;
            string myString = string.Format("(C) Currency .......... {0,15:C} , (P) Percent ......... {1,20:P}", firstAmount, secondAmount);
            Console.WriteLine(myString);

            */


            decimal price1 = 1721548.365445879542m;
            string s1 = String.Format("The current price is {0} per ounce.", price1);
            Console.WriteLine(s1); // The current price is 1721548.365445879542  per ounce.
            string s2 = String.Format("The current price is {0:C} per ounce", price1);
            Console.WriteLine(s2); // The current price is $1,721,548.37  per ounce.
            string s3 = String.Format("The current price is {0:C0} per ounce", price1);
            Console.WriteLine(s3); // The current price is $1,721,548  per ounce.
            string s4 = String.Format("The current price is {0:C1} per ounce", price1);
            Console.WriteLine(s4); // The current price is $1,721,548.4 per ounce.
            string s5 = String.Format("The current price is {0:C2} per ounce", price1);
            Console.WriteLine(s5); // The current price is $1,721,548.37  per ounce.
            string s6 = String.Format("The current price is {0:C5} per ounce", price1);
            Console.WriteLine(s6); // The current price is $1,721,548.36545  per ounce.
            string s7 = String.Format("The current price is {0:C7} per ounce", price1);
            Console.WriteLine(s7); // The current price is $1,721,548.3654459  per ounce.


            double temperature = 20.5;
            string currentTemp = String.Format("At {0} , the temperature is : {1} °C.", DateTime.Now, temperature);
            Console.WriteLine(currentTemp);

            DateTime dateTime1 = DateTime.Now;
            Console.WriteLine("It is now {0:d} at {0:t}", dateTime1);



            double n1 = -12445.67892458;
            string str1 = String.Format($"Value : {n1}");
            Console.WriteLine(str1); // Value : -12445.67892458
            string str2 = String.Format($"Value : {n1:N0}");
            Console.WriteLine(str2); // Value : -12,446
            string str3 = String.Format($"Value : {n1:N1}");
            Console.WriteLine(str3); // Value : -12,445.7
            string str4 = String.Format($"Value : {n1:N}");
            Console.WriteLine(str4); // Value : -12,445.68
            string str5 = String.Format($"Value : {n1:N2}");
            Console.WriteLine(str5); // Value : -12,445.68
            string str6 = String.Format($"Value : {n1:N5}");
            Console.WriteLine(str6); // Value : -12,445.67892



            double n2 = 1234.5675;
            string str7 = String.Format($"Value : {n2}");
            Console.WriteLine(str7); // Value : 1,234.5675
            string str8 = String.Format($"Value : {n2:N0}");
            Console.WriteLine(str8); // Value : 1,235
            string str9 = String.Format($"Value : {n2:N1}");
            Console.WriteLine(str9); // Value : 1,234.6
            string str10 = String.Format($"Value : {n2:N}");
            Console.WriteLine(str10); // Value : 1,234.57
            string str11 = String.Format($"Value : {n2:N2}");
            Console.WriteLine(str11); // Value : 1,234.57
            string str12 = String.Format($"Value : {n2:N5}");
            Console.WriteLine(str12); // Value : 1,234.56750


            int[] years = { 2013, 2014, 2015 };
            int[] populations = { 1025632, 1105967, 1148203 };

            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format($"{"Year",6}{"Population",15}\n\n"));
            for (int i = 0; i < years.Length; i++)
            {
                sb.Append(String.Format($"{years[i],6}{populations[i],15:N0}\n"));
            }
            Console.WriteLine(sb);

            String s = String.Format("{0,-6} {1,-15}\n\n", "Year", "Population");
            for (int i = 0; i < years.Length; i++)
            {
                s += String.Format("{0,-16} {1,-15:N0}\n",
                                   years[i], populations[i]);
            }
            Console.WriteLine($"\n{s}");


            DateTime dt = new DateTime(2012, 1, 17, 9, 30, 0);
            string city = "Chicago";
            int temp = -16;
            string output1 = String.Format("At {0} in {1} the temperature was {2} degrees", dt, city, temp);
            string output2 = String.Format($"At {dt} in {city} the temperature was {temp} degrees");
            Console.WriteLine(output1); // At 1/17/2012 9:30:00 AM in Chicago the temperature was -16 degrees
            Console.WriteLine(output2); // At 1/17/2012 9:30:00 AM in Chicago the temperature was -16 degrees


            // the format item (zero-based indexed placeholders) : {index[,alignment][:formatString]} => example : {1,-15:C2}
            // {6324}
            decimal val1 = 126347.894562m;
            string strin1 = String.Format("{0,-10:C}", val1);
            Console.WriteLine(strin1); //$126,347.89
            string strin2 = String.Format($"{val1,-10:C}");
            Console.WriteLine(strin2); //$126,347.89
            string string3 = String.Format("{0}{1,-10:C0}{2}", "{", val1, "}");
            Console.WriteLine(string3);  //{$126,348  }
            try
            {
                string string4 = String.Format($"{"{"}{val1,-10:C0}{"}"}");
                Console.WriteLine(string4);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            string string5 = null;
            Console.WriteLine("Empty String : {0}{1}{2}", "{", string5, "}"); // Empty String : {}



            DateTime dt1 = new DateTime(8, 12, 1);
            DateTime dt2 = new DateTime(18, 12, 1);
            DateTime dt3 = new DateTime(2008, 12, 1);
            DateTime dt4 = new DateTime(2018, 12, 1);
            //DateTime dt2 = new DateTime(1, 12, 1);
            Console.WriteLine(String.Format("{0:y}", dt1)); // "y" format specifier it's interpereted like a standard date and time format specifier => December 2018
            Console.WriteLine(String.Format("{0:%y}", dt1)); // 8
            Console.WriteLine(String.Format("{0:%y}", dt2)); // 18
            Console.WriteLine(String.Format("{0:%y}", dt3)); // 8
            Console.WriteLine(String.Format("{0:%y}", dt4)); // 18

            Console.WriteLine(String.Format("{0:yy}", dt1)); // 08
            Console.WriteLine(String.Format("{0:yy}", dt2)); // 18
            Console.WriteLine(String.Format("{0:yy}", dt3)); // 08
            Console.WriteLine(String.Format("{0:yy}", dt4)); // 18

            Console.WriteLine(String.Format("{0:yyy}", dt1)); // 008
            Console.WriteLine(String.Format("{0:yyy}", dt2)); // 018
            Console.WriteLine(String.Format("{0:yyy}", dt3)); // 2008
            Console.WriteLine(String.Format("{0:yyy}", dt4)); // 2018

            Console.WriteLine(String.Format("{0:yyyy}", dt1)); // 0008
            Console.WriteLine(String.Format("{0:yyyy}", dt2)); // 0018
            Console.WriteLine(String.Format("{0:yyyy}", dt3)); // 2008
            Console.WriteLine(String.Format("{0:yyyy}", dt4)); // 2018

            Console.WriteLine(String.Format("{0:yyyyy}", dt1)); // 00008
            Console.WriteLine(String.Format("{0:yyyyy}", dt2)); // 00018
            Console.WriteLine(String.Format("{0:yyyyy}", dt3)); // 02008
            Console.WriteLine(String.Format("{0:yyyyy}", dt4)); // 02018



            double doubleNumber1 = -12458234.568921354123;
            double doubleNumber2 = 8424234.58215;
            string st1 = String.Format("{0:N0}", doubleNumber1);
            Console.WriteLine(st1); // -12,458,235
            string st2 = String.Format("{0:N1}", doubleNumber1);
            Console.WriteLine(st2); // -12,458,234.6
            string st3 = String.Format("{0:N}", doubleNumber1);
            Console.WriteLine(st3); // -12,458,234.57
            string st4 = String.Format("{0:N2}", doubleNumber1);  // N = N2
            Console.WriteLine(st4);// -12,458,234.57
            string st5 = String.Format("{0:N7}", doubleNumber1);
            Console.WriteLine(st5); // -12,458,234.5689214

            string st6 = String.Format("{0:N0}", doubleNumber2);
            Console.WriteLine(st6); // 8,424,235
            string st7 = String.Format("{0:N1}", doubleNumber2);
            Console.WriteLine(st7); // 8,424,234.6
            string st8 = String.Format("{0:N}", doubleNumber2);
            Console.WriteLine(st8); // 8,424,234.58
            string st9 = String.Format("{0:N2}", doubleNumber2);  // N = N2
            Console.WriteLine(st9); // 8,424,234.58
            string st10 = String.Format("{0:N7}", doubleNumber2);
            Console.WriteLine(st10); // 8,424,234.5821500



            int integerNumber = 12;
            string strg1 = String.Format("{0:P0}", integerNumber);
            Console.WriteLine(strg1); // 1,200%
            string strg2 = String.Format("{0:P1}", integerNumber);
            Console.WriteLine(strg2); // 1,200.0%
            string strg3 = String.Format("{0:P}", integerNumber);
            Console.WriteLine(strg3); // 1,200.00%
            string strg4 = String.Format("{0:P2}", integerNumber);
            Console.WriteLine(strg4); // 1,200.00%
            string strg5 = String.Format("{0:P6}", integerNumber);
            Console.WriteLine(strg5); // 1,200.000000%

            double dbNumber = -54.6523;
            string strg6 = String.Format("{0:P0}", dbNumber);
            Console.WriteLine(strg6);  // -5,465%
            string strg7 = String.Format("{0:P1}", dbNumber);
            Console.WriteLine(strg7);  // -5,465.2%
            string strg8 = String.Format("{0:P}", dbNumber);
            Console.WriteLine(strg8);  // -5,465.23%
            string strg9 = String.Format("{0:P2}", dbNumber);
            Console.WriteLine(strg9);  // -5,465.23%
            string strg10 = String.Format("{0:P6}", dbNumber);
            Console.WriteLine(strg10); // -5,465.230000%




            Tuple<string, DateTime, int, DateTime, int>[] infoCities =
            {
                Tuple.Create("Los Angeles", new DateTime(1940, 1, 1), 1504277, new DateTime(1950, 1, 1), 1970358),
                Tuple.Create("New York", new DateTime(1940, 1, 1), 7454995, new DateTime(1950, 1, 1), 7891957),
                Tuple.Create("Chicago", new DateTime(1940, 1, 1), 3396808, new DateTime(1950, 1, 1), 3620962),
                Tuple.Create("Detroit", new DateTime(1940, 1, 1), 1623452, new DateTime(1950, 1, 1), 1849568)
            };
            string header = String.Format("{0,-12}{1,8}{2,12}{3,8}{4,12}{5,14}", "City", "Year", "Population", "Year", "Population", "Change (%)");
            Console.WriteLine(header);

            foreach (var infoCity in infoCities)
            {
                string res = String.Format("{0,-12}{1,8:yyyy}{2,12:N0}{3,8:yyyy}{4,12:N0}{5,14:P1}", infoCity.Item1, infoCity.Item2, infoCity.Item3, infoCity.Item4, infoCity.Item5, (infoCity.Item5 - infoCity.Item3) / (double)infoCity.Item3);
                Console.WriteLine(res);
                Console.WriteLine((infoCity.Item5 - infoCity.Item3) / (double)infoCity.Item3);
            }



            // Format a negative integer or floating-point number in various ways.
            Console.WriteLine("Standard Numeric Format Specifiers");
            Console.WriteLine(
                "(C) Currency: . . . . . . . . {0:C}\n" +
                "(D) Decimal:. . . . . . . . . {0:D}\n" +
                "(E) Scientific: . . . . . . . {1:E}\n" +
                "(F) Fixed point:. . . . . . . {1:F}\n" +
                "(G) General:. . . . . . . . . {0:G}\n" +
                "    (default):. . . . . . . . {0} (default = 'G')\n" +
                "(N) Number: . . . . . . . . . {0:N}\n" +
                "(P) Percent:. . . . . . . . . {1:P}\n" +
                "(R) Round-trip: . . . . . . . {1:R}\n" +
                "(X) Hexadecimal:. . . . . . . {0:X}\n",
                -123, -123.45f);

            // Format the current date in various ways.
            Console.WriteLine("Standard DateTime Format Specifiers");
            Console.WriteLine(
                "(d) Short date: . . . . . . . {0:d}\n" +
                "(D) Long date:. . . . . . . . {0:D}\n" +
                "(t) Short time: . . . . . . . {0:t}\n" +
                "(T) Long time:. . . . . . . . {0:T}\n" +
                "(f) Full date/short time: . . {0:f}\n" +
                "(F) Full date/long time:. . . {0:F}\n" +
                "(g) General date/short time:. {0:g}\n" +
                "(G) General date/long time: . {0:G}\n" +
                "    (default):. . . . . . . . {0} (default = 'G')\n" +
                "(M) Month:. . . . . . . . . . {0:M}\n" +
                "(R) RFC1123:. . . . . . . . . {0:R}\n" +
                "(s) Sortable: . . . . . . . . {0:s}\n" +
                "(u) Universal sortable: . . . {0:u} (invariant)\n" +
                "(U) Universal full date/time: {0:U}\n" +
                "(Y) Year: . . . . . . . . . . {0:Y}\n",
                thisDate);

            // Format a Color enumeration value in various ways.
            Console.WriteLine("Standard Enumeration Format Specifiers");
            Console.WriteLine(
                "(G) General:. . . . . . . . . {0:G}\n" +
                "    (default):. . . . . . . . {0} (default = 'G')\n" +
                "(F) Flags:. . . . . . . . . . {0:F} (flags or integer)\n" +
                "(D) Decimal number: . . . . . {0:D}\n" +
                "(X) Hexadecimal:. . . . . . . {0:X}\n",
                Color.Green);

        }
    }

}
