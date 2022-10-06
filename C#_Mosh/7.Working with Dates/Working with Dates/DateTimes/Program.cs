using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimes
{
    class Program
    {
        public void DateTimes()
        {
            DateTime dateTimeOne = new DateTime(2015, 1, 1);
            Console.WriteLine(dateTimeOne);
            DateTime dateTimeTwo = new DateTime(2018, 12, 25, 10, 30, 50);
            Console.WriteLine(dateTimeTwo);
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            DateTime toDay = DateTime.Today;
            Console.WriteLine(toDay);
            Console.WriteLine("Year : {0}", now.Year);
            Console.WriteLine("Month : {0}", now.Month);
            Console.WriteLine("Day : {0}", now.Day);
            Console.WriteLine("Hour : {0}", now.Hour);
            Console.WriteLine("Minute : {0}", now.Minute);
            Console.WriteLine("Second : {0}", now.Second);

            TimeSpan duration = new TimeSpan(1, 2, 5, 10);
            Console.WriteLine(now.Add(duration));

            DateTime tomorrow = now.AddDays(1);
            Console.WriteLine(tomorrow);

            DateTime yesterday = now.AddDays(-1);
            Console.WriteLine(yesterday);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
