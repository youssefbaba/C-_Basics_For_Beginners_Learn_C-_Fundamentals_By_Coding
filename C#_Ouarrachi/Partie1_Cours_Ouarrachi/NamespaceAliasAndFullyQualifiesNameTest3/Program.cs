using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using NamespaceAliasAndFullyQualifiesNameTest3.TeamA; // Importation Of NameSpace
//using NamespaceAliasAndFullyQualifiesNameTest3.TeamB; // Importation Of NameSpace
using NTA = NamespaceAliasAndFullyQualifiesNameTest3.TeamA; // NameSpace Alias
using NTB = NamespaceAliasAndFullyQualifiesNameTest3.TeamB; // NameSpace Alias

internal class Program
{
    // - link4 : https://www.youtube.com/watch?v=IQTbvVemMAg

    static void Main(string[] args)
    {
        /*
            - Why Namespaces:
                 - namespaces are used to organize your programs
                 - they also provide assistance in avoiding name clashes
         */


        //NamespaceAliasAndFullyQualifiesNameTest3.TeamA.ClassA.Print(); // Fully Qualifies Name
        //NamespaceAliasAndFullyQualifiesNameTest3.TeamB.ClassA.Print(); // Fully Qualifies Name

        NTA.ClassA.Print(); // Using Alias
        NTB.ClassA.Print(); // Using Alias



    }
}
// First Method
//namespace NamespaceAliasAndFullyQualifiesNameTest3
//{
//namespace TeamA 
//{ 
//    public class ClassA
//    {
//        public static void Print()
//        {
//            Console.WriteLine($"Team A Print Method.");
//        }
//    }
//}

//namespace TeamB
//{
//    public class ClassA 
//    { 
//        public static void Print()
//        {
//            Console.WriteLine($"Team B Print Method");
//        }
//    }
//}
//}


