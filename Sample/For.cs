using System;
namespace forloop
{
    class For
    {
        static void Main(String[] args)
        {
            for (int i = 1; i < 10; i++)
            { 
                if(i == 4)
                {
                    
                    continue;
                }
           
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

    }
}
