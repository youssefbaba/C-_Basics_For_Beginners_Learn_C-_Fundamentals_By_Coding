using System;

namespace MemoryManagementStackHeap
{


    public class Person
    {
        public string Name;
        public int Age;
        public Person Spouce;

        public static void CelebrateBirthday(Person person)
        {
            person.Age = person.Age + 1;
        }
        public static Person CreatePerson()
        {
            Person person = new Person { Name = "Omar", Age = 24 };
            return person;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // link1 : https://medium.com/c-programming/c-memory-management-part-1-c03741c24e4b
            // link2 : https://www.youtube.com/watch?v=clOUdVDDzIM
            // link3 : https://endjin.com/blog/2022/07/understanding-the-stack-and-heap-in-csharp-dotnet
            // link4 : https://jonskeet.uk/csharp/memory.html

            int x = 3;
            int y = x;
            x = 5;

            Console.WriteLine($"x = {x}"); // x = 5
            Console.WriteLine($"y = {y}"); // y = 3


            Person alice = new Person { Name = "Alice", Age = 26 };
            Person bob = alice;
            bob.Name = "Bob";
            Console.WriteLine($"name of {nameof(alice)} is {alice.Name}");
            Console.WriteLine($"name of {nameof(bob)} is {bob.Name}");


            Person p1 = new Person { Name = "Hassna", Age = 30 };
            Person p2 = new Person { Name = "Youssef", Age = 25 };
            p1.Spouce = p2;
            Console.WriteLine(p1);
            Person.CelebrateBirthday(p2);
            Console.WriteLine(p2.Age); // 26

            Person p3 = Person.CreatePerson();
        }
    }
}
