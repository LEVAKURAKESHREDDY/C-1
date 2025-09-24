using Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP 
{
    class OOPexample 
    {
        static void Main(string[] args)
        {
            IElectronicDevices TV = TVremote.GetDevices();

            PowerButton powbut = new PowerButton(TV);
            powbut.Execute();
            powbut.undo();
        }
    }
}
