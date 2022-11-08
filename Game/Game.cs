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

using System.Data;

internal class Game
{
    private Map map;                // Create a Global map
    private Hero hero;       // Create a Global hero

    internal static void Run()
    {
        Initialize();
        Play();
    }

    private static void Play()
    {
        throw new NotImplementedException();
    }

    // Creates the object we need for the game
    private static void Initialize()
    {
        // type Tasklist in search field
        // TODO: read from config
        var map = new Map(width: 10, height: 10);
        var hero = new Hero();
    }



}