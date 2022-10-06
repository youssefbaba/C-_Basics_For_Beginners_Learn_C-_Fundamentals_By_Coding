using System;
namespace SpecialNamespace
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public void ProductInfo()
        {
            Console.WriteLine($"My Product : Id = {this.Id} , Name = {this.Name} , Quanity = {this.Quantity} ");
        }
    }
}
