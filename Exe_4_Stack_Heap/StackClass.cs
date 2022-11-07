internal class StackClass
{
    /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
    internal static void ExamineStack()
    {
        var stackToReverse = new Stack<char>();
        Console.WriteLine("nPlease enter a text of your choice, I will reverse it!");
        string inputText = Console.ReadLine();
        foreach(var character in inputText)
        {
            stackToReverse.Push(character);
        }
        inputText = string.Empty;
        while(stackToReverse.Count > 0)
        {
            inputText += stackToReverse.Pop();
        }
        Console.WriteLine($"{inputText} <== it is reversed\n");
    }
}