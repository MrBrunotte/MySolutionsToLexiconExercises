using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_5_Garage_1_0
{
    internal class Vehicle
    {
        public string RegNumber { get; }
        public string Color1 { get; }
        public int NrOfWheels { get; }

        public Vehicle(string regNumber, string color, int nrOfWheels)
        {
            RegNumber = regNumber;
            Color1 = color;
            NrOfWheels = nrOfWheels;
        }
    }
}
