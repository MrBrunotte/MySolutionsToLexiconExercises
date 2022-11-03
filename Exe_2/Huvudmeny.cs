internal class Huvudmeny
{
    // Huvudmenyn som användaren använder för att göra sina val
    internal static void MainMenu()
    {
        // Boolean variabeln isActive ser till så att do-while loopen loopar tills användaren vill avlsuta med 0
        bool isActive = false;
        do
        {
            Console.WriteLine("\n--- Övning 2: Flöde via loopar och strängmanipulation ---\n");
            HelperClass.TextColorConverter();
            Console.WriteLine("Välkommen till Huvudmenyn!");
            Console.ResetColor();

            Console.WriteLine("1) Biobiljetter \n" +
                              "2) Upprepa 10 ggr \n" +
                              "3) Det tredje ordet \n" +
                              "0) för att avsluta ");

                switch (Console.ReadLine())
                {
                    case "1":
                        HelperClass.TextColorConverter();               // Omvandlar textenfärgen i konsolen till mörkgul
                        Console.WriteLine("\nBiobiljetter".ToUpper());  // Header så att användaren vet vad denne valt
                        Console.ResetColor();                           // Återställer textfärgen
                        YouthSenior.BuyTicket();                        // Metoden BuyTicket() anropas från YouthSenior klassen
                        break;
                    case "2":
                        HelperClass.TextColorConverter();
                        Console.WriteLine("\nUpprepa text 10 ggr".ToUpper());
                        Console.ResetColor();
                        Loop.TextItteration();                          // Anropar metoden TextItteration från Loop klassen
                        break;
                    case "3":
                        HelperClass.TextColorConverter();
                        Console.WriteLine("\nDet tredje ordet".ToUpper());
                        Console.ResetColor();
                        Splitter.SplitAtSpace();                    // Anropar metoden SplitAtSpace i Splitter klassen
                        break;
                    case "0":
                        Environment.ExitCode = 0;                       // Avslutar applicationen
                        isActive = true;                                // genom att sätta isActive till true
                        break;

                    default:
                        Console.ForegroundColor = System.ConsoleColor.Red;
                        Console.WriteLine("Felaktigt val! Trycker ENTER och försök igen.");
                        Console.ReadKey();
                        Console.ResetColor();
                        Console.Clear();
                        break;
                }
        } while (!isActive);
    }
}