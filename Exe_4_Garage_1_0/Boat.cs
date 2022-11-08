using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_5_Garage_1_0
{
    internal class Boat : Vehicle
    {
        public string BoatType { get; set; }
        public Boat(string regNumber, string color, int nrOfWheels, string boatType)
            : base(regNumber, color, nrOfWheels)
        {
            BoatType = boatType;
        }
        public override string ToString()
        {
            return $"\t--- Boat stats ---\n" +
                   $"Registration number:\t{RegNumber}\n" +
                   $"Color:\t\t\t{Color}\n" +
                   $"Number of wheels:\t{NrOfWheels}\n" +
                   $"Wingspan:\t\t{BoatType}\n";
        }
        public void SetTextColor()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
    }
}
