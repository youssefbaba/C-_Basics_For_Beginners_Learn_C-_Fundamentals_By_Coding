using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpans
{
    class Program
    {
        public void TimeSpans()
        {
            // Creating 
            TimeSpan timeSpan = new TimeSpan(1,2,3); // 1 hour , 2 minutes , 3 seconds
            TimeSpan timeSpanOne = new TimeSpan(1, 0, 0); // 1 hour , 0 minute , 0 second
            TimeSpan timeSpanTwo = new TimeSpan(0, 2, 0); // 0 hour , 2 minutes , 0 second
            TimeSpan timeSpanThree = TimeSpan.FromHours(1); // 1 hour , 0 minute , 0 second
            TimeSpan TimeSpanFour = TimeSpan.FromMinutes(2);// 0 hour , 2 minutes , 0 second

            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now.AddMinutes(2);
            TimeSpan duration = end - start;
            Console.WriteLine("Duration : {0} ", duration);

            // Properties 
            Console.WriteLine("Minutes : {0} ",timeSpan.Minutes); // 2 minutes
            Console.WriteLine("Total Minutes : {0} ",timeSpan.TotalMinutes); // 60 + 2 + 0.05  = 62.05 minutes

            // Add
            Console.WriteLine("Add Example One : {0} " ,timeSpan.Add(new TimeSpan(1,1,1)));
            Console.WriteLine("Add Example Two : {0} ",timeSpan.Add(TimeSpan.FromMinutes(1)));
            Console.WriteLine("Substract Example {0} " , timeSpan.Subtract(TimeSpan.FromSeconds(2)));

            // ToString 
            Console.WriteLine("TimeSpan to ToString : {0} " ,timeSpan.ToString());

            //Parse
            Console.WriteLine("From String To TimeSpan  : {0} " ,TimeSpan.Parse("01:02:03"));





        }
    }
}
