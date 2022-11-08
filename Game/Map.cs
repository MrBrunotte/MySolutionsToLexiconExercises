
internal class Map
{
    private int width;
    private int height;
    private readonly Cell[ , ] cells;   // Instantiate the cells object in the map (the Array), they dont have any references

    public Map(int width, int height)
    {
        this.width = width;
        this.height = height;

        cells = new Cell[height, width]; // Create the cells object with keyword new

        for(int y = 0; y < height; y++)
        {
            for(int x = 0; x < width; x++)
            {
                cells[y, x] = new Cell();   // Create the cells object with y for height and x for width
            }
        }


    }

}