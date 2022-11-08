using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_5_Garage_1_0
{
    internal class Airplane : Vehicle, IHandler
    {
        public int WingSpan { get; set; }
        public Airplane(string regNumber, string color, int nrOfWheels, int wingSpan)
            : base(regNumber, color, nrOfWheels)
        {
            WingSpan = wingSpan;
        }
        public override string ToString()
        {
            return $"\t--- Airplane stats ---\n" +
                   $"Registration number:\t{RegNumber}\n" +
                   $"Color:\t\t\t{Color}\n" +
                   $"Number of wheels:\t{NrOfWheels}\n" +
                   $"Wingspan:\t\t{WingSpan}\n";
        }

        public void SetTextColor()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
    }
}
