using System;

namespace IntegerNumber
{
    internal class Program
    {
        static void Main()
        {
            // The default value of each integral type is zero, 0.

            // the same declaration
            int value = 123;
            System.Int32 valueTwo = 123;
            Console.WriteLine(value + valueTwo);


            int numberOne = 100;
            long valueThree = 154;
            Console.WriteLine(int.MinValue); // -2(31)
            Console.WriteLine(int.MaxValue); // 2(31) - 1
            Console.WriteLine(long.MinValue); // -2(63)
            Console.WriteLine(long.MaxValue); // 2(63) - 1



            // Integer Literals
            // Integer Literal in the form of decimal
            var decimalLiteralOne = 42;
            var amount = 0xFF_FF_FF_FF;
            int val = unchecked((int)0xFF_FF_FF_FF);
            Console.WriteLine(val);
            // Integer Literal in the form of hexadecimal
            var hexadecimalLiteralOne = 0x2A;
            // Integer Literal in the form of binary
            var binaryLiteralOne = 0b_0010_1010;
            Console.WriteLine(decimalLiteralOne.GetType());
            Console.WriteLine(hexadecimalLiteralOne.GetType());
            Console.WriteLine(binaryLiteralOne.GetType());


            var decimalLiteralTwo = 42U;
            var hexadecimalLiteralTwo = 0x2AU;
            var binaryLiteralTwo = 0b_0010_1010U;
            Console.WriteLine(decimalLiteralTwo.GetType());
            Console.WriteLine(hexadecimalLiteralTwo.GetType());
            Console.WriteLine(binaryLiteralTwo.GetType());


            var decimalLiteralThree = 42L;
            var hexadecimalLiteralThree = 0x2AL;
            var binaryLiteralThree = 0b_0010_1010l;
            Console.WriteLine(decimalLiteralThree.GetType());
            Console.WriteLine(hexadecimalLiteralThree.GetType());
            Console.WriteLine(binaryLiteralThree.GetType());


            byte amountTwo = 17; // Implicit cast from int to byte
            Console.WriteLine(amountTwo.GetType());
            //byte amountThree = 300;  // CS0031: Constant value '300' cannot be converted to a 'byte'

            var signedByte = (sbyte)42;
            Console.WriteLine(signedByte.GetType());
            var longVariable = (long)42;
            Console.WriteLine(longVariable.GetType());
        }

    }
}
