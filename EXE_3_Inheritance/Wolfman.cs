using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_3_Inheritance
{
    class Wolfman : Wolf, IPerson
    {
        public Wolfman(string type, double weight, string color, int numberOfFangs) : base(type, weight, color, numberOfFangs)
        {
            NumberOfFangs = numberOfFangs;  // I dont need to instantiate the properties (string type, double weight, string color) from the base class again!
        }

        public void Talk()
        {
            Console.WriteLine("Beware...! I am the wolfman");
        }
    }
}
