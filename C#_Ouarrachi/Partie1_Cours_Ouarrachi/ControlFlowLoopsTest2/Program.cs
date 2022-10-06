using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace ControlFlowLoopsTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             - link : https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements
             */

            //// Exmaple to display numbers from 1 to 10 without using loop :
            //Console.WriteLine("Display numbers fhorm 1 to 10 without using loop : ");
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            //// Example to display number from 1 to 10 using loop :
            //Console.WriteLine("Display numbers fhorm 1 to 10 using loop : ");
            //for (int index10 = 0; index10 <= 10; index10++)
            //{
            //    Console.WriteLine(index10);
            //}

            //// Example 1 of while loop :

            //Console.WriteLine("Example 1 of while loop");
            //int x = 1;
            //while (x <= 5)
            //{
            //    Console.WriteLine($"Value of {nameof(x)} : {x}");
            //    x++;
            //}

            //// Example 2 of while loop :

            //Console.WriteLine("Example 2 of while loop");
            //Console.Write("Please enter a number : ");
            //int numberOne;
            //if (int.TryParse(Console.ReadLine(), out numberOne))
            //{
            //    int counter = 0;
            //    while (counter <= numberOne)
            //    {
            //        Console.Write($"{counter} ");
            //        counter += 2;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Conversion failed");
            //}


            //// Example 3 of nested while loop :
            //Console.WriteLine("Example 3 of nested while loop");
            //int i = 1;
            //while (i <= 10)
            //{
            //    int j = 1;
            //    while (j <= 10)
            //    {
            //        Console.Write($"{j} ");
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}

            //// Example 4 of nested while loop :
            //Console.WriteLine("Example 4 of nested while loop");
            //Console.Write("Please enter a number : ");
            //int numberTwo;
            //if (int.TryParse(Console.ReadLine(), out numberTwo))
            //{

            //    int k = 1;
            //    while (k <= numberTwo)
            //    {
            //        int j = 1;
            //        while (j <= k)
            //        {
            //            Console.Write($"{j} ");
            //            j++;
            //        }
            //        Console.WriteLine();
            //        k++;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Conversion from  string to falied .");
            //}


            //// Example 1 of do while loop :
            //Console.WriteLine("Example 1 of do while loop");
            //int counterOne = 1;
            //do
            //{
            //    Console.Write($"{counterOne} ");
            //    counterOne++;
            //} while (counterOne <= 5);
            //Console.WriteLine();


            //// Example 2 of nested do while loop :
            //Console.WriteLine("Example 1 of nested do while loop");
            //do
            //{
            //    Console.WriteLine("I'm from outer do while loop.");
            //    do
            //    {
            //        Console.WriteLine("I'm from inner do while loop.");
            //    } while (false);
            //} while (false);

            //// Example 2 of nested do while loop :
            //bool test2 = false;
            //bool test3 = false;
            //int userOperation;
            //string userDecision = string.Empty;
            //do
            //{
            //    bool test1;
            //    do
            //    {
            //        Console.WriteLine("Press 1 for Addition , 2 for Substration , 3 for Multiplication , 4 for Division : ");
            //        test1 = int.TryParse(Console.ReadLine(), out userOperation);
            //        if (test1)
            //        {
            //            Console.WriteLine("Enter the value of two numbers : ");
            //            int operandOne;
            //            int operandTwo;
            //            test2 = int.TryParse(Console.ReadLine(), out operandOne);
            //            test3 = int.TryParse(Console.ReadLine(), out operandTwo);
            //            if (test2 && test3)
            //            {
            //                switch (userOperation)
            //                {
            //                    case 1:
            //                        Console.WriteLine($"Add is {operandOne + operandTwo}");
            //                        break;
            //                    case 2:
            //                        Console.WriteLine($"Sub is {operandOne - operandTwo}");
            //                        break;
            //                    case 3:
            //                        Console.WriteLine($"Mul is {operandOne * operandTwo}");
            //                        break;
            //                    case 4:
            //                        try
            //                        {
            //                            Console.WriteLine($"Div is {(float)operandOne + operandTwo}");
            //                        }
            //                        catch (DivideByZeroException exp)
            //                        {
            //                            Console.WriteLine(exp.Message);
            //                        }
            //                        break;
            //                    default:
            //                        Console.WriteLine("Invalid choice , please try again!");
            //                        break;
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Conversion from string to int failed.");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Conversion from string to int failed.");
            //        }
            //    } while (test1 && test2 && test3 && userOperation != 1 && userOperation != 2 && userOperation != 3 && userOperation != 4);
            //    if (test1 && test2 && test3 && (userOperation == 1 || userOperation == 2 || userOperation == 3 || userOperation == 4))
            //    {
            //        Console.WriteLine("Please Enter Y to continue , any keys to termiante ");
            //        userDecision = Console.ReadLine();
            //    }
            //} while (userDecision.Equals("Y", StringComparison.OrdinalIgnoreCase));


            //PerfectNumberOne();
            //PerfectNumberTwo();
            //NumberOfDigitsOne();
            //NumberOfDigitsTwo();
            //ArmstrongNumber();
            //PrimeNumberOne();
            //PrimeNumberTwo();
            //FibonacciSeries();

        }

        // 0 and 1 aren't perfect numbers .
        public static void PerfectNumberOne()
        {
            Console.Write("Please enter an integer number : ");
            int perfectNumber;
            int sum = 0;
            if (int.TryParse(Console.ReadLine(), out perfectNumber))
            {
                if (perfectNumber >= 0)
                {
                    for (int i = 1; i < perfectNumber; i++)
                    {
                        if ((perfectNumber % i) == 0)
                        {
                            sum = sum + i;
                        }
                    }
                    if ((perfectNumber == sum) && (perfectNumber != 0))
                    {
                        Console.WriteLine($"{perfectNumber} is a perfect number");
                    }
                    else
                    {
                        Console.WriteLine($"{perfectNumber} isn't a perfect number");
                    }
                }
                else
                {
                    Console.WriteLine("The number is less than zero.");
                }
            }
            else
            {
                Console.WriteLine("Conversion from string to int failed.");
            }
        }

        public static void PerfectNumberTwo()
        {
            Console.Write("Please enter an integer number : ");
            int perfectNumber;
            int sum = 0;
            if (int.TryParse(Console.ReadLine(), out perfectNumber))
            {
                if (perfectNumber >= 0)
                {
                    for (int i = 1; i < perfectNumber; i++)
                    {
                        if ((perfectNumber % i) == 0)
                        {
                            sum = sum + i;
                        }
                    }
                    if ((perfectNumber != sum) || (perfectNumber == 0))
                    {
                        Console.WriteLine($"{perfectNumber} isn't a perfect number");
                    }
                    else
                    {
                        Console.WriteLine($"{perfectNumber} is a perfect number");
                    }
                }
                else
                {
                    Console.WriteLine("The number is less than zero.");
                }
            }
            else
            {
                Console.WriteLine("Conversion from string to int failed.");
            }
        }

        public static void NumberOfDigitsOne()
        {
            Console.Write("Please enter an integer number : ");
            int numberOfDigits;
            int quotient;
            int temp;
            int counter = 1;
            if (int.TryParse(Console.ReadLine(), out numberOfDigits))
            {
                temp = numberOfDigits;
                while ((quotient = numberOfDigits / 10) != 0)
                {
                    numberOfDigits = quotient;
                    counter++;
                }
                Console.WriteLine($"Number of digits in {temp} is {counter} digit(s)");
            }
            else
            {
                Console.WriteLine("Conversion from string to int failed.");
            }
        }

        public static void NumberOfDigitsTwo()
        {
            Console.Write("Please enter an integer number : ");
            int numberOfDigits;
            int temp;
            int counter = 1;
            int quotient;
            if (int.TryParse(Console.ReadLine(), out numberOfDigits))
            {
                temp = numberOfDigits;
                while (numberOfDigits > 9)
                {
                    quotient = numberOfDigits / 10;
                    numberOfDigits = quotient;
                    counter++;
                }
                Console.WriteLine($"The number of digits in {temp} is {counter} digit(s)");
            }
        }

        public static void ArmstrongNumber()
        {
            Console.Write("Please enter an integer number : ");
            int armstrongNumber;
            int temp;
            int quotient;
            int remainder;
            double sum = 0;
            List<int> remainders = new List<int>();

            if (int.TryParse(Console.ReadLine(), out armstrongNumber))
            {
                temp = armstrongNumber;
                if (armstrongNumber == 0)
                {
                    remainders.Add(armstrongNumber);
                }
                while (armstrongNumber != 0)
                {
                    quotient = armstrongNumber / 10;
                    remainder = armstrongNumber % 10;
                    armstrongNumber = quotient;
                    remainders.Add(remainder);
                }
                for (int i = 0; i < remainders.Count; i++)
                {
                    sum += Math.Pow(remainders[(remainders.Count - 1) - i], remainders.Count);
                }
                Console.WriteLine($"sum {sum}");
                if (temp == sum)
                {
                    Console.WriteLine($"{temp} is an Armstrong number.");
                }
                else
                {
                    Console.WriteLine($"{temp} isn't an Armstrong number.");
                }
            }
            else
            {
                Console.WriteLine("Conversion from string to int failed.");
            }
        }

        public static void PrimeNumberOne()
        {
            Console.Write("Please enter an integer number : ");
            int primeNumber;
            bool isPrimeNumber = true;
            if (int.TryParse(Console.ReadLine(), out primeNumber))
            {
                if (primeNumber <= 1)
                {
                    Console.WriteLine($"{primeNumber} isn't a prime number.");
                }
                else
                {
                    for (int i = 1; i <= primeNumber; i++)
                    {
                        if ((i != 1) && (i != primeNumber))
                        {
                            if ((primeNumber % i) == 0)
                            {
                                isPrimeNumber = false;
                                break;
                            }
                        }
                    }
                    if (isPrimeNumber)
                    {
                        Console.WriteLine($"{primeNumber} is a prime number");
                    }
                    else
                    {
                        Console.WriteLine($"{primeNumber} isn't a prime number");
                    }
                }
            }
            else
            {
                Console.WriteLine("Conversion from string to int failed.");
            }
        }

        public static void PrimeNumberTwo()
        {
            Console.Write("Please enter an integer number : ");
            int primeNumber;
            bool isPrimeNumber = true;
            if (int.TryParse(Console.ReadLine(), out primeNumber))
            {
                if (primeNumber <= 1)
                {
                    Console.WriteLine($"{primeNumber} isn't a prime number.");
                }
                else
                {
                    for (int i = 2; i < primeNumber; i++)
                    {
                        if ((primeNumber % i) == 0)
                        {
                            isPrimeNumber = false;
                            break;
                        }
                    }
                    if (isPrimeNumber)
                    {
                        Console.WriteLine($"{primeNumber} is a prime number");
                    }
                    else
                    {
                        Console.WriteLine($"{primeNumber} isn't a prime number");
                    }
                }
            }
            else
            {
                Console.WriteLine("Conversion from string to int failed.");
            }
        }

        public static void FibonacciSeries()
        {
            Console.Write("Please enter an integer number : ");
            int number = int.Parse(Console.ReadLine());
            List<int> fibonacciElements = new List<int>();
            for (int i = 0; i <= number; i++)
            {
                if (i <= 1)
                {
                    fibonacciElements.Add(i);
                }
                else
                {
                    fibonacciElements.Add(fibonacciElements[i - 2] + fibonacciElements[i - 1]);
                }
            }
            foreach (int fibonacciElement in fibonacciElements)
            {
                Console.Write($"{fibonacciElement} ");
            }
        }
    }
}