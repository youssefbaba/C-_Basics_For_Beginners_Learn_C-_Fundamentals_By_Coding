using System;

namespace BooleanType
{
    internal class Program
    {
        static void Main()
        {
            // the bool type keyword is an alias of .Net type System.Boolean , which can be either true or false .

            bool check = true;
            Console.WriteLine($"the type of {nameof(check)} is {check.GetType().Name}");
            System.Boolean login = false;
            Console.WriteLine($"the type of {nameof(login)} is {login.GetType().Name}");

            // The default value of the bool type is false.

            // Literals
            bool open = true;
            Console.WriteLine(open ? "Opened" : "Not opened"); // Opened
            Console.WriteLine(false ? "Opened" : "Not opened"); // Not Opened


            // Conversions (bool)
            // - implicit conversion from bool type (bool) to the corresponding nullable bool type (bool?)

            bool valueOne = true; // bool type
            bool? valueTwo = valueOne; // nullable bool type , implicit conversion
            Console.WriteLine(valueTwo); //true

            // - explicit conversion from nullable bool type (bool?) to bool type (bool)

            bool? valueThree = false; // nullable bool type
            bool valueFour = (bool)valueThree; // explicit conversion
            Console.WriteLine(valueFour); // false



            // conversion between Boolean and Char not supported

            try
            {
                char test1 = 'g';
                Console.WriteLine(Convert.ToBoolean(test1));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                bool test2 = true;
                Console.WriteLine(Convert.ToChar(test2));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // conversion between Boolean and DateTime not supported

            try
            {
                DateTime date = DateTime.Now;
                Console.WriteLine(Convert.ToBoolean(date));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                bool test3 = false;
                Console.WriteLine(Convert.ToDateTime(test3));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // all conversions from integer numbers or real numbers to boolean convert non-zero value to true and zero value to false

            byte byteValueOne = 12;   // Not Equal Zero
            Console.WriteLine(Convert.ToBoolean(byteValueOne)); // true
            byte byteValueTwo = 0;  // Equal Zero
            Console.WriteLine(Convert.ToBoolean(byteValueTwo)); // false
            int intValue = -4521; // Not Equal Zero
            Console.WriteLine(Convert.ToBoolean(intValue));  // true
            long longValue = 945;  // Not Equal Zero
            Console.WriteLine(Convert.ToBoolean(longValue)); // true
            double dblValue = 0; // Equal Zero
            Console.WriteLine(Convert.ToBoolean(dblValue)); // false
            float sngValue = 0.0001f; // Not Equal Zero
            Console.WriteLine(Convert.ToBoolean(sngValue)); // true

            // When converting from Boolean to numeric values (Integer Number or Real Number), the conversion methods of the Convert class convert true to 1 and false to 0


            bool flag = true;
            byte byteValueThree = Convert.ToByte(flag);
            Console.WriteLine($"{flag} -> {byteValueThree}"); // true -> 1
            float floatValue = Convert.ToSingle(flag);
            Console.WriteLine($"{flag} -> {floatValue}"); // true -> 1

            bool log = false;
            int intValueTwo = Convert.ToInt32(log);
            Console.WriteLine($"{log} -> {intValueTwo}"); // false -> 0
            double doubleValue = Convert.ToDouble(log);
            Console.WriteLine($"{log} -> {doubleValue}"); // false -> 0


            // conversions from Boolean to string values
            // the string representation for true value is "True" and for false value is "False"

            string trueString = Boolean.TrueString;
            Console.WriteLine($"\"{trueString}\"");
            string falseString = Boolean.FalseString;
            Console.WriteLine($"\"{falseString}\"");


            bool raining = true;
            bool buslate = false;
            Console.WriteLine($"It is raining : {raining}");  // ToString method is called implicitly
            Console.WriteLine($"the bus is late : {buslate}");  // ToString method is called implicitly


            Console.WriteLine($"It is raining : {(raining ? "Yes" : "No")}");
            Console.WriteLine($"the bus is late : {(buslate ? "Yes" : "No")}");


            // conversions from strings to Boolean values
            string[] values = {
                null,
                String.Empty,
                "True",
                "False",
                "true",
                "false",
                "    true    ",
                "TrUe",
                "fAlSe",
                "fa lse",
                "0",
                "1",
                "-1",
                "string"
            };

            foreach (string value in values)
            {
                try
                {
                    bool stringToBool = Boolean.Parse(value);
                    Console.WriteLine($"'{value}' -> {stringToBool}");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Cannot parse a null string.");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Cannot parse '{value}'.");
                }
            }
            //  Cannot parse a null string.
            //  Cannot parse ''.
            //  'True' -> True
            //  'False' -> False
            //  'true' -> True
            //  'false' -> False
            //  '    true    ' -> True
            //  'TrUe' -> True
            //  'fAlSe' -> False
            //  Cannot parse 'fa lse'.
            //  Cannot parse '0'.
            //  Cannot parse '1'.
            //  Cannot parse '-1'.
            //  Cannot parse 'string'.
            Console.WriteLine("#############################");

            foreach (string value in values)
            {
                bool result = false;
                if (Boolean.TryParse(value, out result))
                {
                    Console.WriteLine($"'{value}' -> {result}");
                }
                else
                {
                    Console.WriteLine($"Unable to convert '{value}'.");
                }

            }
            //  Unable to convert ''.
            //  Unable to convert ''.
            //  'True' -> True
            //  'False' -> False
            //  'true' -> True
            //  'false' -> False
            //  '    true    ' -> True
            //  'TrUe' -> True
            //  'fAlSe' -> False
            //  Unable to convert 'fa lse'.
            //  Unable to convert '0'.
            //  Unable to convert '1'.
            //  Unable to convert '-1'.
            //  Unable to convert 'string'.

            Console.WriteLine("##################################");

            String[] numbers = { "09", "12.6", "0", "-13 " };
            foreach (string number in numbers)
            {
                int result;
                bool success = int.TryParse(number, out result);
                if (success)
                {
                    Console.WriteLine($"Converted '{number}' to {success}");
                }
                else
                {
                    Console.WriteLine($"Unable to convert '{number}'");
                }
            }
            // Converted '09' to True
            // Unable to convert '12.6'
            // Converted '0' to False
            // Converted '-13' to True
        }
    }
}
