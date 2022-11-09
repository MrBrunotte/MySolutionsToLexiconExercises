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

internal static class Direction
{
    public static Position West => new Position(0, -1);
    public static Position East => new Position(0, 1);
    public static Position North => new Position(-1, 0);
    public static Position South => new Position(1, 0);
}