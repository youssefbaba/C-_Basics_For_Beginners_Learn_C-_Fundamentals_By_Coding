using NamespaceAliasAndFullyQualifiesName.People;
//using SpecialNamespace; // When i didn't import Namespace SpecialNamespace that include class Product
using SpecialNamespace; // When i did import Namespace SpecialNamespace that include class Product
using System.Collections.Generic;


namespace NamespaceAliasAndFullyQualifiesName
{
    // - link1 : https://www.youtube.com/watch?v=cp19RhiHHok

    // I can Decalre more than one class inside the same folder like Vehicle , Car , Programm
    public class Vehicle
    {
    }
    public class Car : Vehicle
    {
    }
    public class Program
    {
        static void Main()
        {
            /*
             - Namespace like a package or library that contains Classes ,....
             */
            Person p = new Person();
            List<int> myList = new List<int> { 10, 20, 30 };
            p.DisplayElements(myList);

            Employee emp = new Employee { Id = 1, Name = "Hassna" };
            emp.EmployeeInfo();

            //SpecialNamespace.Product pr = new SpecialNamespace.Product { Id = 1, Name = "Phone", Quantity = 10 };
            Product pr = new Product { Id = 1, Name = "Phone", Quantity = 10 };
            pr.ProductInfo();
        }
    }
}
