using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomClass
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("########## Generate Random Password ##########");

            Random random = new Random();
            const int passwordLenght = 10;
            char[] buffer = new char[passwordLenght];
            for (int i = 0; i < passwordLenght; i++)
            {
                buffer[i] = Convert.ToChar('a' + random.Next(0, 26));
            }
            string password = new string(buffer);
            Console.WriteLine("password : {0}" , password);
        }
    }
}
