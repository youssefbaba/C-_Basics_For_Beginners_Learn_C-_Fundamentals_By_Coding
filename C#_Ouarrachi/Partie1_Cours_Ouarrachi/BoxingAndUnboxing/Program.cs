using System;
using System.Collections.Generic;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             - link1 : https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing
            -  link2 : https://www.geeksforgeeks.org/c-sharp-boxing-unboxing/
            

             */

            Console.WriteLine("########################################");
            int number = 10; // number is value type
            object objectOne = number; // converting of the value type (int) to the type object (obj) => Boxing implicit converting : converting a value type to the type object
            Console.WriteLine(objectOne); // 10
            Console.WriteLine(objectOne.GetType()); //System.Int32
            objectOne = 200;
            Console.WriteLine(objectOne); // 200
            Console.WriteLine(number); //10
            number = 400;
            Console.WriteLine(number); //400
            int numberTwo = (int)objectOne + 10; // Unboxing
            Console.WriteLine(numberTwo); // 210


            Console.WriteLine("########################################");
            // Incompatible Casting
            double num = 10.2;
            object objectTwo = num;
            Console.WriteLine(objectTwo.GetType()); //System.Double
            //int age = (int)ob; // error because obj1 contain value of type double
            int age = (int)(double)objectTwo;
            Console.WriteLine(age); // 10


            Console.WriteLine("########################################");
            MyStruct valueOfStruct = new MyStruct(); // type of valueOfStruct is MyStruct and is value type
            IMyInterface valueOfInterface = valueOfStruct; // type of valueOfInterface is IMyInterface and is reference type  => Boxing implicit converting :  converting a value type to any interface type implemented by this value type
            valueOfInterface.DoSomething(); // Hello World
            Console.WriteLine(valueOfInterface.GetType()); //Test12.MyStruct


            Console.WriteLine("##########################################");
            // Attempting of Unboxing null
            try
            {
                int number2 = 12;
                object object2 = number2;
                Console.WriteLine(object2);
                object2 = null;
                Console.WriteLine(object2);
                int number3 = (int)object2;
            }
            catch (Exception e)
            {
                Console.WriteLine("Attempting of Unboxing null Make exception : {0}", e.Message);
            }


            Console.WriteLine("##########################################");
            // Attempting to unbox a reference to an incompatible value type
            try
            {
                double price = 10.95;
                object object4 = price;
                Console.WriteLine(object4);
                //double number5 = (int)object4 + 12;
                double number5 = (double)object4 + 12;
                Console.WriteLine(number5);
            }
            catch (Exception e)
            {
                Console.WriteLine("Attempting to unbox a reference to an incompatible value type make exception :{0} ", e.Message);
            }


            Console.WriteLine("########################################");
            Console.WriteLine(String.Concat("Youssef", 42, true)); // Boxing
            List<object> mixedList = new List<object>();
            mixedList.Add("First Group");
            for (int i = 1; i < 5; i++)
            {
                mixedList.Add(i); // Boxing
            }
            mixedList.Add("Second Group");
            for (double i = 6; i < 10; i++)
            {
                mixedList.Add(i); // Boxing
            }
            for (int i = 0; i < mixedList.Count; i++)
            {
                Console.WriteLine("mixedList[{0}] = {1} ", i, mixedList[i]);
            }
            Console.WriteLine("type of mixedList[2] is : {0}", mixedList[2].GetType());
            int sum1 = 0;
            for (int i = 1; i < 5; i++)
            {
                sum1 += (int)mixedList[i] * (int)mixedList[i];  // Unboxing
            }
            Console.WriteLine("sum1 = {0}", sum1);
            Console.WriteLine("type of mixedList[7] is : {0}", mixedList[7].GetType());
            int sum2 = 0;
            for (int i = 6; i < 10; i++)
            {
                sum2 += (int)(double)mixedList[i] * (int)(double)mixedList[i]; // Unboxing
            }
            Console.WriteLine("sum2 = {0}", sum2);
        }

    }
    interface IMyInterface // interface is a reference tyep
    {
        void DoSomething();
    }

    struct MyStruct : IMyInterface  // struct is a value type
    {
        public void DoSomething()
        {
            Console.WriteLine("Hello World");
        }
    }
}
