using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversionsTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             - link1 : https://www.youtube.com/watch?v=e0CudXZWE7U&t=1076s
             - link2 : https://www.youtube.com/watch?v=3_YV8DV9Eqc&list=PLPTEH6qQi0o-Io8uGXLesNAC6uLGUv4aN&index=17
             - link3 : https://www.youtube.com/watch?v=GQeS1ig8gmE&list=PLPTEH6qQi0o-Io8uGXLesNAC6uLGUv4aN&index=18
             - 
             */
            int numberOne = 15;
            float numberTwo = numberOne; // Implicit Conversion from int to float
            Console.WriteLine(numberTwo); // 15
            Console.WriteLine(sizeof(float)); // 4
            Console.WriteLine(sizeof(int)); // 4


            float numberThree = 12.3655f;
            //int numberFour = numberThree; // Throw an Exception : cannot implicitly convert float to int
            int numberFour = (int)numberThree;
            Console.WriteLine(numberFour); // 12


            float valueOne = 15.365f;
            double valueTwo = valueOne; // Implicit Conversion
            Console.WriteLine(valueTwo);


            double valueFive = 14.365;
            //float valueSix = valueFive; // Throw an Exception : cannot implicilty convert double to float
            float valueSix = (float)valueFive;


            string name;
            int age;
            Console.Write($"Enter your name : ");
            name = Console.ReadLine();
            Console.Write($"Enter your age : ");
            //age = int.Parse(Console.ReadLine()); // first way
            age = Convert.ToInt32(Console.ReadLine()); // second way 
            Console.WriteLine($"your name : {name} , your age : {age} year(s) old");


            //Error
            float amountOne = 145.32f;
            //int test = int.Parse(amountOne); // method Parse takes in her parameter string and cannot implicitly convert float to string so => error
            int test = Convert.ToInt32(amountOne); // Correct
            Console.WriteLine($"test : {test}");


            // Test for Loss the data 
            double val = 200.4625;
            byte val1 = (byte)val;
            Console.WriteLine(val1); // 200 => loss of data (fraction part)


            // Test for throw an overflow exception
            double val2 = 500.1225;
            byte val3 = (byte)val2;// an overflow is happening but any exception is throw
            Console.WriteLine(val3);
            try
            {
                byte val4 = Convert.ToByte(val2); // an overflow is happening and aslo an exception
                Console.WriteLine(val4);
            }
            catch (OverflowException exp)
            {
                Console.WriteLine(exp.Message);
            }


            // Difference between Parse and TryParse method 
            /*
             
             - Parse() method throws an exception if it cannot parse the value (if your parameter is null or there is incorrect format exception or overflow exception ),
              whereas TryParse() returns a bool indicating wheter it succeded or failed ( if your parameter is null or System.String.Empty,
              is not of the correct format, or represents a number less than System.Int32.MinValue or greater than System.Int32.MaxValue)
             - Use Parse() if you are sure the value will be valid , otherwise use TryParse()

             */
            string stringValueOne = "25";
            int integerValueOne = int.Parse(stringValueOne); // everything is fine : return value is int and no exception
            Console.WriteLine($"integerValueOne : {integerValueOne}");


            string stringValueTwo = "25A";
            try
            {
                int integerValueTwo = int.Parse(stringValueTwo); // Throw an exception
            }
            catch (FormatException exp)
            {
                Console.WriteLine(exp.Message);
            }


            string stringValueThree = "56";
            int resultOne;
            bool isConvetedOne = int.TryParse(stringValueThree, out resultOne);
            if (isConvetedOne)
            {
                Console.WriteLine($"value is {resultOne}");
            }
            else
            {
                Console.WriteLine($"Conversion Failed , {resultOne}");
            }


            string stringValueFour = "56A";
            int resultTwo;
            bool isConvetedTwo = int.TryParse(stringValueFour, out resultTwo);
            if (isConvetedTwo)
            {
                Console.WriteLine($"value is {resultTwo}");
            }
            else
            {
                Console.WriteLine($"Conversion Failed , {resultTwo}");
            }

            Console.Write($"Enter i value : ");
            int i = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"i : {i}");

            Console.Write($"Enter j value : ");
            if(Int32.TryParse(Console.ReadLine() , out int result))
            {
                Console.WriteLine($"result : {result}");
            }
            else
            {
                Console.WriteLine($"conversion failed");
            }



            // Animal is base class , Lion and Tiger are derived class
            Animal animal = new Animal();
            Lion lion = new Lion();
            Console.WriteLine(animal.GetType().Name); // Animal
            Console.WriteLine(lion.GetType().Name); // Lion

            animal = lion; // Implicit conversion From derived class to base class
            Console.WriteLine(animal.GetType().Name); // Lion
            Console.WriteLine(lion.GetType().Name); // Lion

            //Lion lion2 = (Lion)animal; // Explicit conversion from base class to derived class without any exception because type of object animal is Animal
            //lion2.Display();

            Tiger tiger = new Tiger();
            try
            {
                tiger = (Tiger)animal; // Explicit conversion from base class to derived class, with throw exception because object animal is not of type Tiger
                tiger.Display();
            }
            catch (InvalidCastException exp)
            {
                Console.WriteLine(exp.Message);
            }
            Console.WriteLine("Other Code Here .....");

            TestConvertClass();
        }
        public static void TestConvertClass()
        {
            // the static methods of Convert class are used to convert from one base data type to another base data type

            double doubleOne = 3.14;
            double doubleTwo = 5.5;
            double doubleThree = 6.5;
            double doubleFour = 1000.225;
            int intOne = Convert.ToInt32(doubleOne);
            int intTwo = Convert.ToInt32(doubleTwo);
            int intThree = Convert.ToInt32(doubleThree);
            Console.WriteLine(intOne); // 3
            Console.WriteLine(intTwo); // 6
            Console.WriteLine(intThree); // 6
            try
            {
                byte byteOne = Convert.ToByte(doubleFour);
                Console.WriteLine(byteOne);
            }
            catch (OverflowException exp)
            {
                Console.WriteLine($"Thre is an OverflowException");
            }

            string stringOne = "1234";
            string stringTwo = "12d";
            int numberOne = Convert.ToInt32(stringOne);
            Console.WriteLine($"numberOne : {numberOne}");

            try
            {
                int numberTwo = Convert.ToInt32(stringTwo);
            }
            catch (FormatException exp)
            {
                Console.WriteLine($"there is an Format Exception ");
            }

            int numberThree = 123;
            string convertString = Convert.ToString(numberThree);
            Console.WriteLine($"convertString : {convertString}");

            // Test For InvalidCastException
            ////// Convert from char type to boolean type
            try
            {
                char character = 'A';
                bool check = Convert.ToBoolean(character);
                Console.WriteLine(check);
            }
            catch (InvalidCastException exp)
            {
                Console.WriteLine(exp.Message);
            }
            ////// Convert from int type to Datetime

            try
            {
                int num = 123;
                DateTime time = Convert.ToDateTime(num);
                Console.WriteLine(time);
            }
            catch (InvalidCastException exp)
            {
                Console.WriteLine(exp.Message);
            }

            // Test For FormatException

            string test = "True";
            bool b = Convert.ToBoolean(test);
            Console.WriteLine(b.GetType().Name);

            try
            {
                string stringValue = "Yes";
                bool booleanValue = Convert.ToBoolean(stringValue);
                Console.WriteLine(booleanValue);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            string stringVal = "A";
            char letter = Convert.ToChar(stringVal);
            Console.WriteLine(letter);

            try
            {
                string stringVal1 = "ABC";
                char letter1 = Convert.ToChar(stringVal1);
            }
            catch (FormatException exp)
            {
                Console.WriteLine(exp.Message);
            }









           
           
        }

    }
}
