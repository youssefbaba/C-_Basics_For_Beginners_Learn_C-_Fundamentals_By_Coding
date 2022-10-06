
using System;
using TestTwoNamespace.Subnamspace;
using TestThreeNamespace;


namespace TestTwoNamespace.Subnamspace
{
    public class Myclass
    {
        public Myclass()
        {
            Console.WriteLine("My Class");
        }
    }
    class Myclient
    {
        public Myclient()
        {
            Console.WriteLine("My Client");
        }
        public static void Main()
        {
            Myclass mc = new Myclass();
            //TestThreeNamespace.Person.DisplayPerson();
            Person.DisplayPerson();
        }
    }
}

class Product
{

    //TestTwoNamespace.Subnamspace.Myclient cl = new TestTwoNamespace.Subnamspace.Myclient();
    Myclient cl = new Myclient();  // In This Case I imported name space TestTwoNamespace.Subnamspace
}


