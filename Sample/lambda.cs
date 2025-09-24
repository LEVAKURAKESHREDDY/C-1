using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    class lambda
    {
        delegate double doubleIT(double val);

        static void Main(string[] args)
        {
            doubleIT dbit = x => x*2;
            Console.WriteLine($"5*2={dbit(5)}");
            List<int> numList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var evenList = numList.Where(a => a % 2 == 0).ToList ();
            foreach ( var even in evenList ) {Console.WriteLine(even);}
            var rangeList = numList.Where( x=> (x>2)||(x<9)).ToList ();
            foreach(var range in rangeList ) {Console.WriteLine(range);}

            var mod5 = numList.Where(y=> y%5 == 0).ToList ();
            foreach ( var mod in mod5 ) {Console.WriteLine(mod);}

            List<int> flipList = new List<int> ();

            int i = 0;

            Random rnd = new Random();
            while (i < 100)
            {
                flipList.Add(rnd.Next(1,3));
                i++;
            }
            Console.WriteLine("Heads :  {0}",
                flipList.Where(x => x == 1).ToList().Count());
            Console.WriteLine("Tails :{0}",
               flipList.Where(x => x == 2).ToList().Count());

            var nameList = new List<string> { "doug","sally","satwik"};
            var snameList = nameList.Where(x => x.StartsWith("s"));
            foreach ( var sname in snameList ) {Console.WriteLine(sname);}


        }
    }
}
