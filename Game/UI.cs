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

    internal static void Draw(Map map)
    {
        for(int y = 0; y < map.Height; y++)
        {
            for(int x = 0; x < map.Width; x++)
            {
                Cell cell = map.GetCell(y, x);          // frågar kartan efter en cell och lägger den i cell

                IDrawable drawable = map.Creatures.CreatureAtExtension(cell) ?? cell;  // Cant get this to work with the Extension class
                //IDrawable drawable = cell;              // Cast cell to an IDrawabel. Cell ärver från IDrawable, så vi sätter cell som IDrawable

                //foreach(var creature in map.Creatures)  // loopar igenom och kollar om en cell innehåller en creature
                //{                                       // skriv ut den om cellen är en creature (Hero ärver från Creature)
                //    if(creature.Cell == cell)           // Om creature.Cell är samma som cell (om der reffererar till samma object)
                //    {
                //        drawable = creature;            // Då skriver vi över cellen med en creature (Hero eller monster)
                //        break;
                //    }
                //}
                Console.ForegroundColor = drawable?.Color ?? ConsoleColor.White; // if drawable is null set color from IDrawable otherwise set color white.
                Console.Write(drawable?.Symbol);
            }
            Console.WriteLine();
        }
        Console.ResetColor();
    }

    internal static ConsoleKey GetKey()
    {
        return Console.ReadKey(intercept: true).Key;  // intercept: true betyder att vi ska bara returnera vilken key som tryckts, vi behöver inte skriva ut den.
    }
}