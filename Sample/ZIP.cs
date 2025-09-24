using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZIP
{
    class ZIP
    {

        static void Main(string[] args)
        {
            var Listone = new List<int>(new int[] { 1, 2, 3 });
            var Listtwo = new List<int>(new int[]{4, 5, 6});
            var sumList = Listone.Zip(Listtwo,(x,y) => x+y).ToList() ;
            foreach (var list in sumList) {Console.WriteLine(list);}
        }
    }
}
