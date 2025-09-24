using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rangee

{
    class range
    {
        static void Main(string[] args)
        {
            var oneto100 = new List<int>();
            oneto100.AddRange(Enumerable.Range (1, 10));
            var squares = oneto100 .Select (x => x * x).ToList ();
            foreach (var square in squares) { Console.WriteLine(square); }
        }
    }
}
