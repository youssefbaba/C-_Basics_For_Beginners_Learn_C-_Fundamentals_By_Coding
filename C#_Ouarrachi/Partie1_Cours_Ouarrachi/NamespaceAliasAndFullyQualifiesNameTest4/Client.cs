using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaceOne.NameSpaceChild
{
    internal class Client
    {
        public void Print()
        {
            Console.WriteLine($"My Client");
        }
    }
}

// Other way for declaration namespace
//namespace NameSpaceOne
//{
//    namespace NameSpaceChild
//    {
//        public void Print()
//        {
//            Console.WriteLine($"My Client");
//        }
//    }
//}

