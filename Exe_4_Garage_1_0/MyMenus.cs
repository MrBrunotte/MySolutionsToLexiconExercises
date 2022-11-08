using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_5_Garage_1_0
{
    internal class MyMenus
    {
        internal static void StartMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t--- Garage 1.0 ---".ToUpper());
            Console.Write("Start Menu\n" +
                              "1) Set number of parking spaces\n" +
                              "2) Add 5 vehicles to the garage\n" +
                              "3) Add/Remove your own vehicle\n" +
                              "4) Print all parked vehicles\n" +
                              "5) Print specific vehicles\n" +
                              "6) Search vehicle\n" +
                              "7) Search by Registration number ");
            Console.ResetColor();
            string userChoice = Console.ReadLine();
        }
        public void SetTextColor()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
    }
}
