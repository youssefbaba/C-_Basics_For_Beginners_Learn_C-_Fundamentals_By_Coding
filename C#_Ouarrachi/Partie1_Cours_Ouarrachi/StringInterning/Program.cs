using System;
using System.Text;

namespace StringInterning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Whenever we define a string literal, it will be interned automatically. This means when we create more string literals with the same content, they will all reference to the same object in intern pool.
            // The idea is simple: when several literal strings are equal, the different handles will point to only one instance. This saves memory and makes string comparison more efficient.

            // Directly assigning a string literal
            string str1 = "hiho";
            string str2 = @"koko";
            // Created Dynamically
            // - By using the new keyword when calling the constructor of String class
            string str3 = new String('h', 4);
            char[] letters = new char[] { 'b', 'o', 'b', 'o' };
            string str4 = new String(letters);
            // - By converting a StringBuilder object to String object.
            string str5 = new StringBuilder("goko").Append("fsr").ToString();
            // - By programmatically creating a String object i.e. by concatenating two string objects by + operator or by some other way.
            string str6 = String.Concat("yousef", "baba");
            string str7 = "dsed";
            string str8 = "sazeq";
            string str9 = str7 + str8;
            string str10 = str7 + "fdtg";



            // String objects (string) created by directly assigning a String literals
            string strin1 = "Hello";
            string strin2 = "Hello";

            // Creating char array
            char[] characters = new char[] { 'H', 'l', 'l', 'o' };

            // Dynamically creating a String object from char array
            string strin3 = new string(characters);


            //Creating a String object in intern pool by directly assigning a String literal value
            string name1 = "youssef"; // Created by directly assigning a String literal
            //Creating a String object in intern pool by directly assigning a duplicate String literal value
            string name2 = "youssef"; // Created by directly assigning a String literal
            //Creating a String object in intern pool by directly assigning a String literal value
            string name3 = "youssef youssef"; // Created by Directly assigning a String literal
            // Creating a char array
            char[] chars = new char[] { 'y', 'o', 'u', 's', 's', 'e', 'f' };
            //Dynamically creating a String object from a char[] array.
            string name4 = new String(chars); // Created Dynamically : By using the new keyword when calling the constructor of String class
            //Dynamically creating a String object by calling converting a StringBuilder to String object.
            string name5 = new StringBuilder().Append("youssef").ToString(); // Created Dynamically : By converting a StringBuilder object to String object
            //Dynamically creating a String object by programmatically adding two String objects
            string name6 = name1 + name1; // Created Dynamically : by concatenating two string objects

            //Calling the static method ReferenceEquals(), to check for the equality of references.
            Console.WriteLine($"Do name1 and name2 point to a same String object ? {Object.ReferenceEquals(name1, name2)}");
            Console.WriteLine($"Do name1 and name5 point to a same String object ? {Object.ReferenceEquals(name1, name5)}");
            Console.WriteLine($"Do name4 and name5 point to a same String object ? {Object.ReferenceEquals(name4, name5)}");
            Console.WriteLine($"Do name3 and name6 point to a same String object ? {Object.ReferenceEquals(name3, name6)}");

            /*
             Do name1 and name2 point to a same String object ? True 
             Do name1 and name5 point to a same String object ? False
             Do name4 and name5 point to a same String object ? False
             Do name3 and name6 point to a same String object ? False
             */


            string strin4 = "Omar";
            string strin5 = strin4.ToLower();
            Console.WriteLine(string.IsInterned(strin4)); // Interned string
            Console.WriteLine(string.IsInterned(strin5)); // Not Interned string

        }
    }
}
