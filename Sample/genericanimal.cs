using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Sample
{
    class genericanimal
    {
        public string Name { get; set; }
        public genericanimal(string name =" no name") { Name = name; }
        public static void GetSum<T>(ref T num1 , ref T num2)
        {
            double dblx = Convert.ToDouble(num1);
            double dbly = Convert.ToDouble(num2);
            Console.WriteLine($"{dblx} + {dbly} = {dblx + dbly}");

        }
    }
}
