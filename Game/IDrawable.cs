public interface IDrawable
{
    // minsta gemensama nämnaren som Creature och Hero har och de ska skrivas ut så vi använder oss av ett interface.
    ConsoleColor Color { get; set; }
    string Symbol { get; }
}