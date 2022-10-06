using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NameSpaceOne.NameSpaceChild;
using NS3 = NameSpaceThree; // Alias for namespace
using Nsdm = NameSpaceThree.Admin; // Alias fior member(class)


namespace NameSpaceOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // - link4 : https://www.c-sharpcorner.com/article/working-with-namespaces-in-C-Sharp/#:~:text=In%20C%23%2C%20namespaces%20are%20used,%2C%20interfaces%2C%20enums%20and%20delegates.

            // Declaring a Namespace : 
            /*
             
             -The C# language provide a keyword namespace to create a user defined name space. The general form of declaring a namespace is as follows.

             namespace <namespace_name>
              {
             // Classes and/or Structs and/or Enums and/or Delegates
              }

             - Where namespace is the required keyword. The name of namespace can be any valid C# identifier or combinations of identifiers separated by commas.

             namespace NameSpace1
              {
             // Classes and/or Structs and/or Enums and/or Delegates
              }


            namespace NameSpace1.NameSpaceChild
              {
             // Classes and/or Structs and/or Enums and/or Delegates
              }

             */

            Client cl = new Client();
            cl.Print();

            // Accessing Namespace Members : 
            /*
             - The namespace members can be accessed by using a fully qualified name, which including the namespace name and member name separated by dot(.) from outside the namespace
             
             */

            // using the Fully Qulified Name to access the name space members (class , struct , interface , delgate , enum)

            NameSpaceTwo.Product pr = new  NameSpaceTwo.Product();
            pr.Print();

            // Creating Aliases :
            /*
             - With the help of the keyword using, it is possible to create an alias name for a namespace or type.
             */

            NS3.User user = new NS3.User();
            user.Print();

            Nsdm admin = new Nsdm();
            admin.Print();
        }
    }
}
namespace TestAccessModifiersOfElements // for name space implicilty is public but not modifiable
{
    // - It is not possible to use any access modifiers like private, public etc with a namespace declarations. The namespaces in C# are implicitly have public access and this is not modifiable. 

    // - The namespace elements (class , struct , interface , delegate , enum) can't be explicitly declared as private or protected. The namespace allows only public and internal elements as it members. The default is internal.
    class Person
    {
        // Some Code Here
    }

    public struct Employee
    {
        // Some Code Here
    }

    //private class Car //  the element defined in a namespace cannot be explicilty declared as private or protected
    //{
    //        Some Code Here
    //}

    //protected struct House //  the element defined in a namespace cannot be explicilty declared as private or protected
    //{
    //        Some Code Here
    //}

}

// Nesting Namespace way one
namespace Outer
{

    namespace Inner
    {
        public class Class1
        {
            // Core Of Class
        }
    }
}
// Nesting Namespace way two

namespace OuterOne
{
    namespace InnerOne
    {
        public class Class1
        {
            // Code Of Class
        }
    }
}


