using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class TVremote
    {
        public static IElectronicDevices GetDevices()
        {
            return new Television();
        }
    }
}
