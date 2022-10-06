using System;
using System.Data;

namespace Enumeration
{
    internal class Program
    {

        /*
         - link1 : https://www.youtube.com/watch?v=g-LJlrMXZ5k&list=PLAC325451207E3105&index=45
         - link2 : https://www.youtube.com/watch?v=HsTVTCP-c4w&list=PLAC325451207E3105&index=46
         - link3 : https://www.youtube.com/watch?v=2f5R8NdIdzc&list=PLAC325451207E3105&index=47
         - link4 : https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum
         - link5 : https://dotnettutorials.net/lesson/enums-csharp/

         */
        static void Main(string[] args)
        {
            /*
            string day = "saturday";
            CheckWeek(day);
            */


            CheckWeek(DaysOfWeek.Saturday);
            CheckWeek(DaysOfWeek.Monday);


            User[] users = new User[3]
            {
                //new User{ Name = "Mark" , Gender = 1}, // without enum
                new User{ Name = "Mark" , Gender = Gender.Male},
                //new User{ Name = "Mary" , Gender = 2},  // without enum
                new User{ Name = "Mary" , Gender = Gender.Female},
                //new User{ Name = "Sam" , Gender = 0} // without enum
                new User{ Name = "Sam" , Gender = Gender.Unknown}
            };
            foreach (User user in users)
            {
                Console.WriteLine($"Name = {user.Name} , Gender = {GetGender(user.Gender)}");
            }


            // Display Elements of, enum Levels
            Console.WriteLine($"{Levels.Low} => {(int)Levels.Low}"); // Low => 0
            Console.WriteLine($"{Levels.Medium} => {(int)Levels.Medium}"); // Medium => 1
            Console.WriteLine($"{Levels.High} => {(int)Levels.High}"); // High => 2

            // Get Values of enum and display them : 
            int[] valuesOne = (int[])Enum.GetValues(typeof(Gender));
            foreach (int value in valuesOne)
            {
                Console.WriteLine($"{value}");
            }
            // Get Names of enum and display them : 
            string[] namesOne = Enum.GetNames(typeof(Gender));
            foreach (string name in namesOne)
            {
                Console.WriteLine($"{name}");
            }
            Console.WriteLine("##################");


            // Get Values of enum and display them : 
            short[] valuesTwo = (short[])Enum.GetValues(typeof(Days));
            foreach (short value in valuesTwo)
            {
                Console.WriteLine($"{value}");
            }
            Console.WriteLine("##################");


            // Get Values of enum and display them : 
            long[] valuesThree = (long[])Enum.GetValues(typeof(Direction));
            foreach (long value in valuesThree)
            {
                Console.WriteLine($"{value}");
            }
            Console.WriteLine("##################");


            // an explicit cast is nedeed to convert from enum type to an integral type and vice versa.
            long number = (long)Direction.South;
            Console.WriteLine($"{number}");
            Direction direction = (Direction)10;
            Console.WriteLine($"{direction}");

            long[] valuesFour = (long[])Enum.GetValues(typeof(Direction));
            string[] namesTwo = Enum.GetNames(typeof(Direction));
            foreach (long value in valuesFour)
            {
                Console.WriteLine($"{(Direction)value} => {value}");
            }
            foreach (string name in namesTwo)
            {
                Console.WriteLine($"{name} => {(long)Enum.Parse(typeof(Direction) , name)}");
            }

            // an enum of one type cannot be implicitly assigned to an enum of another type even though the underlying value of their members are the same

            Season season = (Season)Levels.Low;
            Console.WriteLine($"{season}");











        }
        // Without enumeration.
        /*
        public static void CheckWeek(string day)
        {
            if (day.ToLower() == "saturday" || day.ToLower() == "sunday")
            {
                Console.WriteLine($"it's the end of the week");
            }
            else
            {
                Console.WriteLine($"it's not the end of the week");
            }
        }
        */

        // with  enumeration.
        public static void CheckWeek(DaysOfWeek day)
        {
            if (day.Equals(DaysOfWeek.Saturday) || day.Equals(DaysOfWeek.Sunday))
            {
                Console.WriteLine($"it's the end of the week");
            }
            else
            {
                Console.WriteLine($"it's not the end of the week");
            }
        }
        // Without using enumeration.
        /*
        public static string GetGender(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid Data";
            }
        }
        */
        // with using enum 
        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid Data";
            }
        }
    }
    public enum DaysOfWeek
    {
        Monday,     // Default value is 0
        Tuesday,    // Default value is 1
        Wednesday,  // Default value is 2
        Thursday,   // Default value is 3
        Friday,     // Default value is 4
        Saturday,   // Default value is 5
        Sunday      // Default value is 6
    }
    // enums are value type .
    // the default underlying type of enum is int .
    // the default value for the first element is zero and gets incremented by 1 .
    public enum Gender
    {
        Unknown,    // Default value is 0
        Male,       // Default value is 1
        Female      // Default value is 2
    }

    // it is possible ro custome the underlying type and values
    public enum Days : short
    {
        Monday = 10,    // value is 10
        Tuesday,        // value is 11
        Wednesday,      // value is 12
        Thursday = 35,  // value is 35
        Friday,         // value is 36
        Saturday,       // value is 37
        Sunday          // value is 38
    }

    public enum Direction : long
    {
        West = 12,
        Nort = 22,
        South = 10,
        East = 1
    }

    public enum Levels
    {
        Low = 1,
        Medium,
        High
    }
    public enum Season
    {
        Winter = 1 ,
        Spring,
        Summer
    }



}