using System;
namespace Readandwrite
{
    class Readandwrite
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter ur name");
            string name = Console.ReadLine();
            Console.WriteLine("enter ur age");
            int age = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("your name is" + name);
            Console.WriteLine("your age  is {0}", age);

        }
    }
}
