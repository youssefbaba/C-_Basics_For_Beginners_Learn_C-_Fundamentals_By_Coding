
using System;
namespace NamespaceAliasAndFullyQualifiesName.People
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void EmployeeInfo()
        {
            Console.WriteLine($"Info Employee : Id = {this.Id} , Name = {this.Name}");
        }

    }
}
