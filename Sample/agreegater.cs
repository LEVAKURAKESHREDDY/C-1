using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agri
{
    class agreegater
    {
        static void Main(string[] args)
        {
            var numList = new List<int>{1,2,3,4,2,4,5,6,6,7,8 };
            var numList1 = new List<int> { 4 };
            Console.WriteLine("sum {0}",
                numList .Aggregate((a,b)=> a + b));
            Console.WriteLine("avg {0}",
                numList.Average());
            Console.WriteLine("all {0}",
                numList.All(a=> a>0));
            Console.WriteLine("any {0}",
                numList.Any(a => a > 3));
            Console.WriteLine("distint {0}",
               string.Join (", ",numList .Distinct ()));
            Console.WriteLine("except{0}",
               string.Join(", ", numList.Except (numList1 )));
        }
    }
}
