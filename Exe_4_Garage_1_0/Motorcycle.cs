using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_5_Garage_1_0
{
    internal class Motorcycle : Vehicle
    {
        public int TopSpeed { get; set; }
        public Motorcycle(string regNumber, string color, int nrOfWheels, int topSpeed)
            : base(regNumber, color, nrOfWheels)
        {
            TopSpeed = topSpeed;
        }
        public override string ToString()
        {
            return $"\t--- Motorcycle stats ---\n" +
                   $"Registration number:\t{RegNumber}\n" +
                   $"Color:\t\t\t{Color}\n" +
                   $"Number of wheels:\t{NrOfWheels}\n" +
                   $"Wingspan:\t\t{TopSpeed}\n";
        }
        public void SetTextColor()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
    }
}
