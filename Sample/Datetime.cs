using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace date
{
    class Datetime
    {
        static void Main(string[] args)
        {
            DateTime awesomeDate = new DateTime(2004, 07, 4);
            Console.WriteLine("day of the week : {0}",
                awesomeDate.DayOfWeek);
            awesomeDate = awesomeDate .AddDays(4);
            awesomeDate = awesomeDate .AddMonths(1);    
            awesomeDate = awesomeDate.AddYears(1);
            Console.WriteLine("new date:{0}", awesomeDate.Date);
            TimeSpan lunchtime = new TimeSpan(12, 40, 0);
            lunchtime = lunchtime.Subtract(new TimeSpan(0, 15, 0));
            Console.WriteLine("new Timespan :{0}", lunchtime.ToString());

        }
    }
}
