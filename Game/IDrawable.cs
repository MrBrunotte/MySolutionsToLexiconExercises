public interface IDrawable
{
    // minsta gemensama nämnaren som Creature och Hero har
    ConsoleColor Color { get; set; }
    string Symbol { get; }
}