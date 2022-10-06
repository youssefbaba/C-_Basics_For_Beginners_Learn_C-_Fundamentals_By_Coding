using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStrings
{
    class Program
    {
        public void DemoString()
        {
            string fullName = "Youssef Baba ";
            Console.WriteLine("Trim : '{0}'" , fullName.Trim());
            Console.WriteLine("ToUpper : '{0}'" , fullName.Trim().ToUpper());
            Console.WriteLine("ToLower : '{0}'", fullName.Trim().ToLower());


            Console.WriteLine("######## Method One ############");
            int index = fullName.IndexOf(' ');
            string firstName = fullName.Substring(0 , index);
            string lastName = fullName.Substring(index).Trim();
            Console.WriteLine("'{0}'" ,firstName);
            Console.WriteLine("'{0}'" ,lastName);

            Console.WriteLine("######### Method Two #############");
            string[] names = fullName.Trim().Split(' ');
            Console.WriteLine("FirstName : '{0}'" , names[0]);
            Console.WriteLine("LastName : '{0}'" , names[1]);

            string newFullNameOne = fullName.Replace('o', 'O');
            Console.WriteLine(newFullNameOne);
            string newFullNameTwo = fullName.Replace("Youssef", "Joseph");
            Console.WriteLine(newFullNameTwo);

            string stringNumberOne = "123456789";
            int numberOne = Convert.ToInt32(stringNumberOne); // Best way
            int numberTwo = int.Parse(stringNumberOne);

            float price = 1500.95f;
            string stringPriceOne = price.ToString();
            Console.WriteLine(stringPriceOne); // 1500.95
            string stringPriceTwo = price.ToString("C0");
            Console.WriteLine(stringPriceTwo); // $1,501
            string stringPriceThree = price.ToString("C1");
            Console.WriteLine(stringPriceThree); // $1,501.0
            string stringPriceFour = price.ToString("C");
            Console.WriteLine(stringPriceFour); // $1,500.95







        }
    }
}
