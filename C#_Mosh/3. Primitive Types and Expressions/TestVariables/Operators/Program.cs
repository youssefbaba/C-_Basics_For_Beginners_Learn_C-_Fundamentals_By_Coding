using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
            
        {
            // #Bitwise Operators : 

            // -Logical AND operator &
            //The result of x & y is true if both x and y evaluate to true. Otherwise, the result is false.

            bool SecondOperand()
            {
                Console.WriteLine("Second operand is evaluated.");
                return true;
            }

            bool checkOne = false & SecondOperand();
            Console.WriteLine(checkOne);
            // output  : Second operand is evaluated.
            // output :  false

            bool checkTwo = true & SecondOperand();
            Console.WriteLine(checkTwo);
            // output  : Second operand is evaluated.
            // output :  true

            // -Logical OR operator |
            //The result of x | y is true if either x or y evaluates to true. Otherwise, the result is false.

            bool checkThree = true | SecondOperand();
            Console.WriteLine(checkThree);
            // output  : Second operand is evaluated.
            // output :  true

            bool checkFour = false | SecondOperand();
            Console.WriteLine(checkFour);
            // output  : Second operand is evaluated.
            // output :  false



            // # Logical Operators : 
            // -Logical negation operator !
            bool passed = false;
            Console.WriteLine(!passed); // output : true
            Console.WriteLine(!true); // output : false 

            // -Conditional logical AND operator &&
            // same as Logical AND operator & , but doesn't evaluate the right-hand operand if the left-hand operand evaluates to false.

            // -Conditional logical OR operator ||
            // same as logical OR operator | ,  but doesn't evaluate the right-hand operand if the left-hand operand evaluates to true.




            // #Postfix Increment 
            int numberOne = 1;
            int numberTwo = numberOne++;

            Console.WriteLine(numberOne); // output : 2 
            Console.WriteLine(numberTwo); //output : 1




            // #Prefix Increment 
            int numberThree = 4;
            int numberFour = ++numberThree;
            Console.WriteLine(numberThree); // output : 5 
            Console.WriteLine(numberFour); // output : 5


            // Test
            int number1 = 10;
            int number2 = 5;
            Console.WriteLine(number1++);
            Console.WriteLine(++number2);

            // Assignement Operator 
            int valueOne = 4;
            int valueTwo = 7;
            Console.WriteLine(valueOne+=3); // valueOne = valueOne + 3
            Console.WriteLine(valueTwo-=2); // valueTwo = valueTwo - 2
            Console.WriteLine(valueTwo *= 2); // valueTwo = valueTwo * 2
            //Console.WriteLine((float)valueTwo /= 3);


            try
            {
                byte a = 13; // 0000  1101
                byte b = Convert.ToByte(300);  // CS0031: Constant value '300' cannot be converted to a 'byte'
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The Number cannot represented to byte.");
            }

            // - Integer Division
            Console.WriteLine(13 / 5);    // output: 2
            Console.WriteLine(-13 / 5);   // output: -2
            Console.WriteLine(13 / -5);   // output: -2
            Console.WriteLine(-13 / -5);  // output: 2

            Console.WriteLine(13 / 5.0);  // output : 2.6
            int valueO = 13;
            int valueT = 5;
            Console.WriteLine(Convert.ToDouble(valueO) / valueT); // output : 2.6




            // -Floating-point division
            Console.WriteLine(16.8f / 4.1f);   // output: 4.097561
            Console.WriteLine(16.8d / 4.1d);   // output: 4.09756097560976
            Console.WriteLine(16.8m / 4.1m);   // output: 4.0975609756097560975609756098

            // - Integer Remainder
            // The sign of the non-zero remainder is the same as the sign of the left-hand operand

            Console.WriteLine(5 % 3);   // output: 2 
            Console.WriteLine(7 % -4);  // output: 3
            Console.WriteLine(-6 % 4);  // output: -2
            Console.WriteLine(-8 % -3); // output: -2

            // - floating-point remainder
            // the result of x % y for the finite x and y is the value z such that
            // The sign of z, if non-zero, is the same as the sign of x
            Console.WriteLine(-5.2f % 2.0f); // output: -1.2
            Console.WriteLine(5.9 % 3.1);    // output: 2.8
            Console.WriteLine(-7.6m % 3.2m);   // output: -1.2


            // -String concatenation
            Console.WriteLine("Hello" + "Youssef" + "Baba");
            float Pi = 3.14f;
            Console.WriteLine("Probably the oldest constant: " + Pi);
            Console.WriteLine(null + "Nothing to add.");

            //Unary plus and minus operators
            Console.WriteLine(+4); // output : 4
            Console.WriteLine(-4); // output : -4
            Console.WriteLine(-(-4));  // output : 4

            // -Integer arithmetic overflow

            //int devident = 10;
            //Console.WriteLine(devident / 0);

            int maxValue = int.MaxValue; // 2,147,483,647   =  01111111 11111111 11111111 11111111
            int numberF = 3;
            Console.WriteLine(unchecked(maxValue + numberF));
            //try
            //{
            //    Console.WriteLine(checked(maxValue + numberF));
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Overflow occurred when adding {0} and {1}", maxValue, numberF);
            //}

            double numberFv = 1.0 / 0.0;
            Console.WriteLine(numberFv);                    // output: Infinity
            Console.WriteLine(double.IsInfinity(numberFv)); // output: True

            int numberaa = 1;
            int numberbb = 3;
            int numbercc = 10;
            Console.WriteLine(numberaa == numberbb);  // two negative equal positive 
            Console.WriteLine(!((numbercc > numberaa) || (numbercc == numberbb)));  // output :  true || false =  ! true  = false

        }
    }
}
