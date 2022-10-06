using System; // Importation of necessary namespaces
using System.Collections.Generic; // Importation of necessary Namespaces


namespace NamespaceAliasAndFullyQualifiesName.People  // Declaration of Namespace
{
    public class Person // Decalartion of Class
    {
        // Core of Class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void DisplayElements(List<int> myList)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"Element[{i}] = {myList[i]}");
            }
        }
    }
}
