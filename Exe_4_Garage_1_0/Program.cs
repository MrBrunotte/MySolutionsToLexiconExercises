using Exe_5_Garage_1_0;

Airplane myFirstAirplane = new Airplane("AC123", "Silver", 12, 13);
myFirstAirplane.SetTextColor();
Console.WriteLine(myFirstAirplane.ToString());
Console.ResetColor();

MyMenus.StartMenu();
