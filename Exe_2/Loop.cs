class Loop
{
    /// <summary>
    /// Duplicates the sentance and prints it 10  times on one line.
    /// </summary>
    internal static void TextItteration()
    {
        Console.WriteLine("Let me duplicate your text ten times");
        Console.Write("Enter a text of your choice: ");
        string inputText = Console.ReadLine();

        for (int i = 0; i < 11; i++)
        {
            Console.Write(inputText);
        }
        Console.WriteLine();
    }
}