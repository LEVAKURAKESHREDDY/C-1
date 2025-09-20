using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodss
{
    class Method
    {
        static void Main(string[] args)
        {
       
            nekendhukiu();
            int res = Add(5, 6);
            Console.WriteLine(res);
            
            Console.ReadLine();
        }
        public static void nekendhukiu()
        {
            Console.WriteLine("this is a empty method");
        }
        public  static int Add(int a,int b)
        {
            int result = a + b;
            return result;
        }
    }
}
