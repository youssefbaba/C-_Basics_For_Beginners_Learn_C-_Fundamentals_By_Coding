using System;

namespace TestEnum
{
    class Program
    {
        /* 
          An enum is a data type that represents a set of name/value pairs.
          Use enums when you need to define multiple related constants.
         */

        //const int RegularAirMail = 1;
        //const int RegisteredAirMail = 2;
        //const int Express = 3;

        // Declaration Of num
        public enum Colors
        {
            Red,
            Green,
            Blue
        }
        public enum ShippingMethod
        {
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3
        }


        static void Main(string[] args)
        {
            var colorOne = Colors.Red;
            var colorTwo = Colors.Green;
            var colorThree = Colors.Blue;
            Console.WriteLine((int)colorOne);
            Console.WriteLine((int)colorTwo);
            Console.WriteLine((int)colorThree);


            ShippingMethod methodOne = ShippingMethod.RegularAirMail;
            //int methodIdOne = (int)methodOne;
            Console.WriteLine((int)methodOne);


            int methodIdTwo = 2;
            //ShippingMethod methodTwo = (ShippingMethod)methodIdTwo;
            Console.WriteLine((ShippingMethod)methodIdTwo);


            // Convert enum to string
            ShippingMethod methodThree = ShippingMethod.Express;
            //string methodName = methodThree.ToString();
            Console.WriteLine(methodThree.ToString());


            // Convert string to enum
            string methodName = "Express";
            ShippingMethod methodFour = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(methodFour);

        }
    }
}
