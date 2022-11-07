internal class ParanthesisClass
{
    /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

    // Behöver hjälp med denna

    internal static void CheckParanthesis()
    {
        Console.Write("Type a scentence that has the characters []{}() ");
        string sentence = Console.ReadLine();
        // Create and check if inputString is balanced with a method.
        bool result = BalancedString(sentence);
        if (result == true)
        {
            Console.WriteLine("The sentence IS balanced");
        }
        else
        {
            Console.WriteLine("The sentence is NOT balanced");
        }
    }

    private static bool BalancedString(string sentence)
    {
        var stack = new Stack<char>();
        //string sentence = "[]}";

        foreach(var i in sentence)
        {
            if(i == '(' || i == '{' || i == '[')
            {
                if(i == '(')
                {
                    stack.Push(')');
                }
                else if(i == '{')
                {
                    stack.Push('}');
                }
                else if(i == '[')
                {
                    stack.Push(']');
                }
            }
            else if(i == ')' || i == '}' || i == ']')
            {
                if(stack.Count == 0 || stack.Pop() != i)
                {
                    return false;
                }
            }
        }

        //If more opened parentheses than closed
        if(stack.Count > 0) //Glömde att denna villkor också behövs för att kontrollera ifall det fanns fler öppningsparenteser än stängda :-)
        {
            return false;
        }

        return true;
    }

    /**ÖVNING 4 - SVAR
   * 1) Vi använder oss av Stack eftersom vi vill åt FILO principen för att checka vilken typ
   *    av parantes som skall matchas.
   */
}