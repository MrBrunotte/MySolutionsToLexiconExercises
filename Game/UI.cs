/*
 Saker att ha med i programmet
    - Player class
        - Hero
    - Abstract Items base class
        - Portion (health)
    - Points
    - Backpack
    - Enemy
        - Monster
    - Map
        Cell som håller information
    - Gamestate, log som skriver ut hälsa mm
    - Ui Som skriver ut saker (för att inte skräpa ner med CW)
    - Position
    - Game class som håller själva loopen
 */

using Game_LimitedList;
using System.Runtime.CompilerServices;

internal static class UI
{
    private static MessageLog<string> messageLog = new MessageLog<string>(6);

    public static void AddMessage(string message) => messageLog.Add(message);
    public static void PrintLog()
    {
        Console.WriteLine($"\nMessage log!");
        foreach(var item in messageLog)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(item);
            Console.ResetColor();
        }
    }

    internal static void Clear()
    {
        Console.Clear();
        Console.CursorVisible = false;
        Console.SetCursorPosition(0, 0);
    }

    internal static void Draw(Map map)
    {
        for(int y = 0; y < map.Height; y++)
        {
            for(int x = 0; x < map.Width; x++)
            {
                Cell cell = map.GetCell(y, x);          // frågar kartan efter en cell och lägger den i cell

                IDrawable drawable = map.CreatureAt(cell) ?? (IDrawable)cell.Items.FirstOrDefault() ?? cell;  // We must cast cell to IDrawable

                Console.ForegroundColor = drawable?.Color ?? ConsoleColor.White; // if drawable is null set color from IDrawable otherwise set color white.
                Console.Write(drawable?.Symbol);
            }
            Console.WriteLine();
        }
        Console.ResetColor();
        PrintAbbreviations();
    }

    private static void PrintAbbreviations()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("H = Hero");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("c = Coin");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("t = Torch");
        Console.ResetColor();
    }

    internal static ConsoleKey GetKey()
    {
        return Console.ReadKey(intercept: true).Key;  // intercept: true betyder att vi ska bara returnera vilken key som tryckts, vi behöver inte skriva ut den.
    }
}