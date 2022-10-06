using System;

namespace NullableValueType
{
    internal class Program
    {
        static void Main()
        {


            /*
             - Decalartion of Nullable value type : 
                    <value type>? <name_variable> = <value_of_variable>
                    int? age = 20;
                    bool? check = true;
                    double? price = 10.95;
                    char? character = 'a';
             */


            // value type
            int number = 3; // easy
            Console.WriteLine(number);
            Int32 number1 = 3;
            Console.WriteLine(number1);

            bool check = false; // easy
            Console.WriteLine(check);
            Boolean check1 = false;
            Console.WriteLine(check1);

            char letter = 'a'; // easy
            Console.WriteLine(letter);
            Char letter1 = 'b';
            Console.WriteLine(letter1);

            // nullabe value type
            int? number2 = 2; // easy
            Console.WriteLine(number2);
            Nullable<Int32> number3 = 4;
            Console.WriteLine(number3);

            bool? check2 = false; // easy
            Console.WriteLine(check2);
            Nullable<Boolean> check3 = false;
            Console.WriteLine(check3);

            char? character = 'g'; //easy
            Console.WriteLine(character);
            Nullable<Char> characterOne = 'j';
            Console.WriteLine(characterOne);



            //Declaration and assignment : 
            // <value_type>? <name_of_variable> = <value>;

            double? numberOne = 3.14;
            char? letterOne = 'a';

            int numberTwo = 12;
            int? numberThree = numberTwo; // value type implicitly convertible to a corresponding value type
            //int test = numberThree; // Throw an exception (cannot convert type int? to int)
            int test = numberThree.Value;
            int test1 = (int)numberThree;

            bool? checkTwo = null;
            int?[] arrayNumber = new int?[10]; // array of nullable value type

            Console.WriteLine($"####################");


            // default value of nullable value type is null : 

            try
            {
                int? defaulValue = null; // like it doesn't have a value
                Console.WriteLine($"Has Value : {defaulValue.HasValue}"); // false
                //Console.WriteLine($"Value : {defaulValue.Value}"); // Throw an exception

                double? price = 10.95;
                Console.WriteLine($"Has Value : {price.HasValue}"); // true
                Console.WriteLine($"Value : {price.Value}"); // 10.95

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            // Examination of an instance of a nullable value type : 

            //int? numberFour = 42;
            int? numberFour = null;  // like deosn't have value

            if (numberFour.HasValue)
            {
                Console.WriteLine($"Value of {nameof(numberFour)} is {numberFour.Value}");
            }
            else
            {
                Console.WriteLine($"{nameof(numberFour)} doesn't have a value");
            }


            //if (!numberFour.Equals(null))
            //{
            //    Console.WriteLine($"Value of {nameof(numberFour)} is {numberFour.Value}");
            //}
            //else
            //{
            //    Console.WriteLine($"{nameof(numberFour)} does'nt have a value");
            //}

            //if (numberFour != null)
            //{
            //    Console.WriteLine($"Value of {nameof(numberFour)} is {numberFour.Value}");
            //}
            //else
            //{
            //    Console.WriteLine($"{nameof(numberFour)} does'nt have a value");
            //}


            // Conversion from a nullable value type to an underlying type : 

            try
            {
                double? weight = 1.5;
                //double? weight = null;
                //double weightTotal = (double)weight  * 10;  // Throw an Exception in case of weight is null 
                double weightTotal = weight.Value * 20;    // Throw an Exception in case of weight is null
                Console.WriteLine(weightTotal);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            int? numberFive = 28;
            //int numberSix = (int)numberFive - 1;
            int numberSix = numberFive.Value - 1;
            Console.WriteLine($"{nameof(numberSix)} is {numberSix}"); // 27

            try
            {
                int? c = null;
                int d = c.GetValueOrDefault() - 1;
                Console.WriteLine($"{nameof(d)} is {d}"); //  -1

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            // Lifted operators : 
            // General Rule : Operation produce null if one or both operands are null; otherwise, the operator uses the contained values of its operands to calculate the result
            // Special Rules : - bool? with logical OR(|) and logical AND(&)
            //                -  Comparison operators  : <  >  <=  >=
            //                -  Equality operator  : ==
            //                -  Enequality operator  : !=


            int? amount1 = 10;
            int? amount2 = null;
            int? amount3 = 10;

            amount1++;
            Console.WriteLine($"{nameof(amount1)} is {amount1}");  // 11
            amount1 = amount1 * amount3;
            Console.WriteLine($"{nameof(amount1)} is {amount1}");  // 11 * 10  = 110
            amount1 = amount1 + amount2;
            Console.WriteLine($"{nameof(amount1)} is {amount1}");  // 110 + null  = null

            // bool? with logical OR(|) and logical AND(&)
            try
            {
                bool? login = true;
                bool? chec = null;
                Console.WriteLine($"{login} & true is {login & true}"); // true
                Console.WriteLine($"{login} | false is {login | false}"); // true
                Console.WriteLine($"{login} & null is {login & null}"); // null
                Console.WriteLine($"{login} |  true is {login | true}"); // true
                Console.WriteLine($"false & false is {false & false}"); // false
                Console.WriteLine($"chec | chec is {chec | chec}"); // null
                Console.WriteLine($"chec & chec is {chec | chec}"); // null

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // Comparison operators 
            try
            {
                int? a = 10;
                Console.WriteLine($"{a} >= null is {a >= null}"); // null
                Console.WriteLine($"{a} < null is {a < null}"); // null
                Console.WriteLine($"{a} == null is {a == null}"); // false

                int? b = null;
                int? c = null;
                Console.WriteLine($"null >= null is {b >= c}");  // false
                Console.WriteLine($"null == null is {b == c}"); // true
                Console.WriteLine($"null != null is {b != c}"); // false
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            // boxing and unboxing : 
            // - nullabale value type is value type
            try
            {
                int? num = null;
                Console.WriteLine(num.HasValue); // false
                object obj = num;  // Boxing
                Console.WriteLine(obj);  // null
                Console.WriteLine(obj.GetType()); // Exception : NullReferenceException
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            double? height = 1.62;
            Console.WriteLine(height.HasValue);
            object obj2 = height;  // Boxing Of double height = 1.62;
            Console.WriteLine(obj2.GetType()); // System.Double
            Console.WriteLine(obj2 is double); // true
            try
            {
                int? a = 41;
                object aBoxed = a;  // Boxing
                int? aNullable = (int)aBoxed;  //Unboxing
                Console.WriteLine($"Value of aNullable: {aNullable}"); // Value of aNullable: 41

                object aNullableBoxed = aNullable; //Boxing
                if (aNullableBoxed is int valueOfA)
                {
                    //Console.WriteLine("aNullableBoxed is boxed int: {0}" , valueOfA); // aNullableBoxed is boxed int:41
                    Console.WriteLine("aNullableBoxed is boxed int: {0}", valueOfA);
                }
            }
            catch (Exception)
            {
                throw;
            }


            // How to identify a nullable value type : 
            Console.WriteLine("##########");
            int? amount = 10;
            Console.WriteLine(amount.GetType()); // System.Int32
            Type typeOne = typeof(double?);
            Type typeTwo = typeof(double);
            Console.WriteLine(typeOne); // System.Nullable[System.Double]
            Console.WriteLine(typeTwo); // System.Double
            Console.WriteLine($"int is : {(IsNullable(typeof(int)) ? "nullable" : "non-nullable")} value type");
            Console.WriteLine($"int? is : {(IsNullable(typeof(int?)) ? "nullable" : "non-nullable")} value type");


            int? amountOne = 10;
            if (amountOne is int)
            {
                Console.WriteLine("int ? instance is compatible with int");
            }
            int amountTwo = 12;
            if (amountTwo is int?)
            {
                Console.WriteLine("int instance is compatible with int ?");
            }

        }
        public static bool IsNullable(Type type)
        {
            if (Nullable.GetUnderlyingType(type) != null)
            {
                return true;
            }
            return false;
        }

    }
}
