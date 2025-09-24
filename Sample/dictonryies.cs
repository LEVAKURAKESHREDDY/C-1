using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dic
{
    class dictonryies
    {
        static void Main(string[] args)
        {
            Dictionary<string,string > superhero = new Dictionary<string,string>();
            superhero.Add("clark kent", "superman");
            superhero.Add("Bruce", "Batman");
            superhero.Add("barry west", "The falsh");
            superhero.Remove("barry west");
            Console.WriteLine("count:{0}", superhero.Count);
            Console.WriteLine(" clark kent :{0}",
                superhero.ContainsKey("clark kent"));
            superhero.TryGetValue("clark kent", out string test);
            Console.WriteLine($"clark kent : {test}");
            foreach(KeyValuePair<string,string> pair in superhero)
            {
                Console.WriteLine("{0} :{1}",
                    pair.Key , pair.Value );

            } 
        }
    }
}
