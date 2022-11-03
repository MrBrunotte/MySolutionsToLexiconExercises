class Splitter
{
    /// <summary>
    /// The user types a sentence with atleast three words and the appliction
    /// types the third word.
    /// </summary>
    internal static void SplitAtSpace()
    {
        Console.Write("Please enter a sentance with atleast three words: ");
        string userInput = Console.ReadLine();

        string[] splitUserInputIntoarray = userInput.Split(' ');
        try
        {
            HelperClass.TextColorConverter();
            Console.WriteLine($"\nThe third word in your sentence is: {splitUserInputIntoarray[2]}\n");
            Console.ResetColor();

        }
        catch (Exception)
        {
            Console.ResetColor();
            Console.WriteLine("\nYou need to enter a sentence with atleast 3 words... Try again!");
        }
    }
}