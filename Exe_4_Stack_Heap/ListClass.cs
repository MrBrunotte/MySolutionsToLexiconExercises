using System.Security.Cryptography.X509Certificates;

internal class ListClass
{
    /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */
    internal static void ExamineList()
    {
        List<string> nameStringList = new List<string>();
        do
        {
            Console.WriteLine("\n1. EXAMINE THE LIST\nExamine the list and its capacity");
            Console.WriteLine("Type 1 to add person to the list\n" +
                              "Type 2 to remove person from the list\n" +
                              "Type 0 to exit the program\n");
            switch(Console.ReadLine())
            {
                case "1":
                    AddPersonToList(nameStringList);
                    PrintList(nameStringList);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\n\tList capacity: {nameStringList.Capacity}\n\tList count: {nameStringList.Count}");
                    Console.ResetColor();
                    break;
                case "2":
                    RemovePersonFromList(nameStringList);
                    PrintList(nameStringList);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\n\tList capacity: {nameStringList.Capacity}\n\tList count: {nameStringList.Count}");
                    Console.ResetColor();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("You can only type 1, 2, or 0");
                    break;
            }
        } while(true);
    }

    private static void RemovePersonFromList(List<string> nameStringList)
    {
        Console.Write("What name do you want to remove from the list? ");
        nameStringList.Remove(Console.ReadLine());
            Console.WriteLine($"\nCapacity is now {nameStringList.Capacity} after removing a name from the list: \nNew count: {nameStringList.Count}");
    }

    private static void AddPersonToList(List<string> nameStringList)
    {
        Console.Write("What name do you want to add to the list? ");
        nameStringList.Add(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\nCapacity is {nameStringList.Capacity} after adding name to the list:\nNew count: {nameStringList.Count}");
    }

    private static void PrintList(List<string> theList)
    {
        Console.WriteLine("\n--- The list ---");
        foreach(var person in theList)
        {
            Console.WriteLine($"- {person}");
        }
        Console.WriteLine("----------------");
    }

    /**ÖVNING 1 - SVAR
            * 2) När minnet är fyllt av max element så ökar kapaciteten
            * 3) Kapaciteten dubbleras
            * 4) Eftersom elementen fyller upp kapaciteten, när kapaciteten är fylld så ökar den först. Elementen
            *    kommer hela tiden att traila tills kapaciteten är maximerad.
            * 5) Nej den minskar inte.
            * 6) När man vet exakt hur stor list man skall ha, då är det bättre med en egendefinierad array eftersom
            *    man då använder minsta möjlig minne.
            */
}