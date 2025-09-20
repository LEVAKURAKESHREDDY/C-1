using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As
{
    class Acessspecifier
    {
        private static void SayHello()
        {
            string name = "";
            Console.WriteLine("whats ur name :");
            name = Console.ReadLine();
            Console.WriteLine("hello {0}", name);
        }
        static void Main(string[] args)
        {
            SayHello();
        }

    }
}
