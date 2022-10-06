using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        public void Strings()
        {
            // Formatting
            /*
             
            ToLower() => Convert all characters to lowercase
            ToUppers() => Convert all characters to uppercase
            Trim() => Removes all leading and trailing white-space characters from the current string.

            */

            string country = "Japan";
            Console.WriteLine(country.ToLower());
            string city = "Tokyo";
            Console.WriteLine(city.ToUpper());

            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("You entered '{0}', '{1}'.",
                            firstName, lastName);

            string name = firstName.Trim() + " " + lastName.Trim();
            Console.WriteLine("The result is " + name + ".");

            // Searching
            /*
             
            IndexOf("string") =>  Reports the zero-based index of the first occurrence of the specified string in this instance.
            LastIndexOf("string") => Reports the zero-based index position of the last occurrence of a specified string within this instance.
            IndexOf('char') => Reports the zero-based index of the first occurrence of the specified Unicode character in this string.
            LastIndexOf('char') => Reports the zero-based index of the last occurrence of the specified Unicode character in this string.

             */

            string stringTest = "hi hello youssef baba hello omar baba";
            Console.WriteLine(stringTest.IndexOf("hello")); // 3
            Console.WriteLine(stringTest.IndexOf("baba")); // 17
            Console.WriteLine(stringTest.LastIndexOf("hello")); // 22
            Console.WriteLine(stringTest.LastIndexOf("baba")); // 33
            Console.WriteLine(stringTest.IndexOf('y')); // 9
            Console.WriteLine(stringTest.IndexOf('b')); // 17
            Console.WriteLine(stringTest.LastIndexOf('b')); // 35

            // Substrings
            /*
             * 
            Substring(startIndex) => Returns a substring from this instance. The substring starts at a specified character position and continues to the end of the string.
            Substring(startIndex , length) => Returns a substring from this instance. The substring starts at a specified character position and has a specified length.

            */

            string stringTestOne = "hi hello youssefbaba , how are you ?";
            Console.WriteLine(stringTestOne.Length); // 37
            string substringOne = stringTestOne.Substring(3);
            Console.WriteLine(substringOne); // "hello youssef baba , how are you ?"
            string substringTwo = stringTestOne.Substring(9, 7);
            Console.WriteLine(substringTwo); // youssef

            // Replace
            /*
             Replace('oldChar' , 'newChar') => Returns a new string in which all occurrences of a old character in this instance are replaced with new character.
             Replace("oldstring" , "newstring") => Returns a new string in which all occurrences of a old string in the current instance are replaced with new string
             

            */

            string stringNumbers = "1 2 3 4 5 6 7 8 9";
            string replaceStringNumbers = stringNumbers.Replace(' ', ',');
            Console.WriteLine(replaceStringNumbers); // "1,2,3,4,5,6,7,8,9"
            string errString = "This docment uses 3 other docments to docment the docmentation";
            string correctString = errString.Replace("docment", "document");
            Console.WriteLine(correctString); // "This document uses 3 other documents to document the documentation"

            /*
             
            String.IsNullOrEmpty("string") => Indicates whether the specified string is null or an empty string ("").
            String.IsNullOrWhiteSpace("string") => Indicates whether a specified string is null, empty string (""), or consists only of white-space characters.
            - The term “white space” includes all characters that are not visible on screen. For example, space, line break("\n"), tab("\t") and empty string ("") are white space characters.

            */
            string nullString = null;
            string emptyString = "";
            string whitespaceString = "    ";
            string nonEmptyString = "abc123";

            bool result;

            result = String.IsNullOrEmpty(nullString);
            Console.WriteLine(result); // true 
            result = String.IsNullOrEmpty(emptyString);
            Console.WriteLine(result); // true
            result = String.IsNullOrEmpty(whitespaceString);
            Console.WriteLine(result); // false
            result = String.IsNullOrEmpty(nonEmptyString);
            Console.WriteLine(result); // false

            result = String.IsNullOrWhiteSpace(nullString);
            Console.WriteLine(result); // true
            result = String.IsNullOrWhiteSpace(emptyString);
            Console.WriteLine(result); // true
            result = String.IsNullOrWhiteSpace(whitespaceString);
            Console.WriteLine(result); // true
            result = String.IsNullOrWhiteSpace(nonEmptyString);
            Console.WriteLine(result); // false

            //Splitting
            /*
             Split(char[]) => Splits a string into substrings based on specified delimiting characters.
             
             */
            string stringTestTwo = "This is a short string.";
            string[] substringTestTwo = stringTestTwo.Split('s');
            foreach (string substring in substringTestTwo)
            {
                Console.WriteLine(substring);
            }
            //Thi
            // i
            // a 
            //hort 
            //tring.
            Console.WriteLine();
            string stringTestThree = "Today\tI'm going to school";
            string[] substringTestThree = stringTestThree.Split('\t', ' ');
            foreach (string substring in substringTestThree)
            {
                Console.WriteLine(substring);
            }
            //Today
            //I'm
            //going
            //to 
            //school
            Console.WriteLine();

            // Converting String To Integer
            string stringTestFour = "123456";
            int i = int.Parse(stringTestFour);
            int j = Convert.ToInt32(stringTestFour); // Best way to convert string to integer 

            // Converting Integer To String 
            int numberOne = 123456;
            string stringNumberOne = numberOne.ToString();
            Console.WriteLine(stringNumberOne);
            string stringNumberTwo = numberOne.ToString("C0");
            Console.WriteLine(stringNumberTwo); // $123,456
            string stringNumberThree = numberOne.ToString("C1");
            Console.WriteLine(stringNumberThree); // $123,456.0
            string stringNumberFour = numberOne.ToString("C");
            Console.WriteLine(stringNumberFour); // $123,456.00
        }
    }
}
