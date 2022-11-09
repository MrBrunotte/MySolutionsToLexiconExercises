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
    public int Y { get; }
    public int X { get; }
    //List to hold items in a cell, each cell can have items and each own list of items
    public List<Item> Items { get; } = new List<Item>(); // without set; I will not be able to overrride items in a cell.
    public string Symbol => "- ";

    public ConsoleColor Color { get; set; }

    public Cell(int x, int y) // vi sätter kordinaterna så att vi vet vart cellen är
    {
        X = x;
        Y = y;
        Color = ConsoleColor.Red;
    }
}