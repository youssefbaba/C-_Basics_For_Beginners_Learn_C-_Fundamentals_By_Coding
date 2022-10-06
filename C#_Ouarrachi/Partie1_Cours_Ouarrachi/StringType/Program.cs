using System;
using System.Text;

namespace StringType
{
    internal class Program
    {
        static void Main()
        {
            // string is an alias of .Net type System.String

            string textOne = "Hello Youssef";
            Console.WriteLine($"the type of {nameof(textOne)} is : {textOne.GetType().Name}");
            System.String textTwo = "Hello Omar";
            Console.WriteLine($"the type of {nameof(textTwo)} is : {textTwo.GetType().Name}");
            string textThree = "";
            Console.WriteLine($"length of {nameof(textThree)} is {textThree.Length}");
            for (int i = 0; i < textOne.Length; i++)
            {
                Console.WriteLine($"char[{i}] = {textOne[i]}");
            }


            string valueOne = "Hello";
            string valueTwo = "H";
            valueTwo += "ello"; // concatenation
            Console.WriteLine(valueTwo); // Hello
            Console.WriteLine(valueOne == valueTwo); // Hello == Hello => True
            Console.WriteLine(object.ReferenceEquals(valueOne, valueTwo));  // False


            string concatenateStrings = "Good" + " " + "morning";
            Console.WriteLine(concatenateStrings);

            string str = "test";
            for (int i = 0; i < str.Length; i++)
            {
                // 0 to (str.Length - 1)
                // i = 0 , t 
                // i = 1 , e
                // i = 2 , s
                // i = 3 , t
                Console.WriteLine(str[i]);
            }


            // String literals
            // String literals are of type string and can be written in three forms, raw, quoted, and verbatim.

            //- Quoted string literals :  => "some text here ..."

            string test = "heloo \"youssef\" \\\u0066\n F \x007A \'baba\'";
            Console.WriteLine(test);
            // hello "youssef" \f
            // F z 'baba'


            //- Verbatim string literals :  => @"some text here ..."
            // in the verbatim strings the escape sequences aren't processed like in this case \n does not represent the newline character , but two individual characters: \ and n

            // \n , \t
            string strOne = "Hello\tyoussef\nbaba"; // Quoted string literals
            Console.WriteLine(strOne);
            string strTwo = @"Hello\tyoussef\nbaba"; // Verbatim string literals
            Console.WriteLine(strTwo);

            // \\
            string fileNameOne = "C:\\Docs\\Source\\file.txt"; // Quoted string literals
            Console.WriteLine(fileNameOne);
            string fileNameTwo = @"C:\Docs\Source\file.txt"; // Verbatim string literals
            Console.WriteLine(fileNameTwo);

            // \"

            string strThree = "Hello \"Youssef\" how are you ?"; // Quoted string literals
            Console.WriteLine(strThree);
            string strFour = @"Hello ""Youssef"" how are you ?"; // Verbatim string literals
            Console.WriteLine(strFour);


            string strTest = "test";
            Console.WriteLine(strTest);
            strTest = "hiho";
            Console.WriteLine(strTest);

            PrintChar("Hello");

            // Declaring and Initializing strings : 

            // Declare without initializing 
            string message1;

            //Initialize to null : reference type can take null as a value
            string message2 = null;

            // Initialize as an empty string.
            // Use the Empty constant instead of the literal "".
            string message3 = "";
            string message4 = String.Empty;
            Console.WriteLine($"empty string 1 \"{message3}\" and it's length is {message3.Length}");
            Console.WriteLine($"empty string 2 \"{message4}\" and it's length is {message4.Length}");

            // Initialize with Quoted string literal .
            string oldPath = "C:\\Directory\\Folder\\file.txt";
            Console.WriteLine(oldPath);

            // Initialize with Verbatim string literal
            string newPath = @"C:\Directory\Folder\file.txt";

            // Use a const string to prevent 'message5' from
            // being used to store another string value.
            const string message5 = "You can't get rid of me!";

            // In local variables (i.e. within a method body)
            // you can use implicit typing.

            var message6 = "Hello Youssef";
            Console.WriteLine(message6);

            // Use the String constructor only when creating
            // a string from a char*, char[], or sbyte*. See
            // System.String documentation for details.
            char[] characters = new char[] { 'h', 'e', 'l', 'l', 'o' };
            string message7 = new string(characters);
            Console.WriteLine(message7);


            string message8 = string.Empty;
            if (String.IsNullOrEmpty(message8))
            {
                Console.WriteLine("Empty");
            }
            string message9 = null;
            try
            {
                Console.WriteLine(message9.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (String.IsNullOrEmpty(message9))
            {
                Console.WriteLine("Null");
            }


            // Immutability of strings :
            string s1 = "A string is more ";
            string s2 = "than the sum of its chars.";

            // Concatenate s1 and s2. This actually creates a new
            // string object and stores it in s1, releasing the
            // reference to the original object.
            s1 += s2;   //  creation of new string like s3 (s1+s2) and  s3 assigned to s1
            Console.WriteLine(s1); // A string is more than the sum of its chars
            Console.WriteLine(s2); // than the sum of its chars. 


            string str1 = "Hello ";
            string str2 = str1;
            str1 += "World";
            Console.WriteLine($"the value of {nameof(str2)} is : {str2}"); // Hello
            Console.WriteLine($"the value of {nameof(str1)} is : {str1}"); // Hello World


            // Quoted string literals :  "some texte here ..."
            string columns = "Column 1\tColumn 2\tColumn3";
            Console.WriteLine(columns);
            /*
             Column 1   Column 2    Column 3
             */

            string rows = "Row 1\r\nRow 2\r\nRow 3";
            Console.WriteLine(rows);
            /*
             Row 1
             Row 2
             Row 3
             */
            string title = "Lorem \"ipsum\" dolor sit \'amet\' \u0063onsectetur adipisi\x0063ing elit";
            Console.WriteLine(title); // Lorem "ipsum" dolor sit 'amet' consectetur adipisicing elit

            string pathFile1 = "C:\\Directory\\Subdirectory\\file.txt";
            Console.WriteLine(pathFile1); // "C:\Directory\Subdirectory\file.txt";


            // Verbatim string literals : @"some text here ..."
            // In verbatim strings, there are no character escapes (except for "" which is turned into a ") such as \n interpreted to \ character an n character
            string pathFile2 = @"C:\\Directory\\Subdirectory\\file.txt";
            Console.WriteLine(pathFile2); // C:\\Directory\\Subdirectory\\file.txt

            string fullName = @"Hello\tYoussef\nbaba";
            Console.WriteLine(fullName); // Hello\tYoussef\nbaba

            // strings that contain backslash characters
            string filePath = @"C:\Directory\Subdirectory\file.txt"; // rather the  "C:\\Directory\\Subdirectory\\file.txt"
            Console.WriteLine(filePath); // C:\Directory\Subdirectory\file.txt

            // multi-line strings
            string multiLineString = @"My pensive SARA ! thy soft cheek reclined
            Thus on mine arm, most soothing sweet it is
            To sit beside our Cot,...";
            Console.WriteLine(multiLineString);
            /*
             My pensive SARA ! thy soft cheek reclined
                        Thus on mine arm, most soothing sweet it is
                        To sit beside our Cot,...
             */

            //strings that embedded double quotes
            string doubleQuote = @"His name was ""Youssef""";
            Console.WriteLine(doubleQuote); // His name was "Youssef"



            // Format strings :
            /*
              Format strings are created by embedding interpolated expressions {number1 + number2} or placeholders {0} inside of braces within a string.
              There are two methods to create format strings: string interpolation and composite formatting.
             */


            //- String interpolation
            var details = (firstName: "Jupiter", lastName: "Hammon", born: 1711, published: 1761);
            Console.WriteLine($"{details.firstName} {details.lastName} was an African American poet born in {details.born} ."); // Jupiter Hammon was an African American poet born in 1711.
            Console.WriteLine($"He was first published in {details.published} at the age of {details.published - details.born} ."); // He was first published in 1761 at the age of 50 .
            //string fullNameOne = $"{details.firstName} " + $"{details.lastName}";
            string fullNameOne = $"{details.firstName} {details.lastName}";
            string ageOne = $"{details.published - details.born}";
            Console.WriteLine($"my name is {fullNameOne}"); // my name is Jupiter Hammon
            Console.WriteLine($"age is {ageOne}"); // age is 50


            //- Verbatim string interpolation
            Console.WriteLine($@"{details.firstName} {details.lastName}
              was an African American poet born in {details.born} .");
            /*
            Jupiter Hammon
              was an African American poet born in {details.born} .
            */
            Console.WriteLine($@"He was first published in {details.published}
                    at the age of {details.published - details.born}.");
            /*
            He was first published in 1761
                    at the age of 50.
            */
            //string fullNameTwo = $@"{details.firstName} " + $@"{details.lastName}";
            string fullNameTwo = $@"{details.firstName} {details.lastName}";
            string ageTwo = $@"{details.published - details.born}";
            Console.WriteLine($@"my name is 
                {details.firstName} {details.lastName}");
            /*
            my name is 
                Jupiter Hammon
            */
            Console.WriteLine($@"age is {ageTwo}");

            //- Composite formatting
            Console.WriteLine("{0} {1} was an African American poet born in {2} .", details.firstName, details.lastName, details.born); // Jupiter Jupiter was an African American poet born in 1711 .
            Console.WriteLine("He was first published in {0} at the age of {1} .", details.published, (details.published - details.born)); // He was first published in 1761 at the age of 50 . 
            string fullNameThree = String.Format("my name is {0} {1}", details.firstName, details.lastName);
            Console.WriteLine(fullNameThree); // my name is Jupiter Hammon
            string ageThree = String.Format("{0}", details.published - details.born);
            Console.WriteLine("age is {0}", ageThree); // age is 50

            // Substrings : 
            string s3 = "Visual C# Express";
            string subStringOne = s3.Substring(5); //  0 <= 5 <= length of string 
            Console.WriteLine(subStringOne); // l C# Express 
            string subStringTwo = s3.Substring(s3.Length);
            Console.WriteLine(subStringTwo); //  Empty string

            try
            {
                //string subStringFour = s3.Substring(-1); // startIndex less than zero
                //Console.WriteLine(subStringFour);

                string subStringFour = s3.Substring(s3.Length + 2);  //  startIndex greater than Length of original string
                Console.WriteLine(subStringFour);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            string[] infos = new string[] { "Name: Felica Walker", "Title: Mz.",
                   "Age: 47", "Location: Paris", "Gender: F"};
            Console.WriteLine("The initial values in the array are:");
            foreach (string info in infos)
            {
                Console.WriteLine(info);
            }
            Console.WriteLine("We want to retrieve only the key information. That is:");
            foreach (string info in infos)
            {
                int position = info.IndexOf(':');
                Console.WriteLine(info.Substring(position + 2));
            }

            string[] pairs = new string[] {"Color1=red", "Color2=green", "Color3=blue",
                 "Title=Code Repository"};

            Console.WriteLine("The example displays the following output:");
            foreach (string pair in pairs)
            {
                int position = pair.IndexOf("=");
                string key = pair.Substring(0, position);
                //Console.WriteLine(key);
                string value = pair.Substring(position + 1);
                //Console.WriteLine(value);
                Console.WriteLine($"key: {key}, Value: '{value}'");
            }


            string s4 = "some text ";
            Console.WriteLine(s4.Substring(1, 6)); // ome te
            Console.WriteLine(s4.Substring(s4.Length, 0)); // startIndex equal length of s4 and length equal 0 =>   Empty string

            try
            {
                //string subString = s4.Substring(-1,5); // startIndex cannot be less than zero
                string subString = s4.Substring(2, -3); // Length cannot be less than zero 
                Console.WriteLine(subString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                string subString = s4.Substring(2, 10); // startIndex and lenght must refer to a location within the string
                Console.WriteLine($"'{subString}'");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            String s5 = "This is a string.";
            int startIndex = 5;
            int length = 2;
            string newStringOne = "", newStringTwo = "";
            string subStringThree = s5.Substring(startIndex, length);
            for (int i = 0; i < startIndex; i++)
            {
                newStringOne += " ";
            }
            for (int i = startIndex + 2; i < s5.Length; i++)
            {
                newStringTwo += " ";
            }
            Console.WriteLine("The example displays the following output:");
            Console.WriteLine(newStringOne + subStringThree + newStringTwo);


            string myString = "abc";
            bool test1 = myString.Substring(2, 1).Equals("c");
            Console.WriteLine(test1); // True
            bool test2 = String.IsNullOrEmpty(myString.Substring(3, 0)); // because  myString.Substring(3, 0) => Empty string
            Console.WriteLine(test2); // True

            try
            {
                string subStr = myString.Substring(3, 1);
                Console.WriteLine(subStr);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            String[] informations = { "Color1=red", "Color2=green", "Color3=blue",
                 "Title=Code Repository" };
            foreach (string information in informations)
            {
                int position = information.IndexOf('=');
                string key = information.Substring(0, position);
                string value = information.Substring(position + 1, (information.Length - (position + 1)));
                Console.WriteLine($"Key: {key}, Value: '{value}'");
            }


            string myStringTwo = "aaaaabbbcccccccdd";
            int startIndx = myStringTwo.IndexOf('b');
            Console.WriteLine(startIndx); // 5
            int endIndx = myStringTwo.LastIndexOf('b');
            Console.WriteLine(endIndx); // 7
            int lengthEle = endIndx - startIndx + 1;
            Console.WriteLine(lengthEle); // 3
            Console.WriteLine("The example displays the following output:");
            Console.WriteLine($"{myStringTwo}.Substring({startIndx},{lengthEle}) = {myStringTwo.Substring(startIndx, lengthEle)}");


            Console.WriteLine("####################################");
            try
            {
                string myStringThree = "<term>extant<definition>still in existence</definition></term>";
                string searchStringThree = "<definition>";
                int startIndexThree = myStringThree.IndexOf(searchStringThree);
                //Console.WriteLine(startIndexThree); // 12
                string endStringThree = "</" + searchStringThree.Substring(1);
                //Console.WriteLine(endStringThree); // </definition>
                int endIndexThree = myStringThree.IndexOf(endStringThree);
                //Console.WriteLine(endIndexThree); // 42
                int subStringLenght = endIndexThree - startIndexThree + endStringThree.Length;
                //Console.WriteLine(subStringLenght); // 43
                Console.WriteLine("The example displays the following output:");
                Console.WriteLine($"Original string: {myStringThree}");
                Console.WriteLine($"Substring: {myStringThree.Substring(startIndexThree, subStringLenght)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("####################################");
            try
            {
                string myStringFour = "<term>extant<definition>still in existence</definition></term>";
                string subStringFour = myStringFour.Substring(0, myStringFour.Length);
                Console.WriteLine(subStringFour); // <term>extant<definition>still in existence</definition></term>
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("#################### IndexOf(Char) ######################");

            string myStringFive = "dddddddddtddddd";
            Console.WriteLine(myStringFive.IndexOf('b')); // -1
            Console.WriteLine(myStringFive.IndexOf('t')); // 9

            string newStringThree = new string('b', 10);
            Console.WriteLine(newStringThree); // bbbbbbbbbb

            char[] letters = new char[] { 'a', 'b', 'c' };
            string newStringFour = new string(letters);
            Console.WriteLine(newStringFour); // abc

            // Create a Unicode string with 5 Greek Alpha characters.
            string greekAlpha = new string('\u0391', 5);
            Console.WriteLine(greekAlpha); // ΑΑΑΑΑ

            // Create a Unicode string with 3 Greek Omega characters.
            string greekOmega = new string('\u03A9', 3);
            Console.WriteLine(greekOmega); // ΩΩΩ

            // Display the entire string.
            string greekLetters = string.Concat(greekOmega, greekAlpha, greekOmega);
            Console.WriteLine(greekLetters);


            // The first index of Alpha.
            Console.WriteLine($"First occurrence of the Greek letter Alpha: Index {greekLetters.IndexOf('\u0391')}");

            // The first index of Omega.
            Console.WriteLine($"First occurrence of the Greek letter Omega: Index {greekLetters.IndexOf('\u03A9')}");


            Console.WriteLine("######################### IndexOf(string) ###########################");

            string test4 = "extant<definition>still in existence</definition>";
            Console.WriteLine(test4.IndexOf("definition")); // 7
            Console.WriteLine(test4.IndexOf("test")); // -1
            Console.WriteLine(test4.IndexOf(String.Empty)); // 0

            try
            {
                Console.WriteLine(test4.IndexOf(null));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            string myString6 = "animal";
            string searchString = "n";
            Console.WriteLine("The example displays the following output:");
            Console.WriteLine($"Found '{searchString}' in '{myString6}' at position {myString6.IndexOf(searchString)}");





            string animal1 = "fox";
            string animal2 = "dog";
            string strTarget = $"The {animal1} jumps over the {animal2}";
            Console.WriteLine($"The original string is: {Environment.NewLine}{strTarget}{Environment.NewLine}");
            Console.Write($"Enter an adjective (or group of adjectives) to describe the {animal1}: ===> ");
            string adjective1 = Console.ReadLine(); // bold
            Console.Write($"Enter an adjective (or group of adjectives) to describe the {animal2}: ===> ");
            string adjective2 = Console.ReadLine();  // lazy
            adjective1 = adjective1.Trim() + " ";
            //Console.WriteLine($"'{adjective1}'"); // 'bold '
            adjective2 = adjective2.Trim() + " ";
            //Console.WriteLine($"'{adjective2}'"); // 'lazy '

            strTarget = strTarget.Insert(strTarget.IndexOf(animal1), adjective1);
            strTarget = strTarget.Insert(strTarget.IndexOf(animal2), adjective2);
            Console.WriteLine($"The final string is:{Environment.NewLine}{strTarget}");



            string st1 = "ani\u00ADmal";
            string st2 = "animal";

            // Find the index of the soft hyphen.
            Console.WriteLine(st1.IndexOf("\u00AD")); // Empty String because "\u00AD" is ignorable character => 0
            Console.WriteLine(st2.IndexOf("\u00AD")); // Empty String because "\u00AD" is ignorable character => 0

            // Find the index of the soft hyphen followed by "n".
            Console.WriteLine(st1.IndexOf("\u00ADn")); // equivalent string "n" because "\u00AD" is ignorable character => 1
            Console.WriteLine(st2.IndexOf("\u00ADn")); // equivalent string "n" because "\u00AD" is ignorable character => 1

            // Find the index of the soft hyphen followed by "m".
            Console.WriteLine(st1.IndexOf("\u00ADm")); // equivalent string "m" because "\u00AD" is ignorable character => 4
            Console.WriteLine(st2.IndexOf("\u00ADm")); // equivalent string "m" because "\u00AD" is ignorable character => 3


            Console.WriteLine("######################## IndexOf(Char, Int32) ###################");
            string test6 = "aaagzzzfffghh";
            Console.WriteLine(test6.IndexOf('g', 6)); // 10
            Console.WriteLine(test6.IndexOf('t', 5));  //-1
            try
            {
                Console.WriteLine(test6.IndexOf('g', -1));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.WriteLine(test6.IndexOf('g', test6.Length + 2));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }




            string br1 = "0----+----1----+----2----+----3----+----4----+----5----+----6----+---";
            string br2 = "012345678901234567890123456789012345678901234567890123456789012345678";
            string strr = "Now is the time for all good men to come to the aid of their country.";
            Console.WriteLine($"This example produces the following results:{Environment.NewLine}");
            Console.WriteLine($"All occurrences of 't' from position 0 to {strr.Length - 1}.");
            Console.WriteLine($"{br1}{Environment.NewLine}{br2}{Environment.NewLine}{strr}{Environment.NewLine}");
            int start = 0;
            int index = 0;
            Console.Write("The letter 't' occurs at position(s): ");
            while ((start < strr.Length) && (index != -1))
            {
                index = strr.IndexOf('t', start);
                if (index == -1)
                {
                    break;
                }
                start = index + 1;
                Console.Write($"{index} ");
            }
            Console.WriteLine();
            Console.WriteLine(strr.IndexOf('t', strr.Length)); // -1


            Console.WriteLine("################################# IndexOf(String, Int32) #######################");


            string myString7 = "Now is the time for all time good men";
            Console.WriteLine(myString7.IndexOf("time", 20)); // 24  not  11
            Console.WriteLine(myString7.IndexOf("time", 30)); // -1
            Console.WriteLine(myString7.IndexOf("bob", 2)); // -1
            Console.WriteLine(myString7.IndexOf(string.Empty, 5));  // 5
            try
            {
                Console.WriteLine(myString7.IndexOf(null, 2)); // throw Exception
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                //Console.WriteLine(myString7.IndexOf("time" ,-1));  // throw Exception
                Console.WriteLine(myString7.IndexOf("time", myString7.Length + 2)); // Throw Exception
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }





            string myString8 = "This is the string which we will perform the search on";
            Console.WriteLine($"The search string is:{Environment.NewLine}\"{myString8}\"{Environment.NewLine}");
            while (true)
            {
                Console.Write("Please enter a search value to look for in the above string (hit Enter to exit) ===>");
                string inputTextSearch = Console.ReadLine();
                if (string.IsNullOrEmpty(inputTextSearch))
                {
                    break;
                }
                int index8 = 0;
                int start8 = 0;
                int counter = 0;
                while ((index8 != -1) && (start8 < myString8.Length))
                {
                    index8 = myString8.IndexOf(inputTextSearch, start8);
                    if (index8 != -1)
                    {
                        start8 = index8 + inputTextSearch.Length;
                        counter++;
                    }
                }
                Console.WriteLine($"{Environment.NewLine}The search parameter '{inputTextSearch}' was found {counter} times.{Environment.NewLine}");
            }
            Console.WriteLine(myString8.IndexOf("the", myString8.Length)); // -1



            string searchStr1 = "\u00ADm";  // because '\u00AD' is ignorable character so searchStr = "m"
            string searchStr2 = "\u00AD";   // because '\u00AD' is ignorable character so searchStr = " " Empty string 
            string str12 = "ani\u00ADmal";
            string str13 = "animal";

            Console.WriteLine(str12.IndexOf(searchStr1, 2));  // 4
            Console.WriteLine(str12.IndexOf(searchStr2, 2)); // 2

            Console.WriteLine(str13.IndexOf(searchStr1, 2));  // 3
            Console.WriteLine(str13.IndexOf(searchStr2, 2)); // 2


            Console.WriteLine("################## Replace(string , string) #################");

            string myString9 = "This docment uses 3 other docments";
            string myNewString9 = myString9.Replace("docment", "document");  // oldString is "docment" newstring is "document" replace all occurrences of oldString by newString
            Console.WriteLine(myNewString9); // This document uses 3 other documents 
            string myNewString10 = myString9.Replace("dom", "document"); // Nothing is happen : the current instance unchanged.
            Console.WriteLine(myNewString10); // This docment uses 3 other docments

            try
            {
                string myNewString11 = myString9.Replace(null, "document");
                Console.WriteLine(myNewString11);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                string myNewString12 = myString9.Replace(string.Empty, "document");
                Console.WriteLine(myNewString12);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


            string errString = "This docment uses 3 other docments to docment the docmentation";
            Console.WriteLine($"This code example produces the following output:{Environment.NewLine}");
            Console.WriteLine($"The original string is:{Environment.NewLine}'{errString}'{Environment.NewLine}");
            string correctString = errString.Replace("docment", "document");
            Console.WriteLine($"After correcting the string, the result is:{Environment.NewLine}'{correctString}'");
            string testNullOldValue = errString.Replace("docment", null); // because of new value is null so all occurrences of old value are removed
            Console.WriteLine(testNullOldValue);  // This  uses 3 other s to  the ation

            string myString10 = "aaa";
            string myNewStrin10 = myString10.Replace("a", "b").Replace("b", "c").Replace("c", "d");
            Console.WriteLine("The example displays the following output:");
            Console.WriteLine($"The initial string: \"{myString10}\"");
            Console.WriteLine($"The final string:\"{myNewStrin10}\""); // "ddd"


            Console.WriteLine("############################## Replace(Char, Char) #################");

            string myString11 = "hello youssef how are you ?";
            string myNewStrin11 = myString11.Replace('o', 'z'); // replace all occurrences of character 'o' by character 'z'
            Console.WriteLine(myNewStrin11); // "hellz yzussef hzw are yzu ?"
            string myNewStrin12 = myString11.Replace('c', 'z'); // character 'c' not foud , so the current instance unchanged
            Console.WriteLine(myNewStrin12); // hello youssef how are you ?


            String myString13 = "1 2 3 4 5 6 7 8 9";
            string myNewStrin13 = myString13.Replace(' ', ',');
            Console.WriteLine("This example produces the following output:");
            Console.WriteLine($"Original string: \"{myString13}\"");
            Console.WriteLine($"CSV string: \"{myNewStrin13}\"");


            string myString14 = new string('a', 3); // "aaa"
            Console.WriteLine("The example displays the following output:");
            Console.WriteLine($"The initial string: '{myString14}'"); // The initial string: 'aaa'
            string myNewStrin14 = myString14.Replace('a', 'b').Replace('b', 'c').Replace('c', 'd');
            Console.WriteLine($"The final string: '{myNewStrin14}'"); // The final string: 'ddd'


            // Accessing individual characters : 
            string myString15 = "Printing backwards";
            Console.Write("Output : \"");
            for (int i = myString15.Length - 1; i > -1; i--)
            {
                Console.Write(myString15[i]);
            }
            Console.Write("\"");
            Console.WriteLine();



            string question = "hOW DOES mICROSOFT wORD DEAL WITH THE cAPS lOCK KEY?";
            StringBuilder sb = new StringBuilder(question);
            for (int i = 0; i < sb.Length; i++)
            {
                if (char.IsLower(sb[i]))
                {
                    sb[i] = char.ToUpper(sb[i]);
                }
                else if (char.IsUpper(sb[i]))
                {
                    sb[i] = char.ToLower(sb[i]);
                }
            }
            string correct = sb.ToString();
            Console.WriteLine(correct);


            // Null strings and empty strings  :

            //string emptyString = "";
            string emptyString = string.Empty;
            Console.WriteLine($"Number of characters in empty string is : {emptyString.Length}"); // 0


            try
            {
                string myString16 = "hello";
                string nullstr = null;
                string emptystr = string.Empty;

                string tempStr = myString16 + null;
                Console.WriteLine($"'{tempStr}'"); // 'hello'

                bool bol = (emptystr == nullstr);
                Console.WriteLine(bol); // False

                string newStr = emptystr + nullstr;
                Console.WriteLine($"'{newStr}'"); // ''  => empty string

                Console.WriteLine(emptystr.Length); // 0
                Console.WriteLine(newStr.Length); // 0

                //Console.WriteLine(nullstr.Length); // throw an Exception (NullReferenceException)

                // null character can be displayed and counted , like other characters

                string myString17 = "\u0000" + "abc";
                string myString18 = "abc" + "\u0000";

                Console.WriteLine($"*{myString17}*"); // * abc*
                Console.WriteLine($"*{myString18}*"); // *abc *
                Console.WriteLine($"{myString17.Length}"); // 4
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Using stringBuilder for fast string creation : 

            StringBuilder sb1 = new StringBuilder("Rat: the ideal pet");
            sb1[0] = 'C';
            Console.WriteLine(sb1);


            // to create a string from a set of numeric types:

            StringBuilder sb2 = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb2.Append(i);
            }
            Console.WriteLine($"displays {sb2}"); // displays 0123456789
            sb2[0] = sb2[9];
            Console.WriteLine($"displays {sb2}"); // displays 9123456789



























        }

        public static void PrintChar(string str)
        {
            Console.WriteLine($"\"{str}\".Length = {str.Length}");
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine($"s[{i}] = '{str[i]}' ('\\u{(int)str[i]:x4}')");
            }
        }
    }
}
