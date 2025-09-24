using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq

{
    class LINQ
    {
        static int[] queryintarray()
        {
            int[] array = {1,2,3,4,5,6,7,8,9};
            var gt20 = from num in array
                       where num >2
                       orderby num
                       select num;
            foreach( var num in gt20 ) {Console.WriteLine(num); }
            Console.WriteLine($"Get Type : {gt20.GetType()}");
            var ListGT20 = gt20.ToList<int>();

            var arrayGt20 = gt20.ToArray();

            arrayGt20 [0] = 40;
            foreach( var num in gt20 ) {Console.WriteLine(num); }
            return arrayGt20;

        }
      static void Main(string[] args)
        {
            int[] intArray = queryintarray();
            foreach(int num in intArray ) {Console.WriteLine(num);}
        }
    }
}
