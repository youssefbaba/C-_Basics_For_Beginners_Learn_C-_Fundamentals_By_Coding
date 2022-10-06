using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // - implicit conversion

            // byte = 1byte (8bits) ,  int = 4 bytes (32bits)
            byte b = 1; // 00000001 
            int i = b;  // 00000000 00000000 00000000 00000001
            Console.WriteLine(i);


            // - explicit conversion

            // Let's Revert This Code
            int j = 2;   // 00000000 00000000 00000000 00000001
            byte a = (byte)j;   // 00000001
            Console.WriteLine(a);

            int k = 1000; // 00000000 00000000 00000011 11101000
            byte c = (byte) k;  // 11101000
            Console.WriteLine(c);

            // - Not Compatible Type

            var number = "1234";
            int l = Convert.ToInt32(number);
            Console.WriteLine(l);
            try
            {
                var numberTwo = "1245";
                byte m = Convert.ToByte(numberTwo);
                Console.WriteLine(m);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte .");
            }

            try
            {
                string str = "true";
                bool bl = Convert.ToBoolean(str);
                Console.WriteLine(bl);
            }
            catch (Exception)
            {
                Console.WriteLine("The String  could not be converted to a Boolean .");
            }

        }
    }
}
