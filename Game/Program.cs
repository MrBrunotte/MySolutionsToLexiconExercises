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

Game game = new Game();                     // Create new game
game.Run();                             // Start the game

Console.WriteLine("Thanks for playing");
Console.ReadKey();
