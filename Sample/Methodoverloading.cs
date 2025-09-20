using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Method

{
    class Methodoverloading
    {
        static double getsum2(double x = 1, double y = 1)
        {
            return x+y;
        }
        static double getsum2(string x = "1", string y = "1")
        {
            double dblx = Convert.ToDouble(x);
            double dbly = Convert.ToDouble(y);
            return dblx+dbly;
        }
        static void main(string[] args)
        {
            Console.WriteLine("5.0+4.0= {0}", getsum2(5.0, 4.5));
            Console.WriteLine("5.0+4.0= {0}", getsum2(5.0, 4.5));
        }
    }
}
