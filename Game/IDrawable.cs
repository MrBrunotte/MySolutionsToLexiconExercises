public interface IDrawable
{
    // minsta gemensama nämnaren som Creature och Hero har och de ska skrivas ut så vi använder oss av ett interface.
    // detta interface säger att alla som använder detta interface måste ha:
    // - en färg med get och sett
    // - en symbol med get
    ConsoleColor Color { get; set; }
    string Symbol { get; }
}