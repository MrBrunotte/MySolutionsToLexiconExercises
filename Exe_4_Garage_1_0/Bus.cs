using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_5_Garage_1_0
{
    internal class Bus : Vehicle
    {
        public int Length { get; set; }
        public Bus(string regNumber, string color, int nrOfWheels, int length)
            : base(regNumber, color, nrOfWheels)
        {
            Length = length;
        }
        public override string ToString()
        {
            return $"\t--- Bus stats ---\n" +
                   $"Registration number:\t{RegNumber}\n" +
                   $"Color:\t\t\t{Color}\n" +
                   $"Number of wheels:\t{NrOfWheels}\n" +
                   $"Wingspan:\t\t{Length}\n";
        }
        public void SetTextColor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
