using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace stackkk
{
    class STACK
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);  
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine("peek1: {0}",
                stack.Peek());
            Console.WriteLine("pop1 :{0}",
                stack.Pop());
            Console.WriteLine("conatain 1: {0}",
                stack.Contains(1));
            object[] numarray2 = stack.ToArray();
            Console.WriteLine(string .Join(", ", numarray2));
            foreach (object o in numarray2)
            {
                Console.WriteLine($"stack:{ o}");
            }
        }
    }
}
