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

internal static class UI
{
    internal static void Clear()
    {
        Console.Clear();
        Console.CursorVisible = false;
        Console.SetCursorPosition(0, 0);
    }

    internal static ConsoleKey GetKey()
    {
        return Console.ReadKey(intercept: true).Key;  // intercept: true betyder att vi ska bara returnera vilken key som tryckts, vi behöver inte skriva ut den.
    }
}