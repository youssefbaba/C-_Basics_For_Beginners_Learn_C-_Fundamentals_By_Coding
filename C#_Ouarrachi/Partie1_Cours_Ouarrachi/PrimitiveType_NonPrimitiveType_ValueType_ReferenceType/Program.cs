using System;

namespace PrimitiveType_NonPrimitiveType_ValueType_ReferenceType
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float number = 10.2f;
            int number1 = 10;
            double number3 = 10.3;
            const int number4 = 10;
            bool Ischeck = false;
            char charachter = 'h';
            string name = "dd";
            Console.WriteLine(number.CompareTo(8.2f));
            DateTime date = DateTime.Now;


            Console.WriteLine(default(int));
            Console.WriteLine(default(float));
            Console.WriteLine(default(char).Equals('\0'));
            Console.WriteLine(default(bool));
            Console.WriteLine(default(string)); // null
            Console.WriteLine(default(object)); // null

            //Console.WriteLine("Min value of interger type : {0}" , int.MinValue);
            //Console.WriteLine("Max value of interger type : {0}", int.MaxValue);
            //Console.WriteLine("Min value of float type : {0}", float.MinValue);
            //Console.WriteLine("Max value of float type : {0}", float.MaxValue);


        }



        /*
         - primitive type (Predefine)  , non-primitive (User defined)
         - Primitive type: 
                - primitive value type : sbyte , byte , short , ushort , int , uint , long , ulong , nint , nuint , float , double , decimal , char , bool 
                - primitive reference type : string , object , dynamic
         - In C#, primitive data types are actually objects, It means when you create primitive type variable, a variable is actually an Object.
         - each primitive type except dynamic is an alias for the corresponding .NET type. They are interchangeable: 
                int => System.Int32 
                float => System.Single
                bool => System.Boolean
                char  => System.Char
                string => System.String
                object => System.Object
                .
                .

                For example :
                                int number =  10;
                                System.Int32 number = 10;

                                double number2 = 10.3;
                                System.Double number2 = 10.3;

         - Non-primitive type: class , struct , enum , interface , delegate , array 
        */

        /*
         - value type (fixed in size) : - simple type :
                            - Integral numeric types : sbyte , ushort , uint , ulong ,byte , short , int , long
                            - Floating-point numeric types : float , double , decimal
                            - Unicode characters : char
                            - Boolean ; bool
                            - Date
                        - struct type : custom struct
                        - enum type : custom enum  
                        - nullable value type : extensions of all ther value types with null value
         - reference type (not fixed in size) : - class types: custom class  , string , object
                            - interface type : custom interface
                            - array type : single and multi-dimensional array
                            - delegate type : custom delagate
                            - dynamic type : dynamic   

         - You cannot assign null to a variable of a value type but you can use nullable value type
        */


        public struct Point
        {

            private int x; // field 1
            private int y; // filed 2

            public Point(int x, int y) // Constructor
            {
                this.x = x;
                this.y = y;
            }

            public int X
            {
                get { return x; }
                set { x = value; }
            }
            public int Y
            {
                get { return x; }
                set { x = value; }
            }
        }
        public class Form
        {
            private int x; // field one
            private int y; // field two

            public Form(int x, int y) // Constructor
            {
                this.x = x;
                this.y = y;
            }

            public int X
            {
                get { return x; }
                set { x = value; }
            }
            public int Y
            {
                get { return y; }
                set { y = value; }
            }
        }
    }
}
