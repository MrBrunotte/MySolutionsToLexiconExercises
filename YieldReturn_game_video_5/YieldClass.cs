internal class YieldClass
{
    public static IEnumerable<int> GetNumOrdinary()
    {
        var i = 0;
        var result = new List<int>();
        while(i < 5)
        {
            result.Add(i++);
        }
        return result;
    }
    public static IEnumerable<int> GetNumbers()
    {
        yield return 1;
        yield return 2;
        yield return 3;
    }
    public static IEnumerable<int> GetNumYield()
    {
        var i = 0;
        var result = new List<int>();
        while(true)
        {
            yield return i++;
        }
    }
}