using System;
namespace ifelse
{
    class ifelse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value");
            int number = Convert.ToInt32 (Console.ReadLine());
            if(number == 100)
            {
                Console.WriteLine("the number is {0}", number);
            }
            else if (number == 101)
            {
                Console.WriteLine("the number is {0}", number);
            }
            else if (number == 102)
            {
                Console.WriteLine("the number is {0}", number);
            }
            else if (number == 103)
            {
                Console.WriteLine("the number is {0}", number);
            }
            else if (number == 104)
            {
                Console.WriteLine("the number is {0}", number);
            }
            else
            {
                Console.WriteLine("enter a valid number");
            }
            Console.ReadLine();
        }
    }
}