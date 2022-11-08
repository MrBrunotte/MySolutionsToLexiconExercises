using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_5_Garage_1_0
{
    internal class Car : Vehicle
    {
        public string TypeOfCar { get; set; }
        public Car(string regNumber, string color, int nrOfWheels, string typeOfCar)
            : base(regNumber, color, nrOfWheels)
        {
            TypeOfCar = typeOfCar;
        }
        public override string ToString()
        {
            return $"\t--- Car stats ---\n" +
                   $"Registration number:\t{RegNumber}\n" +
                   $"Color:\t\t\t{Color}\n" +
                   $"Number of wheels:\t{NrOfWheels}\n" +
                   $"Wingspan:\t\t{TypeOfCar}\n";
        }
        public void SetTextColor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
