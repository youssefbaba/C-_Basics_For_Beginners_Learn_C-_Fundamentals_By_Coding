using System;

namespace PassingParameter_ByValueAndByReference_
{
    internal class Program
    {

        // Link1 : https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/passing-value-type-parameters
        // Link2 : https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/passing-reference-type-parameters 
        // link3 : https://www.c-sharpcorner.com/UploadFile/ca6c61/concepts-of-C-Sharp-value-type-and-reference-type/
        // link4 : https://www.decodejava.com/csharp-call-by-value.htm
        // link5 : https://www.decodejava.com/csharp-call-by-reference.htm
        static void Main(string[] args)
        {

            // - Passing Value Types by Value :

            int n = 5;
            Console.WriteLine($"The value before calling the method: {n}"); // The value before calling the method: 5
            SquareIt(n);
            Console.WriteLine($"The value after calling the method: {n}"); // The value after calling the method: 5

            void SquareIt(int number)
            {
                number *= number;
                Console.WriteLine($"The value inside the method: {number}"); // The value inside the method: 25
            }

            // - Passing Value Types by Reference :

            int value = 5;
            Console.WriteLine($"The value before calling the method: {value}"); // The value before calling the method: 5
            Double(ref value);
            Console.WriteLine($"The value after calling the method: {value}"); // The value after calling the method: 10


            void Double(ref int number)
            {
                number *= 2;
                Console.WriteLine($"The value inside the method: {number}"); // The value inside the method: 10
            }

            // Swaping Value Types 

            int i = 2;
            int j = 3;
            Console.WriteLine($"i = {i} j = {j}"); // i = 2 j = 3
            NoSwap(i, j);
            Console.WriteLine($"i = {i} j = {j}"); // i = 2 j = 3

            void NoSwap(int a, int b)
            {
                int e = a;
                a = b;
                b = e;
            }

            int val1 = 2;
            int val2 = 3;
            Console.WriteLine($"val1 = {val1}  val2 = {val2}");
            Swap(ref val1, ref val2);
            Console.WriteLine($"val1 = {val1}  val2 = {val2}");


            void Swap(ref int num1, ref int num2)
            {
                int emp = num1;
                num1 = num2;
                num2 = emp;
            }

            // - Passing Reference Types by Value :

            int[] numbers = new int[] { 1, 4, 5 }; // array is reference type
            Console.WriteLine($"Inside Main before calling the method ChangeNumber(), the first element of numbers[] is : {numbers[0]}"); // Inside Main before calling the method ChangeNumber(), the first element of numbers[] is : 1
            ChangeNumber(numbers);
            Console.WriteLine($"After calling the method ChangeNumber(), the first element is : {numbers[0]}"); // After calling the method Change(), the first element is : 8

            void ChangeNumber(int[] newNumbers)
            {
                newNumbers[0] = 8;
                Console.WriteLine($"Inside the method ChangeNumber(), the first element of newNumbers[] is : {newNumbers[0]}"); // Inside the method Change(), the first element of newNumbers[] is : 8
                Console.WriteLine($"Inside the method ChangeNumber(), the first element of numbers[] is : {numbers[0]}"); // Inside the method Change(), the first element of numbers[] is : 8
                newNumbers = new int[] { -1, -2, -3, -4, -5 };
                Console.WriteLine($"Inside the method ChangeNumber(), the first element of newNumbers[] is : {newNumbers[0]}"); // Inside the method Change(), the first element of newNumbers[] is : -1
                newNumbers[0] = 10;
                Console.WriteLine($"Inside the method ChangeNumber(), the first element of newNumbers[] is : {newNumbers[0]}"); // Inside the method Change(), the first element of newNumbers[] is : 10 

                //try
                //{
                //    newNumbers = null;
                //    newNumbers[0] = 10; // Throw Exception
                //    Console.WriteLine($"Inside the method Change(), the first element is : {newNumbers[0]}"); // Throw Exception
                //}
                //catch (NullReferenceException ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}
            }

            // - Passing Reference Types by Reference : 

            int[] prices = new int[] { 10, 20, 30, 40 };
            Console.WriteLine($"Inside Main, before calling the method ChangePrice(), the first element of prices[] is : {prices[0]}"); // Inside Main, before calling the method Change(), the first element of prices[] is : 10
            ChangePrice(ref prices);
            try
            {
                Console.WriteLine($"Inside Main, after calling the method ChangePrice(), the first element of prices[] is : {prices[0]}"); //  Inside Main, after calling the method ChangePrice(), the first element of prices[] is : 1000 , throw exception
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            void ChangePrice(ref int[] newPrices)
            {
                newPrices[0] = 50;
                Console.WriteLine($"Inside the method ChangePrice(), the first element of newPrices[] is : {newPrices[0]}"); // Inside the method ChangePrice(), the first element of newPrices[] is : 50
                Console.WriteLine($"Inside the method ChangePrice(), the first element of prices[] is : {prices[0]}"); // Inside the method ChangePrice(), the first element of prices[] is : 50
                newPrices = new int[] { 100, 200, 300, 400 };
                Console.WriteLine($"Inside the method ChangePrice(), the first element of newPrices[] is : {newPrices[0]}"); // Inside the method ChangePrice(), the first element of newPrices[] is : 100
                Console.WriteLine($"Inside the method ChangePrice(), the first element of prices[] is : {prices[0]}"); // Inside the method ChangePrice(), the first element of prices[] is : 100
                newPrices[0] = 1000;
                Console.WriteLine($"Inside the method ChangePrice(), the first element of newPrices[] is : {newPrices[0]}"); // Inside the method ChangePrice(), the first element of newPrices[] is : 1000
                Console.WriteLine($"Inside the method ChangePrice(), the first element of prices[] is : {prices[0]}"); // Inside the method ChangePrice(), the first element of prices[] is : 1000

                //try
                //{
                //    newPrices = null;
                //    newPrices[0] = 2000;
                //    Console.WriteLine($"Inside the method ChangePrice(), the first element of Newprices[] is : {newPrices[0]}"); // 

                //}
                //catch (Exception exp)
                //{
                //    Console.WriteLine(exp.Message);
                //}

            }

            // - Swapping Two Strings : 

            string str1 = "Hello"; // string is reference type
            string str2 = "World";
            Console.WriteLine($"Inside Main before calling the method NoSwapStrings() : str1 = {str1} , str2 = {str2}"); // Inside Main before calling the method NoSwapStrings() : str1 = Hello , str2 = World
            NoSwapStrings(str1, str2);
            Console.WriteLine($"Inside Main after calling the method NoSwapStrings() : str1 = {str1} , str2 = {str2}"); // Inside Main after calling the method NoSwapStrings() : str1 = Hello , str2 = World

            void NoSwapStrings(string string1, string string2)
            {
                string emp = string1;
                string1 = string2;
                string2 = emp;
                Console.WriteLine($"Inside NoSwapStrings() method  : string1 = {string1} , str2 = {string2}"); // Inside NoSwapStrings() method  : string1 = World , str2 = Hello

            }
            Console.WriteLine("##### Swap Strings ####");


            string strin1 = "Youssef";
            string strin2 = "Baba";
            Console.WriteLine($"Inside Main before calling the method SwapStrings() strin1 = {strin1} , strin2 = {strin2}"); // Inside Main before calling the method SwapStrings() strin1 = Youssef , strin2 = Baba
            SwapStrings(ref strin1, ref strin2);
            Console.WriteLine($"Inside Main after calling the method SwapStrings() strin1 = {strin1} , strin2 = {strin2}"); // Inside Main after calling the method SwapStrings() strin1 = Baba , strin2 = Youssef


            void SwapStrings(ref string string1, ref string string2)
            {
                string emp = string1;
                string1 = string2;
                string2 = emp;
                Console.WriteLine($"Inside the method SwapStrings() string1 = {string1} , string2 = {string2}"); // Inside the method SwapStrings() string1 = Baba , string2 = Youssef
            }





        }
    }
}
