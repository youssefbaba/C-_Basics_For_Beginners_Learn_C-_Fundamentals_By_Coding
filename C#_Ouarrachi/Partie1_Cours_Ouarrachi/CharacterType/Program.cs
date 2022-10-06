using System;


namespace CharacterType
{
    internal class Program
    {
        static void Main()
        {
            // the char type is an alias of .Net type System.Char

            char letterOne = 'a';
            Console.WriteLine($"size of {nameof(letterOne)} is : {sizeof(char)} bytes");
            System.Char letterTwo = 'b';
            Console.WriteLine($"size of {nameof(letterTwo)} is : {sizeof(char)} bytes");


            char minValueOne = char.MinValue; // 0x0000
            char maxValueOne = char.MaxValue; // 0xffff
            Console.WriteLine($"'{minValueOne}'");
            Console.WriteLine($"'{maxValueOne}'");


            int minValueTwo = char.MinValue; // 0
            int maxValueTwo = char.MaxValue; // 65535
            Console.WriteLine($"the range of char is from U+{minValueTwo:x4} to U+{maxValueTwo:x4}");


            char test = 'a';
            Console.WriteLine($"{test}"); // char  = 'a'
            Console.WriteLine($"{(int)test + 3}"); // decimal = 97 + 3 = 100 
            Console.WriteLine($"{(int)test:x4}"); // hexadecimal = 0061


            char val = (char)0x30;
            Console.WriteLine($"'{val}'"); // '0'

            // The default value of the char type is \0, that is '\0'.

            // comparison
            if ('f' >= 'z') // f = 66 in hexa code and z = 7A in hexa code so  7A  > 66 =>  z > f
            {
                Console.WriteLine($"{'f'} less than {'z'}");
            }
            else
            {
                Console.WriteLine($"{'z'} greater than {'f'}");
            }

            // Equality

            if ('g' == 'k') // g = 67 in hexa code and k = 6B in hexa code so g != k  
            {
                Console.WriteLine($"{'g'} Equal {'k'}");
            }
            else
            {
                Console.WriteLine($"{'g'} Not equal {'k'}");
            }

            // Increment

            char inc = 't';
            Console.WriteLine(inc++); // t
            Console.WriteLine(inc); // u


            // Arithmetic
            Console.WriteLine('b' + 't'); // 98 + 116 = 214
            Console.WriteLine('b' * 't'); // 98 * 116 = 11368

            //The string type represents text as a sequence of char values.

            string name = "youssefbaba";
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"the type of '{name[i]}' is {name[i].GetType()}");
            }


            // Literals
            var chars = new[] {
                'z',        // a character literal.
                '\u007A',   // Unicode escape sequence
                '\x7A',    // hexadecimal escape sequence
                (char)122  // cast of int to char
            };
            Console.WriteLine(String.Join(" ", chars));


            // Conversions
            int letterA = 'a'; // implicit convertsion from char type to int type
            Console.WriteLine($"the type of {letterA} is {letterA.GetType().Name}"); // the type of 97 is Int32

            double letterY = 'y'; // implicit conversion from char type to double type
            Console.WriteLine($"the type of {letterY} is {letterY.GetType().Name}"); // the type of 121 is Double

            char letterC = (char)99; // explicit conversion from int type to char type
            Console.WriteLine($"the type of '{letterC}' is {letterC.GetType().Name}");  // the type of 'c' is Char

        }
    }
}
