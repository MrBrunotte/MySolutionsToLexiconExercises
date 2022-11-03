class YouthSenior
{
    // static fields that belong to all members of the YouthSenior class
    static int age = 0;
    static int youthPrice = 0, seniorPrice = 0, standardPrice = 0;
    internal static void BuyTicket()
    {
        Console.Write("--- Welcome to the CINEMA ---\n\n" +
                      "How many tickets do you want to buy?\n\n");

        Console.WriteLine("1) One ticket?\n" +
                          "2) Two or more tickets?\n" +
                          "0) Exit? ");
        switch (Console.ReadLine())
        {
            case "1":
                OneTicket();
                break;
            case "2":
                MultipleTickets();
                break;
            default:
                Environment.Exit(1);
                break;
        }
    }

    private static void MultipleTickets()
    {
        int NumberOfTicketsToBuy = 0, ticketsInLoop = 0, ticketsBought = 0;

        Console.Write("How many tickets do you want? ");
        NumberOfTicketsToBuy = int.Parse(Console.ReadLine());

        do
        {
            Console.Write("Enter age of person: ");
            age = int.Parse(Console.ReadLine());

            if (age < 21)
            {
                Console.WriteLine($"Age: {age} years old = 80kr");
                youthPrice += 80;
            }
            else if (age > 64)
            {
                Console.WriteLine($"Age: {age} years old = 90kr");
                seniorPrice += 90;
            }
            else
            {
                Console.WriteLine($"Age: {age} years old = 120kr");
                standardPrice += 120;
            }
            ticketsInLoop++;                                        // Add tickets to this variable
        } while (NumberOfTicketsToBuy > ticketsInLoop);

        ticketsBought = youthPrice + seniorPrice +standardPrice;    // Summarize all tickets bought

        HelperClass.TextColorConverter();
        Console.Write($"\nYour total price will be: {ticketsBought}kr");
        Console.ResetColor();
        // Print the different tickets
        Console.WriteLine("\nYour tickets:");
        if (youthPrice > 0)
        {
            Console.WriteLine($"Total price for youth tickets {youthPrice}kr");
        }
        if (seniorPrice > 0)
        {
            Console.WriteLine($"Total price for senior tickets {seniorPrice}kr");
        }
        if (standardPrice > 0)
        {
            Console.WriteLine($"Total price for standard tickets {standardPrice}kr");
        }
        Console.Write($"\nHave a great time!\n");
        Console.WriteLine("\n" +
            "Press any key to continue.");
        Console.ReadKey();
    }

    private static void OneTicket()
    {
        int youthPrice = 80, seniorPrice = 90, standardPrice = 120;

        Console.Write("To get the correct price, please enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age < 21)
        {
            Console.WriteLine($"Your are {age} years old, you get at youth ticket for {youthPrice}kr");
        }
        else if (age > 64)
        {
            Console.WriteLine($"Your are {age} years old, you get at senior ticket for {seniorPrice}kr");
        }
        else
        {
            Console.WriteLine($"Your are {age} years old, you get at standard ticket for {standardPrice}kr");
        }
    }
}
