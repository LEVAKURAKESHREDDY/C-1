using System;
using System.Globalization;
using System.Text;

namespace sbuilder
{
    class StringBuilderDemo   // Class must be PascalCase
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("RAndokm tecxbajdbv");
            StringBuilder sb2 = new StringBuilder("more stuff that is very imppoortant");

            Console.WriteLine("capacity {0}", sb2.Capacity);
            Console.WriteLine("length {0}", sb2.Length);
            sb2.AppendLine("\n more important text");
            CultureInfo enus = CultureInfo.CreateSpecificCulture("en-US");
            string bestcus = "nani";
            sb2.AppendFormat(enus, "best customer : {0}", bestcus);
            Console.WriteLine(sb2.ToString());

            sb2.Replace("text", "character");
            Console.WriteLine(sb2.ToString());

            sb2.Clear();
            sb2.AppendLine("RAndokm tecxbajdbv");

            // Compare contents instead of object references
            Console.WriteLine(sb.Equals(sb2));

            sb2.Insert(11, "thats the text");
            Console.WriteLine(sb2.ToString());

            sb2.Remove(11, 7);
            Console.WriteLine(sb2.ToString());

          //  Console.ReadLine();
        }
    }  // ✅ closes class
}      // ✅ closes namespace
