using System;
namespace Sample
{
    class sample1
    {
        static void Main(string[] args)
        {
            string f = "900abc";
            int result = 0;
            bool issuccess = int.TryParse(f, out result);
            if (issuccess)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("pleaase enter a valid number");
            }

            Console.ReadLine();
        }

    }
}