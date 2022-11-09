
/// <summary>
/// Efter return => List of creatures, hämta first or default för varje creature (hero eller monster) titta om
/// c.Cell är lika med cell då returnerar vi den som en IDrawable
/// </summary>
/// <param name="creatures"></param>
/// <param name="cell"></param>
/// <returns></returns>
public static class Extensions
{
    public static IDrawable CreatureAtExtension(this IEnumerable<Creature> creatures, Cell cell)
    {
        return creatures.FirstOrDefault(c => c.Cell == cell);
    }
}


