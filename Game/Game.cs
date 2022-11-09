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
            // Get command from user
            GetInput();
            // Draw map again with new position
            DrawMap();

        } while(gameInProgress);
    }

    private void GetInput()
    {
        var keyPressed = UI.GetKey();       // anroppar UI och kollar vilken key som är tryckt
        switch(keyPressed)
        {
            case ConsoleKey.LeftArrow:
                Move(Direction.West);
                break;
            case ConsoleKey.RightArrow:
                Move(Direction.East);
                break;
            case ConsoleKey.UpArrow:
                Move(Direction.North);
                break;
            case ConsoleKey.DownArrow:
                Move(Direction.South);
                break;

            default:
                break;
        }
    }

    private void Move(Position movement)
    {
        Position newPosition = hero.Cell.Position + movement;
        Cell newCell = map.GetCell(newPosition);
        if(newPosition != null)
        {
            hero.Cell = newCell;
        }
    }

    private void DrawMap()
    {
        UI.Clear();
        UI.Draw(map);
    }

    // Creates the object we need for the game
    private void Initialize()
    {
        // type Tasklist in search field
        // TODO: read from config
        map = new Map(width: 10, height: 10);       // skapa upp en ny karta med Widht och Height
        var heroCell = map.GetCell(0,0);            // skapa en cell där hero ska starta ifrån med kordinaterna 0,0
        hero = new Hero(heroCell);                  // skapa ett nytt Hero object hero ohc skickar in vilken cell han befinner sig på (heroCell = 0,0)
        map.Creatures.Add(hero);                    // Lägg till hero till listan Creatures i Map.cs
    }
}