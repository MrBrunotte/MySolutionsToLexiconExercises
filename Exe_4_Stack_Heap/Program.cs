

/*
    De fyra typerna i C#, Value Types, Reference Types, Pointers och Instructions.

    En reference type lagras alltid på heapen. Medan Value types, lagras där de deklareras.
    Alltså kan value types lagras både på stacken eller heapen

    Hur fungerar stacken?
        Se stacken som en pelare med boxar, för att komma åt den undre så måste boxarna ovan tas bort, en box tas automatiskt bort när dess livslängd är slut.
    Hur fungerar heapen?
        Se heapen som en mängd smutstvätt som ligger utspridd på golvet, allt nås samtidigt och tas endast bort av Garbage collectorn.
    Vad är value types?
        De ärver från System.ValueTypes
        • byte
        • char
        • decimal
        • double
        • enum
        • float
        • int
        • long
        • sbyte
        • short
        • struct
        • uint
        • ulong
        • ushort
    Vad är reference types?
        De ärver från System.Object
        • class
        • interface
        • object
        • delegate
        • string

 */

/* TEORI FRÅGOR
 * 1) How does the Stack and Heap work?
 * Stack: Last -in first -out collection of objects. elements are added to the stack, one
 * on top of each other. The process of adding an element to the stack is called a push
 * operation. The top element is always removed from the stack and this is known as "pop"
 * the stack.
 * Stack is more or less used for keeping track of whats executing in the code. Stack is faster than Heap
 * Heap: The purpose of the Heap is to hold information (not keep track of execution) so anything
 * i the heap can be accessed at any time.
 * Heap is more or less responsible for keeping track of the objects.
 * 2) What is Value Types and Reference Types, What are the differences?
 * Value types are types from System.ValueType. All "things" declared with the following list of types
 * are ValueTypes: Bool, byte, char, decimal, double, enum, float, int, long, sbyte, short, struct
 * uint, ulong, ushort.

 * Reference types are types from System.Object. All "things" declared with the types in the list are
 * reference types: Class, interface, delegate, object, string.
 * 3) Osäker på detta svar men jag tror att det är enligt nedan:
 * the first method is stored in the heap and the second is stored in the stack. The first is returning
 * 3 since there are no constraints as to what can be accessed and the second is returning 4 since it is on
 * the stack and when one "box" is executed it is discarded and the next "box" is used for memory and 4 is
 * in this "box" now (this box is now on top).
 */
using Exe_4_Stack_Heap;

MyInt.ReturnValue();
MyInt.ReturnValue2();

Console.WriteLine("---- Övning 1 ----\n");
while(true)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
        + "\n1. Examine a List"
        + "\n2. Examine a Queue"
        + "\n3. Examine a Stack"
        + "\n4. CheckParanthesis"
        + "\n\n0. Exit the application \n");
    Console.ResetColor();
    char input = ' '; //Creates the character input to be used with the switch-case below.
    try
    {
        input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
    }
    catch(IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
    {
        Console.Clear();
        Console.WriteLine("Please enter some input!");
    }
    switch(input)
    {
        case '1':
            ListClass.ExamineList();
            break;
        case '2':
            QueueClass.ExamineQueue();
            break;
        case '3':
            StackClass.ExamineStack();
            break;
        case '4':
            ParanthesisClass.CheckParanthesis();
            break;
        /*
         * Extend the menu to include the recursive
         * and iterative exercises.
         */
        case '0':
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
            break;
    }
}

