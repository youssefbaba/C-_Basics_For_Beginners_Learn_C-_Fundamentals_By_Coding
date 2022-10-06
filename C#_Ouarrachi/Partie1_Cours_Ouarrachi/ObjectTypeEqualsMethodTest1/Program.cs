using System;

namespace EqualityOperatorAndEqualsMethod
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("###################### Equals Method  : default behavior ##############");

            /*
             - Equals method : 
                - If the current instance is a reference type, the Equals(Object) method tests for reference equality.
                - If the current instance is a value type, the Equals(Object) method tests for value equality .
             */

            Person person1 = new Person();
            person1.FirstName = "Youssef";
            person1.LastName = "Baba";
            Person person2 = person1; // person1 and person2 are both point in the same reference and also have same values
            Console.WriteLine(person1.Equals(person2)); // True : Because of the current instance is a reference type , so Equals method check for reference equality  
            Console.WriteLine(person1.FirstName); // Youssef
            Console.WriteLine(person2.FirstName); // Youssef
            Console.WriteLine(person1.LastName); // Baba
            Console.WriteLine(person2.LastName); // Baba


            Person person3 = new Person();
            person3.FirstName = "Youssef";
            person3.LastName = "Baba";
            Console.WriteLine(person1.Equals(person3)); // False : Because person1 and person3 have same values but dont have same reference


            int amount1 = 10;
            int amount2 = 10;
            int amount3 = 12;

            Console.WriteLine(amount1.Equals(amount2)); // True : Because the current instance is a value type , so Equals method check for value equality and 10 = 10
            Console.WriteLine(amount1.Equals(amount3)); // False : Because the current instance is a value type , so Equals method check for value equality and 10 != 12


            Console.WriteLine("############# Equality operator (==) : default behavior ##############");
            /*
             - for reference types other than string, == returns true if its two operands refer to the same object. For the string type, == compares the values of the strings.
             - for value typee :
                - For primitive value types, the equality operator (==) returns true if the values of its operands are equal, false otherwise  (value equality)
                - Two operands of the same enum type are equal if the corresponding values of the underlying integral type are equal. (Cannot applied equality operator to two types of enum)
                - User-defined struct types don't support the == operator by default. To support the == operator, a user-defined struct must overload it.
             */

            Console.WriteLine(person1 == person2); // True : Because person1 and person2 refer to the same object and Person is refrence type differ from string
            Console.WriteLine(person1 == person3); // False : Because person1 and person2  not refer to the same object

            string str1 = "Hello Youssef";
            string str2 = str1; // str1 and str2 refer to the same object and also have tha same value
            Console.WriteLine(str1); // Hello Youssef
            Console.WriteLine(str2); // Hello Youssef
            Console.WriteLine(Object.ReferenceEquals(str1, str2)); // True
            Console.WriteLine(str1 == str2); // True ; Because str1 and str2 have the same value that is Hello Youssef
            string str3 = "Hello Hassna";
            Console.WriteLine(str1 == str3); // False : Because str1 and str2  haven't the same value


            int number1 = 10;
            int number2 = 10;
            int number3 = 12;
            Console.WriteLine(number1 == number2); // True : Because int is primitive value type so in this case equality operator (==) check value equality and 10 = 10
            Console.WriteLine(number1 == number3); // Flase : Because int is primitive value type so in this case equality operator (==) check value equality and 10 != 12


            Direction direction1 = Direction.East;
            Direction direction2 = Direction.West;
            Direction direction3 = Direction.East;
            Console.WriteLine(direction1 == direction3); // True
            Console.WriteLine(direction1 == direction2); // False

            Country country1 = Country.Japan;
            Country country2 = Country.Thailand;
            Country country3 = Country.Spain;
            //Console.WriteLine(direction1 == country1); // cannot applied equality operator (==) to two types of enum 
            Console.WriteLine(direction1 == (Direction)country1); // cannot applied equality operator (==) to two types of enum so i can convert that and then it gives True
            Console.WriteLine(direction1 == (Direction)country3); // False


            Employee emp1 = new Employee("Youssef Baba");
            Employee emp2 = new Employee("Hassna Baba");
            Employee emp3 = new Employee("Youssef Baba");
            //Console.WriteLine(emp1 == emp2);  // cannot applied the equality operator (==) to user-defined (custom) struct so  we need to provide an operator overload for the type.
            Console.WriteLine(emp1 == emp2); // False
            Console.WriteLine(emp1 == emp3); // True


            Customer c1 = new Customer();
            c1.FirstName = "Youssef";
            c1.LastName = "Baba";
            Customer c2 = new Customer();
            c2.FirstName = "Hassna";
            c2.LastName = "Baba";
            Customer c3 = new Customer();
            c3.FirstName = "Youssef";
            c3.LastName = "Baba";
            Console.WriteLine(c1 == c2); // False 
            Console.WriteLine(c1 == c3); // True
            Console.WriteLine(c1.Equals(c2)); // False
            Console.WriteLine(c1.Equals(c3)); // True

        }
    }
    public enum Direction
    {
        East = 1,
        West = 2,
        North = 3,
        South = 4,
    }
    public enum Country
    {
        Japan = 1,
        Thailand = 2,
        Spain = 3,
    }

    public struct Employee
    {
        private string fullName;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public Employee(string fullName)
        {
            this.fullName = fullName;
        }
        public override string ToString()
        {
            return FullName;
        }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.fullName == emp2.fullName;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.fullName != emp2.fullName;
        }
    }

    public class Customer
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public static bool operator ==(Customer c1, Customer c2)
        {
            return (c1.firstName == c2.firstName) && (c1.lastName == c2.lastName);
        }
        public static bool operator !=(Customer c1, Customer c2)
        {
            return (c1.firstName != c2.firstName) || (c1.lastName != c2.lastName);
        }

        public override bool Equals(object obj) // Signature of method
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Customer))
            {
                return false;
            }
            return this.firstName == ((Customer)obj).firstName && this.lastName == ((Customer)obj).lastName;
        }

        public override int GetHashCode()
        {
            return this.firstName.GetHashCode() ^ this.lastName.GetHashCode();
        }



    }
}
