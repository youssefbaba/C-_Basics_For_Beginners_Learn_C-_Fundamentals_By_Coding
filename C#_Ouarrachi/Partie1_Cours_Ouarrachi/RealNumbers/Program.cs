using System;


namespace RealNumbers
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("size of float is : {0} bytes", sizeof(float));
            Console.WriteLine("size of double is : {0} bytes", sizeof(double));
            Console.WriteLine("size of decimal is : {0} bytes", sizeof(decimal));

            float priceOne = 10.95f;
            Console.WriteLine(priceOne);
            System.Single priceTwo = 20.15f;
            Console.WriteLine(priceTwo);

            double heightOne = 1.75;
            Console.WriteLine(heightOne);
            System.Double heightTwo = 1.80;
            Console.WriteLine(heightTwo);

            // The default value of each real number is 0
            // each real number has minimum and maximum value

            // minumum finite value of type float
            Console.WriteLine($"minimum of float type is :{float.MinValue}");
            // maximum finite value of type float
            Console.WriteLine($"maximum of float type is :{float.MaxValue}");
            // minumum finite value of type double
            Console.WriteLine($"minimum of double type is :{double.MinValue}");
            // maximum finite value of type double
            Console.WriteLine($"maximum of double type is :{double.MaxValue}");
            // minumum finite value of type decimal
            Console.WriteLine($"minimum of decimal type is :{decimal.MinValue}");
            // maximum finite value of type decimal
            Console.WriteLine($"maximum of decimal type is :{decimal.MaxValue}");

            // positive infinity value (double and float)
            Console.WriteLine($"positive infinity value of double type : {double.PositiveInfinity}");
            Console.WriteLine($"positive infinity value of float type : {float.PositiveInfinity}");

            // negative infinity value (double and float)
            Console.WriteLine($"negative infinity value of double type : {double.NegativeInfinity}");
            Console.WriteLine($"negative infinity value of float type : {float.NegativeInfinity}");

            // Not an number (double and float)
            Console.WriteLine($"not a number (double) : {double.NaN}");
            Console.WriteLine($"not a number (float) : {float.NaN}");


            double numberOne = 1.2;
            decimal numberTwo = 2.1m;
            Console.WriteLine($"Addition of numberOne + numberTwo = {(decimal)numberOne + numberTwo}"); // decimal
            Console.WriteLine($"Addition of numberOne + numberTwo = {numberOne + (double)numberTwo}"); // double



            //Real literals
            double valueOne = 3d; // double
            Console.WriteLine($"type of {nameof(valueOne)} is {valueOne.GetType().Name}");
            valueOne = 4d; // double
            valueOne = 3.934_001; // double

            float valueTwo = 3_000.5f; // float
            Console.WriteLine($"type of {nameof(valueTwo)} is {valueTwo.GetType().Name}");
            valueTwo = 5.4f; // float

            decimal myMoney = 3_000.5m; // decimal
            Console.WriteLine($"type of {nameof(myMoney)} is {myMoney.GetType().Name}");
            myMoney = 400.75m; // decimal

            double d = 0.42e2d; // double
            Console.WriteLine($"{d} is of type {d.GetType().Name}");   // 42 is of type Double

            float f = 134.45E-2f; // float
            Console.WriteLine($"{f} is of type {f.GetType().Name}");   // 1.3445 is of type Single

            decimal m = 1.5E6m; // decimal
            Console.WriteLine($"{m} is of type {m.GetType().Name}"); // 1500000 is of type Decimal








        }
    }
}
