using System;

namespace DifferentBetweenRefAndOutKeyword

/*
 The ref and out keyword can be used with any data type. The main purpose of the ref keyword is to make any type a reference type,
in other words when we add a ref keyword in a method call then the C# compiler does not create a new variable,
it just creates a copy of that type that only points to that specific variable that we declared and any changes made to that variable will be reflected in that variable
 */

// ref :
// Link1 : https://codewala.net/2016/05/22/passing-a-reference-type-using-ref-keyword/
// Link2 : https://www.decodejava.com/csharp-ref-parameter.htm
// link3 : https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref

// out : 
// Link1 : https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out-parameter-modifier
// Link2 : https://www.decodejava.com/csharp-out-parameter.htm

// differrent between ref and out :
// link1 : https://www.c-sharpcorner.com/UploadFile/ff2f08/ref-vs-out-keywords-in-C-Sharp/#:~:text=Ref%20and%20out%20keywords%20in,pass%20a%20parameter%20by%20reference.
// link2 : https://www.youtube.com/watch?v=lYdcY5zulXA&feature=emb_title
/*
 - Ref :
    - Ref is keyword in C# helps to pass variables by reference
    - The argument must be initialized first before it is passed to ref.
    - It is not required to assign or initialize the value of a parameter (which is passed by ref) before returning to the calling method.
    - When we use REF, data can be passed bi-directionally.
    - Both ref and out are treated differently at run time and they are treated the same at compile time.
    - Properties are not variables, therefore it cannot be passed as an out or ref parameter.
 - Out :
    - Out is keyword in C# helps to pass variables by reference
    - It is not compulsory to initialize a argument before it is passed to an out.
    - A called method is required to assign or initialize a value of a parameter (which is passed to an out) before returning to the calling method.
    - When we use OUT data is passed only in a unidirectional way (from the called method to the caller method).
    - Both ref and out are treated differently at run time and they are treated the same at compile time.
    - Properties are not variables, therefore it cannot be passed as an out or ref parameter.
    
 */


