using System;


namespace ObjectType
{

    // The Point class is derived from System.Object.
    class Point
    {
        // fields 
        public int x, y;

        // Constructor
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // Overreiding of Equals Method
        public override bool Equals(object obj)
        {
            // If this and obj do not refer to the same type, then they are not equal.
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            // Return true if  x and y fields match.
            Point other = (Point)obj;
            return (this.x == other.x) && (this.y == other.y);
        }

        // Return the XOR of the x and y fields.
        public override int GetHashCode()
        {
            return x ^ y;
        }

        // Return the point's value as a string.
        public override string ToString()
        {
            return $"({x} , {y})";
        }

        // Return a copy of this point object by making a simple field copy.
        public Point Copy()
        {
            return (Point)this.MemberwiseClone();
        }
    }

    class Program
    {
        static void Main()
        {


            // the object type is an alias of .Net type System.Object
            // default value for variable of type object is null
            object obj1 = "Hello youssef baba have a nice day .";  // string
            Console.WriteLine(obj1);
            Console.WriteLine(obj1.GetType());  // System.String
            System.Object obj2 = "Hello hassna baba have a good day .";
            Console.WriteLine(obj2);
            Console.WriteLine(obj2.GetType());  // System.String
            object obj3 = 'A';  // character
            Console.WriteLine(obj3);
            Console.WriteLine(obj3.GetType());  // System.Char
            object obj4 = 12.3; // double
            Console.WriteLine(obj4);
            Console.WriteLine(obj4.GetType());  // System.Double
            object obj5 = 5; // integer
            Console.WriteLine(obj5);
            Console.WriteLine(obj5.GetType());  // System.Int32
            object obj6 = null; // default value
            Console.WriteLine(obj6);
            //Console.WriteLine(obj6.GetType());  // Throw Exception

            // What is the object type : 
            /*
             - The object type is an alias for the System.Object class which is the base class for all data types in the C# CTS (Common Type System).
             - You can assign values of any type to variables of type object .
             - all types, predefined(primitive) and user-defined(non-primitive), reference types and value types, inherit directly or indirectly from System.Object. that means its parent of all type
             */

            // How to declare an object type :
            /*
             - To declare or initialize a variable of object type, we use the keyword object as the type.
             // Decalaration :
                object name_Of_Object;
             // Initialization : 
                object name_Of_Object = value ;
             
             */

            object number; // Decalaration
            object message = "Hello World";  // Declaration and Initialization
            Console.WriteLine(message); // Hello world


            // Object arrays :
            /*
             - Object arrays can store elements of different types in a single collection, almost like a Tuple.
             */

            object[] crazyArray = new object[] { 'A', "Hello", 12, 2.5 };
            foreach (var item in crazyArray)
            {
                Console.WriteLine($"{item} is of type {item.GetType().Name}");
            }

            // Boxing and unboxing object types

            float amount = 10.5f;
            object num = amount; // Boxing  => implicit conversion from float type (value type) to object type
            float amount1 = (float)amount; // Unboxing => explicit conversion from object type to value type




            // Construct a Point object
            Point point1 = new Point(1, 2);

            // Make another Point object that is a copy of the first.
            Point point2 = point1.Copy();

            // Make another variable that references the first Point object.
            Point point3 = point1;

            // The line below displays false because point1 and point2 refer to two different objects.
            Console.WriteLine(Object.ReferenceEquals(point1, point2)); // False

            // The line below displays true because point1 and point2 refer to two different objects that have the same value.
            Console.WriteLine(Object.Equals(point1, point2)); //  True

            // The line below displays true because point1 and point3 refer to one object.
            Console.WriteLine(Object.ReferenceEquals(point1, point3));  // True

            // The line below displays: point1's value is: (1, 2)
            Console.WriteLine($"point1's value is: {point1}"); //  point1's value is: (1 , 2)


            Console.WriteLine("################# Constructor #################");

            object obj7 = new object(); // Create a new object
            obj7 = "Hi Youssef"; // Initiaization of obj7
            Console.WriteLine($"value of {nameof(obj7)} is \"{obj7}\" and its type is {obj7.GetType()}");


            // Because all classes in .NET are derived from Object class, every method defined in the Object class is available in all objects in the system.
            // Derived classes can and do override some of these methods, including: Equals , Finalize , GetHashCode , ToString 

            string myString = "Hello";
            Console.WriteLine(myString.Equals("youssef")); // False
            Console.WriteLine(myString.GetHashCode());
            Console.WriteLine(myString.GetType());
            Console.WriteLine(myString.ToString());

            char myCharacter = 'A';
            Console.WriteLine(myCharacter.Equals('A')); // True
            Console.WriteLine(myCharacter.GetHashCode());
            Console.WriteLine(myCharacter.GetType());
            Console.WriteLine(myCharacter.ToString());

            int myNumber = 1245;
            Console.WriteLine(myNumber.Equals(124)); // False 
            Console.WriteLine(myNumber.GetHashCode());
            Console.WriteLine(myNumber.GetType());
            Console.WriteLine(myNumber.ToString());

            Console.WriteLine("############## Equals(object obj) ################");

            object obj8 = "Hello";
            object obj9 = 123;
            Console.WriteLine(obj8.Equals(obj9)); // False
            Point point4 = new Point(2, 6);
            Point point5 = point4.Copy();
            Console.WriteLine(point5.Equals(point4)); // True






        }
    }
}
