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

internal class Game
{
    private Map map;              // Create a Global map
    private Hero hero;       // Create a Global hero

    internal void Run()
    {
        Initialize();
        Play();
    }

    // Play()
    //  Draw map to play on
    //  Get command from user, move, pick up item etc
    //  Execute the comman from user
    //  Draw new map after execution
    //  Enemy Action
    //  Draw new map etc...
    private void Play()
    {
        bool gameInProgress = true;
        do
        {
            // Draw map
            DrawMap();



            Console.ReadKey();
        } while(gameInProgress);
    }

    private void DrawMap()
    {
        for(int y = 0; y < map.Height; y++)
        {
            for(int x = 0; x < map.Width; x++)
            {
                Cell cell = map.GetCell(x, y);
                Console.Write(cell.Symbol);
            }
            Console.WriteLine();
        }
    }

    // Creates the object we need for the game
    private void Initialize()
    {
        // type Tasklist in search field
        // TODO: read from config
        map = new Map(width: 10, height: 10);
        var heroCell = map.GetCell(0,0);
        hero = new Hero(heroCell);
    }



}