using System.Collections;
using System.Diagnostics;

internal class QueueClass
{
    /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
    internal static void ExamineQueue()
    {
        Queue ica = new Queue();
        Console.WriteLine("\nICA is now open, FIFO applies here!!\n");
        do
        {
            Console.Write("\n1) Add person to queue\n" +
                          "2) Remove expidited person from queue\n" +
                          "0) Exit program ");
            switch(Console.ReadLine())
            {
                case "1":
                    EnqueuePerson(ica);
                    break;
                case "2":
                    DequeuePerson(ica);
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nOnly enter 1,2, or 0\n");
                    break;
            }

        } while(true);
    }

    private static void EnqueuePerson(System.Collections.Queue ica)
    {
        Console.Write("\nEnter name of queuer: ");
        ica.Enqueue(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Clear();
        PrintQueue(ica);
        Console.ResetColor();
    }

    private static void DequeuePerson(Queue ica)
    {
        if(ica.Count < 1)
        {
            Console.WriteLine("\nThe Queue is empty, please add queuer!");
        }
        else
        {
            PrintQueue(ica);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nThe customer leaving the queue is: {0}", ica.Dequeue());
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            PrintQueue(ica);
            Console.ResetColor();
        }
    }

    private static void PrintQueue(Queue ica)
    {
        Console.WriteLine("\nICA-Queue:");
        foreach(var q in ica)
        {
            Console.WriteLine($"\t- {q}");
        }
    }

    /**ÖVNING 3 - SVAR
            * 1) Vi vill ju inte att den färdiga kunden ska vara kvar i kön, när vi använder Stack
            *    så försvinner ju den senaste kunden som i detta exempel inte fått hjälp än!
            */
}