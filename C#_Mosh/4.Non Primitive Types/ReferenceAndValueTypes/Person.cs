using System;

namespace ReferenceAndValueTypes
{
    class Person
    {
        public int Age;
        public static void Increment(int number)
        {
            number += 10;
        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }

    }
}
