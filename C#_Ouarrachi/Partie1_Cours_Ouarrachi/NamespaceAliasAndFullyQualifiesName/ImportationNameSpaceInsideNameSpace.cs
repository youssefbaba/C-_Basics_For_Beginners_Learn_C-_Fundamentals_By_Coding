
namespace NamespaceAliasAndFullyQualifiesName
{
    using System; // Importation of Namespace inside other Namespace
    public class ImportationNameSpaceInsideNameSpace
    {
        public void Display()
        {
            Console.WriteLine($"Hello World");
        }
    }
}
namespace NamespaceAliasAndFullyQualifiesName
{
    public class Test
    {
        public void Display()
        {
            System.Console.WriteLine($"Hello World");
        }
    }
}

