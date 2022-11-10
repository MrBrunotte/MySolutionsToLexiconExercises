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

internal class Hero : Creature
{
    public LimitedList<Item> BackPack { get; set; }
    public Hero(Cell cell) : base(cell, "H ")
    {
        Color = ConsoleColor.Yellow;                // override the default color from Creature
        BackPack = new LimitedList<Item>(3);        // instantiate a new BackPack in constructor with capacity 3 from LimitedList.cs
    }
}