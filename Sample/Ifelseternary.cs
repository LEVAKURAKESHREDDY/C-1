using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emo
{
    class Ifelseternary
    {
        static void Main(string[] args)
        {
            int age = 8;
            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("go to elemntary school");
            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("got to middle school");
            }
            else if ((age > 13) && (age < 19))
            {
                Console.WriteLine("go to high school");
            }
            else {
                Console.WriteLine("go to college");
                    
                    }
            if ((age > 60) ||(age<14) )
                    {
                Console.WriteLine("you should not work");
            }
            bool canDrive = age>= 16 ? true : false;
            Console.WriteLine(canDrive);
            string name1 = "nani";
            string name2 = "nani";
            if (name2.Equals(name1, StringComparison.Ordinal))
            {
                Console.WriteLine("name is equal");
            }
        }
    }
}
