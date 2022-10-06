namespace NativeSizedInteger
{
    class Program
    {
        static void Main()
        {
            unsafe
            {
                Console.WriteLine($"size of nint = {sizeof(nint)}");
                Console.WriteLine($"size of nuint = {sizeof(nuint)}");
            }
            Console.WriteLine($"size of nint = {IntPtr.Size}");
            Console.WriteLine($"size of nUint = {UIntPtr.Size}");

            // minimum and maximum value of native sized
            Console.WriteLine($"minimum value of nint = {nint.MinValue}");
            Console.WriteLine($"maximum value of nint = {nint.MaxValue}");
            Console.WriteLine($"minimum value of nuint = {nuint.MinValue}");
            Console.WriteLine($"maximum value of nuint = {nuint.MaxValue}");

            nint a = 42;
           
        }
    }
}