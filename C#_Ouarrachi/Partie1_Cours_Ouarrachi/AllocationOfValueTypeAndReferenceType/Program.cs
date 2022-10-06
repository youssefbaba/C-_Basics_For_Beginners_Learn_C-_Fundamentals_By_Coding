using System;

namespace AllocationOfValueTypeAndReferenceType
{
    /*
     - Reference types always stored on the heap .
     - Value types are generally stored on the stack but not always .
     - Value types declared as variable in method => stored on the stack .
     - Value types declared as parameter in method => stored on the stack .
     - Value types declared as a member of a class => stored on the heap (with its parent) . 
     - Value types declared as a member of a struct => stored wherever the struct has been allocated .
     - ref struct => stored on the stack always .
    */

    internal class Program
    {
        public ref struct NameStruct
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        public struct DateSturct
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }
        }
        public class Application
        {
            private int number = 69; // Value type declared as a member of class => stored on the heap (where its parent is stored) .

            public int SomeMethod(int number) // in this case int number is value type declared as a parameter in method => stored on stack .
            {
                return number++;
            }
            public void PrintDateFromLocalVariables()
            {
                // variable (day , month , year) is value type declared as a local variable in method  => stored on the stack
                int day = 18;
                int month = 12;
                int year = 2022;

                //Console.WriteLine($"The date is {day}/{month}/{year}");
                Console.WriteLine(String.Format("The date is {0}/{1}/{2}", day, month, year)); // Here variables ( day , month , year) are stored in stack because of boxing (conversion value type to object) that happen when parameters of method format convert to object .
            }

            private DateSturct dataStruct = new DateSturct(); // Struct is Value types declared as a member of a class so is stored on heap => and then their members (Day , Month , Year) are stored on heap also .

            public void PrintDateFromLocalStruct()
            {
                DateSturct dataStruct = new DateSturct { Day = 18, Month = 12, Year = 2022 }; // Struct is Value types declared as a variable in method so is stored on stack => and then their members (Day , Month , Year) are stored on satck also .
                Console.WriteLine($"The Date : {dataStruct.Day}/{dataStruct.Month}/{dataStruct.Year}"); //  Here members (Day , Month , Year) are stored in heap because of boxing .
            }
            // Error Connot allocated this struct here
            //NameStruct name = new NameStruct { FirstName = "Youssef", LastName = "Baba" };


            public void PrintFullName()
            {
                NameStruct name = new NameStruct { FirstName = "Youssef", LastName = "Baba" }; // Struct is Value types declared as a variable in method so is stored on stack => and then their members (FirstName , LastName) are stored on satck also .
                Console.WriteLine($"My Name is : {name.FirstName} {name.LastName}"); //  Here members (FirstName , LastName) are stored in heap because of boxing .

            }
        }
        static void Main(string[] args)
        {
            int number = 420; // Value type declared as a local variable in method  => stored on the stack .

            Application application = new Application();
            application.SomeMethod(420);
            application.PrintDateFromLocalVariables();
            application.PrintDateFromLocalStruct();

        }
    }
}
