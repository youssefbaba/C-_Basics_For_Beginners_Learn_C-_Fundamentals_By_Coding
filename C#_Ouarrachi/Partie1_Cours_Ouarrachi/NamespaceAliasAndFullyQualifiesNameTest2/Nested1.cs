using System;
using System.Collections.Generic; // Nested NameSpace System[Collections[Generic]]

// One Way For Unsing Nesting NameSpace
namespace Namespace1
{
    namespace ChildNameSpace
    {
        internal class Nested1
        {
            public static void PrintElementList(List<int> myList)
            {
                for (int i = 0; i < myList.Count; i++)
                {
                    Console.WriteLine($"Element[{i}] = {myList[i]}");
                }
            }
        }
    }
}

