public interface IDrawable
{
    /*
     * Vi har detta interface för att vi ska kunna gruppera saker som inte har med varandra att göra men de har gemensamma nämnare som 
     * - Color
     * - Symbol
     * Alla som använder detta interface måste ha både color och symbol som property
     */
    ConsoleColor Color { get; set; }
    string Symbol { get; }
}