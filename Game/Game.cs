﻿/*
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
                Move(hero.Cell.Y, hero.Cell.X - 1);
                break;
            case ConsoleKey.RightArrow:
                Move(hero.Cell.Y, hero.Cell.X + 1);
                break;
            case ConsoleKey.UpArrow:
                Move(hero.Cell.Y - 1, hero.Cell.X);
                break;
            case ConsoleKey.DownArrow:
                Move(hero.Cell.Y + 1, hero.Cell.X);
                break;

            default:
                break;
        }

    }

    private void Move(int y, int x)
    {
        var newPosition = map.GetCell(y, x);
        if(newPosition != null)
        {
            hero.Cell = newPosition;
        }
    }

    private void DrawMap()
    {
        UI.Clear();

        for(int y = 0; y < map.Height; y++)
        {
            for(int x = 0; x < map.Width; x++)
            {
                Cell cell = map.GetCell(y, x);          // frågar kartan efter en cell och lägger den i cell

                IDrawable drawable = cell;              // Cell ärver från IDrawable, så vi sätter cell som IDrawable

                foreach(var creature in map.Creatures)  // loopar igenom och kollar om en cell innehåller en creature
                {                                       // skriv ut den om cellen är en creature (Hero ärver från Creature)
                    if(creature.Cell == cell)           // Om creature.Cell är samma som cell (om der reffererar till samma object)
                    {
                        drawable = creature;            // Då skriver vi över cellen med en creature (Hero eller monster)
                        break;
                    }
                }
                Console.ForegroundColor = drawable?.Color ?? ConsoleColor.White; // if drawable is null set color from IDrawable otherwise set color white.
                Console.Write(drawable?.Symbol);
            }
            Console.WriteLine();
        }
        Console.ResetColor();
    }

    // Creates the object we need for the game
    private void Initialize()
    {
        // type Tasklist in search field
        // TODO: read from config
        map = new Map(width: 10, height: 10);
        var heroCell = map.GetCell(0,0);
        hero = new Hero(heroCell);
        map.Creatures.Add(hero);
    }



}