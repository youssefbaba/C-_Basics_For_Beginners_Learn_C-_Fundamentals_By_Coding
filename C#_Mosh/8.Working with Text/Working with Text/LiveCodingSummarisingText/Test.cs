using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingSummarisingText
{
    class Test
    {
       public static void Main()
        {
            string text = "Lorem ipsum dolor site amet consectetur adipisicing elit Maxime mollitia molestiae quas vel";
            Program program = new Program();
            Console.WriteLine(program.SummarisingText(text , 20));
        }
    }
}
