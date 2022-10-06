using System;
using System.Text;

namespace StringBuilders
{
    class Program
    {
        public void StringBuilders()
        {
            Console.WriteLine("############## Example One #############");
            StringBuilder builder = new StringBuilder("Initial string for stringbuilder");
            builder.Append('-', 10)
            .AppendLine()
            .Append("Header")
            .AppendLine()
            .Append('-', 10)
            .Replace('-', '+')
            .Remove(0 , 10)
            .Insert(0 , new string('-',10));
            Console.WriteLine(builder);
            Console.WriteLine("First Character : {0}", builder[0]);


            Console.WriteLine("########## Example Two #############");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("One");
            sb.AppendLine();
            sb.AppendLine("Two");
            sb.AppendLine("Three");
            sb.Append("Four");
            Console.WriteLine(sb);

            /*
            One

            Two
            Three
            Four
             */

            /*
              -AppendLine example. AppendLine adds strings with a newline. With AppendLine, a newline sequence is automatically inserted after the argument is added to the StringBuilder buffer.
              -Arguments AppendLine is called with 0 or 1 arguments. When you call AppendLine with no arguments, it just appends the newline sequence.
              -String With a string argument, it appends that string and the newline sequence. There is no way to use a format string with AppendLine.
             
             */



        }
    }
}
