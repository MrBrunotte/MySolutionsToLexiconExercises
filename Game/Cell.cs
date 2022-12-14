/*
 Saker att ha med i programmet
    - Cell som håller information
    - Cell kan ha olika saker i sig i en lista

 Symbol property is the same as:
        public string Symbol
            {
                get
                {
                    return ". ";
                }
            }
 */

public class Cell : IDrawable
{
    public Position Position { get; set; }
    //List to hold items in a cell, each cell can have items and each own list of items
    public List<Item> Items { get; } = new List<Item>(); // without set; I will not be able to overrride items in a cell.
    public string Symbol => "- ";

    public ConsoleColor Color { get; set; }

    public Cell(Position position) // vi sätter kordinaterna så att vi vet vart cellen är
    {
        Position = position;
        Color = ConsoleColor.Red;
    }
}