{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public static void UpdateName(Person p)
        {
            //p.FirstName = "Hassna";  
            p = null;
        }
        public static void UpdateFullName(ref Person p)
        {
            p.FirstName = "Hassna";
            p.LastName = "Baba";
            //p = null;
        }

    }
    public class Calculate
    {
        public void Add(int number)
        {
            number += 10;
        }
        public void Mull(ref int number)
        {
            number *= 10;
        }
        public void SwapCharacter(ref char letter1, ref char letter2)
        {
            char permute;
            permute = letter1;
            letter1 = letter2;
            letter2 = permute;
        }
    }
    public class A
    {
        public int i;
        public static void ModRef(ref A ob1, ref A ob2)
        {
            Console.WriteLine("The ModRef() method is called to modify the passed references");
            A ob = ob1;
            ob1 = ob2;
            ob2 = ob;
        }
    }
    public class StringHolder
    {
        public string Value { get; set; }
        public override string ToString()
        {
            return Value;
        }
    }

    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public static void UpdateName(Name name)
        //{
        //    //name.FirstName = "Rahul";
        //    name = null;
        //}

        //public static void UpdateName(ref Name name)
        //{
        //    //name.FirstName = "Rahul";
        //    name = null;
        //}

        public static void UpdateName(out Name name)
        {
            name = new Name { FirstName = "Brij", LastName = "Mishra" };
            name.FirstName = "Rahul";
            //name = null;
        }

        public struct IntHolder
        {
            public int Value { get; set; }
            public override string ToString()
            {
                return Value.ToString();
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                int num = 12;
                Console.WriteLine($"value of variable num before : {num}"); // 12
                Square(num);
                Console.WriteLine($"value of variable num after : {num}"); // 12


                int value = 10;
                Console.WriteLine($"value of variable value before : {value}"); // 10
                Double(ref value);
                Console.WriteLine($"value of variable value after : {value}"); // 20


                try
                {
                    Person person1 = new Person { FirstName = "Youssef", LastName = "Baba" };
                    Console.WriteLine($"FullName Before : {person1.FirstName} {person1.LastName}"); // FullName Before : Youssef Baba
                    Person.UpdateName(person1);
                    Console.WriteLine($"FullName After : {person1.FirstName} {person1.LastName}"); //  FullName Before : Hassna Baba
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }


                try
                {
                    Person person2 = new Person { FirstName = "Mohamed", LastName = "Zidani" };
                    Console.WriteLine($"FullName Before : {person2.FirstName} {person2.LastName}"); // FullName Before : Mohamed Zidani
                    Person.UpdateFullName(ref person2);
                    Console.WriteLine($"FullName After : {person2.FirstName} {person2.LastName}"); //  FullName Before : Hassna Baba
                }
                catch (NullReferenceException exp)
                {
                    Console.WriteLine(exp.Message);
                }


                Calculate calc = new Calculate();
                int number1 = 10;
                //Before calling the Add() method
                Console.WriteLine($"Before calling the Add() method, the value in {nameof(number1)} is: {number1}"); // Before calling the Add() method, the value in number1 is: 10
                calc.Add(number1);
                //After calling the Add() method
                Console.WriteLine($"After calling the Add() method, the value in {nameof(number1)} is: : {number1}"); // After calling the Add() method, the value in number1 is: 10


                int number2 = 20;
                // Before calling the Mull() method
                Console.WriteLine($"Before the calling the Mull() method, the value in {nameof(number2)} : {number2}"); // Before calling the Mull() method, the value in number2 is : 20
                calc.Mull(ref number2);
                // After calling the Mull() method
                Console.WriteLine($"After the calling the Mull() method, the value in {nameof(number2)} : {number2}"); // After calling the Mull() method, the value in number2 is : 200


                char character1 = 'x';
                char character2 = 'y';
                // Before calling the SwapCharacter() method
                Console.WriteLine($"Before calling the SwapCharacter() method, the value in {nameof(character1)} = {character1} and {nameof(character2)} = {character1}"); // Before calling the SwapCharacter() method, the value in character1 = x and character2 = y
                calc.SwapCharacter(ref character1, ref character2);
                // After calling the SwapCharacter() method
                Console.WriteLine($"After calling the SwapCharacter() method, the value in {nameof(character1)} = {character1} and {nameof(character2)} = {character2}"); // After calling the SwapCharacter() method, the value in character1 = y and character2 = x


                //Creating the first object of A class
                A obj1 = new A();
                //Initializing the instance variable of the first object
                obj1.i = 100;
                //Creating the second object of A class
                A obj2 = new A();
                //Initializing the instance variable of the second object
                obj2.i = 200;
                //Before calling the ModRef() method
                Console.WriteLine($"The value of instance variable, i, of the first object is : {obj1.i}"); // The value of instance variable, i, of the first object is : 100
                                                                                                            //Before calling the ModRef() method
                Console.WriteLine($"The value of instance variable, i, of the second object is : {obj2.i}"); // The value of instance variable, i, of the first object is : 200

                //A.ModRef(obj1, obj2);
                ////After calling the ModRef() method
                //Console.WriteLine($"The value of instance variable, i, of the first object is : {obj1.i}"); // The value of instance variable, i, of the first object is : 100
                ////After calling the ModRef() method
                //Console.WriteLine($"The value of instance variable, i, of the second object is : {obj2.i}"); // The value of instance variable, i, of the first object is : 200


                A.ModRef(ref obj1, ref obj2);
                //After calling the ModRef() method
                Console.WriteLine($"The value of instance variable, i, of the first object is : {obj1.i}"); // The value of instance variable, i, of the first object is : 200
                                                                                                            //After calling the ModRef() method
                Console.WriteLine($"The value of instance variable, i, of the second object is : {obj2.i}"); // The value of instance variable, i, of the first object is : 100


                StringExample(); // Goodbye world

                IntExample(); // 420


                var numbers = new int[] { 69, 420 };
                ref var amount = ref GetNumberInPosition(numbers, 1);
                amount = 10;
                Console.WriteLine($"Number is : {amount}");


                int studentGrade = 75;
                //Console.WriteLine($"Before calling the GiveExtraCredit() method tha value in studentGrade is : {studentGrade}"); // 
                GiveExtraCredit(out studentGrade);  // caller method
                Console.WriteLine($"After calling the GiveExtraCredit() method tha value in studentGrade is : {studentGrade}"); // 75

                //Name myName = new Name { FirstName = "Brij", LastName = "Mishra" };
                //Name.UpdateName(myName);
                //Console.WriteLine($"FullName is : {myName.FirstName} {myName.LastName}");


                //Name myName = new Name { FirstName = "Brij", LastName = "Mishra" };
                //Name.UpdateName(ref myName);
                //Console.WriteLine($"FullName is : {myName.FirstName} {myName.LastName}");


                Name myName;
                Name.UpdateName(out myName);
                Console.WriteLine($"FullName is : {myName.FirstName} {myName.LastName}");

                int value1 = 10;
                int value2 = 20;
                int addValue;
                int multValue;
                AddMult(value1, value2, out addValue, out multValue);
                Console.WriteLine($"{value1} + {value2} = {addValue}");
                Console.WriteLine($"{value1} * {value2} = {multValue}");
            }
            static void Square(int number)
            {
                number *= number;
                Console.WriteLine($"value of variable number inside square method : {number}"); // 144
            }
            static void Double(ref int number)
            {
                number *= 2;
                Console.WriteLine($"value of variable number double method : {number}"); // 20
            }

            static void StringExample()
            {
                StringHolder stringHolder = new StringHolder();
                stringHolder.Value += "Hello";
                AppendWorld(ref stringHolder);
                Console.WriteLine(stringHolder);

                void AppendWorld(ref StringHolder str)
                {
                    str.Value += " world";
                    //str = new StringHolder { Value = "Goodbye world" };
                }
            }
            static void IntExample()
            {
                IntHolder intHolder = new IntHolder();
                intHolder.Value = 69;
                ChangeValue(ref intHolder);
                Console.WriteLine(intHolder);

                void ChangeValue(ref IntHolder intH)
                {
                    //intH.Value = 420;
                    intH = new IntHolder { Value = 1000 };
                }
            }
            static ref int GetNumberInPosition(int[] array, int position)
            {
                return ref array[position];
            }

            static void GiveExtraCredit(out int studentGrade) // called method
            {
                studentGrade = 10;
                studentGrade += 3;
            }

            // Generally we use the out parameter for return more than one value from a method : 

            static void AddMult(int number1, int number2, out int add, out int mult)
            {
                add = number1 + number2;
                mult = number1 * number2;
            }
        }
    }
}

