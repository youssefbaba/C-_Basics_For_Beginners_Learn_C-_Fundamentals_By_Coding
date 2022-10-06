using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // if/else statements

            /*
             
            if (Condition)
            {
                // Some Statement

            }else if (Another Condition)
            {
                //Another Statement
            }
            else
            {
                //Yet Another Statement
            }

            */

            //Nested if Statement

            /*
             
            if (Condition)
            {
                if (Another Condition)
                {
                    // Some Statement
                }
                else
                {
                    // Another Statement
                }
            }

            */

            // Conditional Operator

            /*
             
            (Condition) ? Statement : OtherStatement;

            */

            //Switch/Case

            /*
             
            switch (role)
            {
                case Role.User:
                    // Code Here
                    break;
                case Role.Admin:
                    // Code Here
                    break;
                default:
                    //Code Here
                    break;
            }

            */

            int hour = 10;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }


            bool IsGoldCustomer = true;
            float price;
            if (IsGoldCustomer)
            {
                price = 19.95f;
                Console.WriteLine(price);
            }
            else
            {
                price = 29.95f;
                Console.WriteLine(price);
            }


            bool loggedIn = true;
            string status = (loggedIn) ? "Online" : "Offline";
            Console.WriteLine(status);


            Season season = Season.Autumn;
            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine("It's spring .");
                    break;
                case Season.Summer:
                case Season.Autumn:
                    Console.WriteLine("we've got promotion .");
                    break;
                case Season.Winter:
                    Console.WriteLine("It's winter .");
                    break;
                default:
                    Console.WriteLine("Season Not Found .");
                    break;
            }

        }
    }
}
