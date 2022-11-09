
internal class Map
{
    public int Width { get; }
    public int Height { get; }
    private readonly Cell[ , ] cells;   // Create a two-dimensional array for the map, private no access outsice Map clas
    public List<Creature> Creatures { get; set; } = new List<Creature>(); // instantiera listan direkt
    public Map(int width, int height)
    {
        Width = width;
        Height = height;

        cells = new Cell[height, width]; // Create the cells object with keyword new

        for(int y = 0; y < height; y++)
        {
            for(int x = 0; x < width; x++)
            {
                cells[y, x] = new Cell(new Position(y, x));   // Create the cells object with y for height and x for width
            }
        }
    }
    /// <summary>
    /// The method returns the cells y and x
    /// </summary>
    /// <param name="y"></param>
    /// <param name="x"></param>
    /// <returns></returns>
    internal Cell GetCell(int y, int x)
    {
        if(x < 0 || x >= Width || y < 0 || y >= Height) return null;
        return cells[y, x];
    }

    internal Cell GetCell(Position newPosition)
    {
        return GetCell(newPosition.Y, newPosition.X);
    }
}