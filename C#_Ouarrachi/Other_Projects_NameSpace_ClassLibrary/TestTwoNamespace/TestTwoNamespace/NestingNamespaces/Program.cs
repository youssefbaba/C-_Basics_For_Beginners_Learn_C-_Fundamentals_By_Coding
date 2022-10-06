using System;
//namespace Outer
//{
//    namespace Inner
//    {
//        class Myclass
//        {
//            public Myclass()
//            {
//                Console.WriteLine("My Class");
//            }
//        }
//    }
//}
//class Client{

//    public static void Main()
//    {
//        Outer.Inner.Myclass mc = new Outer.Inner.Myclass();
//    }
//}

namespace Outer.Inner
{
    class Myclass
    {
        public Myclass()
        {
            Console.WriteLine("My Class");
        }
    }
}
class Client
{

    public static void Main()
    {
        Outer.Inner.Myclass mc = new Outer.Inner.Myclass();
    }
}
