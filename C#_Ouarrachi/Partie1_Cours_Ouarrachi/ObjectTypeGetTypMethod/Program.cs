using System;
using System.Text;

namespace ObjectTypeReferenceEqualsMethod
{

    public class Person
    {
        public string Name { get; set; }


    }

    internal class Program
    {
        static void Main(string[] args)
        {


            // Signature : ublic static bool ReferenceEquals (object objA, object objB);
            // Determines whether the specified Object instances (objA and objB) are the same instance


            Console.WriteLine("##################### Refrence type other than string ##################");
            object obj1 = null;
            object obj2 = null;
            object obj3 = new object();

            Console.WriteLine(Object.ReferenceEquals(obj1, obj2)); // True : Because both objects are null
            obj2 = obj3;
            Console.WriteLine(Object.ReferenceEquals(obj2, obj3)); // True : Because both objects are the same instance
            Console.WriteLine(Object.ReferenceEquals(obj1, obj2)); // False : Because both of objects aren't null and same instance

            Person p1 = new Person();
            p1.Name = "Youssef";
            Person p2 = new Person();
            p2.Name = "Hassna";

            Console.WriteLine(Object.ReferenceEquals(p1, p2)); // False

            Person p3 = p1;
            Console.WriteLine(Object.ReferenceEquals(p1, p3)); // True




            Console.WriteLine("############  Value Type ##################");

            int num1 = 10;
            int num2 = 12;
            Console.WriteLine(Object.ReferenceEquals(num1, num1)); // False
            Console.WriteLine(Object.ReferenceEquals(num1, num2));  // False








            Console.WriteLine("################## Creating string and testin if they are Interned or not");


            string str1 = "koko lolo"; // Directly assigning a string literal so automalically interned
            string str2 = "ko" + "lol"; // equivalent to "kolol"
            string str3 = "bobo"; // Directly assigning a string literal so automalically interned
            string str4 = "dodo"; // Directly assigning a string literal so automalically interned
            string str5 = str3 + str4; // created programmatically so Not Interned
            string str6 = str3 + "soso"; // created programmatically so Not Interned
            string str7 = "momo";
            string str8 = str7 + ""; // Equivalent to  string str8 = str7 ; so Interned
            string str9 = @"vovo"; // Directly assigning a string literal so automalically interned
            string str10 = new String('h', 4); // Created Dynamically : By using the new keyword when calling the constructor of String class
            char[] chars = new char[] { 'g', 'o', 'g', 'o' };
            string str11 = new String(chars); // Created Dynamically : By using the new keyword when calling the constructor of String class
            string str12 = new StringBuilder().Append("Hi").Append("Youssef").ToString(); // Created Dynamically : By converting a StringBuilder object to String object
            string str13 = String.Format("{0}{1}", new String('h', 4), "Hassna");
            string str14 = String.Format("{0}{1}", "hh", "wwww");
            string str15 = String.Concat(new String('h', 4), "Omar");
            int num = 76;
            string str16 = num.ToString();
            string str17 = Console.ReadLine();


            Console.WriteLine($"Is Interned :  {(String.IsNullOrEmpty(string.IsInterned(str1)) ? "No" : "Yes")}"); // Yes
            Console.WriteLine($"Is Interned :  {(String.IsNullOrEmpty(string.IsInterned(str2)) ? "No" : "Yes")}"); // Yes
            Console.WriteLine($"Is Interned :  {(String.IsNullOrEmpty(string.IsInterned(str3)) ? "No" : "Yes")}"); // Yes
            Console.WriteLine($"Is Interned :  {(String.IsNullOrEmpty(string.IsInterned(str4)) ? "No" : "Yes")}"); // Yes
            Console.WriteLine($"Is Interned :  {(String.IsNullOrEmpty(string.IsInterned(str5)) ? "No" : "Yes")}"); // No
            Console.WriteLine($"Is Interned :  {(String.IsNullOrEmpty(string.IsInterned(str6)) ? "No" : "Yes")}"); // No
            Console.WriteLine($"Is Interned :  {(String.IsNullOrEmpty(string.IsInterned(str8)) ? "No" : "Yes")}"); // Yes
            Console.WriteLine($"Is Interned :  {(String.IsNullOrEmpty(string.IsInterned(str9)) ? "No" : "Yes")}"); // Yes
            Console.WriteLine($"Is Interned :  {(String.IsNullOrEmpty(string.IsInterned(str10)) ? "No" : "Yes")}"); // No
            Console.WriteLine($"Is Interned :  {(String.IsNullOrEmpty(string.IsInterned(str11)) ? "No" : "Yes")}"); // No
            Console.WriteLine($"Is Interned :  {(String.IsNullOrEmpty(string.IsInterned(str12)) ? "No" : "Yes")}"); // No
            Console.WriteLine($"Is Interned :  {(String.IsNullOrEmpty(string.IsInterned(str13)) ? "No" : "Yes")}"); // No
            Console.WriteLine($"Is Interned :  {(String.IsNullOrEmpty(string.IsInterned(str14)) ? "No" : "Yes")}"); // No
            Console.WriteLine($"Is Interned :  {(String.IsNullOrEmpty(string.IsInterned(str15)) ? "No" : "Yes")}"); // No
            Console.WriteLine($"Is Interned :  {(String.IsNullOrEmpty(string.IsInterned(str16)) ? "No" : "Yes")}"); // No
            Console.WriteLine($"Is Interned :  {(String.IsNullOrEmpty(string.IsInterned(str17)) ? "No" : "Yes")}"); // Yes



            char[] chars1 = { 'x' };
            char[] chars2 = { 'y' };
            string first = new string(chars1); // Not Interned : Because is created dynamically
            string second = new string(chars2); // Not Interned : Because is created dynamically

            string.Intern(first); // Interns it
            Console.WriteLine(string.IsInterned(first) != null); // Check

            string.IsInterned(second); // Doesn't intern it
            Console.WriteLine(string.IsInterned(second) != null); // Check



            String str45 = "abcd"; // Interned automatically : Because directly assigning a String literal
            // Constructed string, str2, is not explicitly or automatically interned.
            String str46 = new StringBuilder().Append("wx").Append("yz").ToString();  // Not Interned Because  is created dymanically
            Console.WriteLine(String.IsInterned(str45));
            Console.WriteLine(String.IsInterned(str46));
            String str47 = new StringBuilder().Append("ab").Append("cd").ToString(); // Not Interned Because  is created dymanically
            Console.WriteLine(String.IsInterned(str47)); // abcd



            Console.WriteLine("########### Comparing strings ################");

            string strin1 = "String1"; // Interned string automatically , Created by directly assigning a String literal
            string strin2 = "String1"; // Interned string automatically , Created by directly assigning a String literal
            Console.WriteLine($"{nameof(strin1)} = {nameof(strin2)} : {Object.ReferenceEquals(strin1, strin2)}"); // strin1 = strin2 : True

            string suffix = "A";
            string strin3 = "String" + suffix; // Not Interned string : Because created dynamically
            string strin4 = "String" + suffix; // Not Interned string : Because created dynamically
            Console.WriteLine($"{nameof(strin3)} = {nameof(strin4)} : {Object.ReferenceEquals(strin3, strin4)}"); // strin3 = strin4 : False
        }
    }
}
