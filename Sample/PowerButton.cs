using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class PowerButton : ICommand
    {
        IElectronicDevices device;
        public PowerButton (IElectronicDevices device)
        {
            this.device = device;
        }
        public void Execute()
        {
            device.on();
        }

        public void undo()
        {
            device.off ();
        }
    }
}
