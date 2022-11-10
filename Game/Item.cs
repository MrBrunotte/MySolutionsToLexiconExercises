/*
 Saker att ha med i programmet
    - Abstract Items base class
        - Portion (health)
 */

public class Item : IDrawable
{
    // kolla om jag kan döpa on name till ItemName utan this.name i konstruktorn
    public string name { get; set; }
    public ConsoleColor Color { get; set; }

    public string Symbol { get; }
    public Item(string symbol, ConsoleColor color, string name)
    {
        Symbol = symbol;
        Color = color;
        this.name = name;
    }

    public override string ToString() => name;

    public static Item Coin() => new Item("c ", ConsoleColor.White, "Coin");
    public static Item Torch() => new Item("t ", ConsoleColor.Blue, "Torch");
}