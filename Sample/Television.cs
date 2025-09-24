using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Television : IElectronicDevices 
    {
        public int Volume { get; set; }

        public void off()
        {
            Console.WriteLine("the tv is off");
        }

        public void on()
        {
            Console.WriteLine("the tv is on");
        }

        public void Volumedown()
        {
            if (Volume != 0) Volume--;  
           
            Console.WriteLine($"the tv volume is at {Volume }");
        }

        public void Volumeup()
        {
            if (Volume != 100) Volume++;
            Console.WriteLine($"the tv volume is at {Volume}");
        }
    }
}
