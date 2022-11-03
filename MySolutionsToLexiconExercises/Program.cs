using Exe_1_PersonalRegister;
using System.Collections.Specialized;

Payroll payroll = new Payroll();
Data.SeedData(payroll);
Console.WriteLine("--- PERSONAL-REGISTER ---\n");
do
{
    PrintMenu();

} while (true);

void PrintMenu()
{
    Console.WriteLine("1. Add employee\n" +
                      "2. Print employees info\n" +
                      "Q. Exit program\n");
    switch (Console.ReadLine())
    {
        case "1":
            AddEmployee();
            break;
        case "2":
            PrintEmployees();
            break;
        case "Q":
            Environment.Exit(0);
            break;
        case "q":
            Environment.Exit(0);
            break;
        default:
            break;
    }
}


void PrintEmployees()
{
    Employee[] employees = payroll.GetEmployees();

    foreach (Employee employee in employees)
    {
        // när man skickar in ett objekt i CW så kör man automatiskt .Tostring() metoden
        // Denna metod kan vi overrida i Employee klassen så blir det snyggare!
        Console.WriteLine(employee);
    }
}

void AddEmployee()
{
    do
    {
        Console.WriteLine("Add new employee and salary, return to main menu with Q");
        string name = Util.AskForString("Name: ");
        if (name == "Q" || name == "q")
        {
            break;
        }

        int salary = Util.AskForSalary("salary: ");

        payroll.AddEmployee(name, salary);

    } while (true);


}