using System;

namespace TestStrings
{
    public class Program
    {
        // String is a sequences of characters 
        char singleCharacter = 'B';
        string country = "Japan";
        //String language = "English";
        int number;
        //Int32 number1 ;

        public static void Main()
        {
            string firstName = "youssef";
            string lastName = "baba";
            string myName = firstName + " " + lastName;
            Console.WriteLine(myName);
            string fullName = string.Format("My name is {0}{1}", firstName , lastName);
            Console.WriteLine(fullName);
            string[] names = new string[3] {"YoussefBaba", "HassnaBaba", "OmarAderahmane"};
            string formattedNames = string.Join("-", names);
            Console.WriteLine(formattedNames);
            string gender = "Male";
            for(int i = 0; i<gender.Length; i++)
            {
                Console.WriteLine("character {0} : {1} ", i , gender[i]) ;
            }

            //string text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            string text = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}
