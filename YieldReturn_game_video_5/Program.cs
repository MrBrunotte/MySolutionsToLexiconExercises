



internal class Program
{
    static void Main(string[ ] args)
    {
        Console.WriteLine("\nReturn with yeild");
        foreach(var num in YieldClass.GetNumbers())
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("\nReturn ordinary list");
        foreach(var num in YieldClass.GetNumOrdinary())
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("\nReturn with yield but only take 2 in the infinite loop");
        foreach(var num in YieldClass.GetNumYield().Take(2))
        {
            Console.WriteLine(num);
        }

        // så funkar IEnumerator, hämtar en kopia på ett objekt och ittererar ígenom det objektet.
        var result = YieldClass.GetNumbers();
        IEnumerator<int> enumerator = result.GetEnumerator();

        while(enumerator.MoveNext())
        {
            var item = enumerator.Current;
            Console.WriteLine(item);
        }
    }
}