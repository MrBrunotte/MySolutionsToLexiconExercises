
using Exe_3;

Console.WriteLine("3.1 Inkapsling\n".ToUpper());
Console.WriteLine("1. Skapa klassen Person, ålder kan inte vara lägre än 0, för/efternamn är obligatoriska.\n");
try
{
	Person person = new Person("Stefan", "Brunotte");
	person.Age = 50;
	person.Weight = 97;
	person.Height = 182;
	Console.WriteLine($"Print with overriden ToString() method: \n{person.ToString()}\n");
	Console.WriteLine($"Print with all properties and string interploation:\n" +
					  $"{person.FirstName} {person.LastName}\n" +
                      $"Age: {person.Age}\n" +
                      $"Weight: {person.Weight}\n" +
                      $"Height: {person.Height}");


}
catch (Exception e)
{

	throw new ArgumentNullException("FirstName or LastName cannot be null", e);
}


Console.WriteLine("\n----- Part 2-5 Incapsulation and methods -----\n");
try
{
	PersonHandler personHandler = new PersonHandler();
	Person viggo = personHandler.CreatePerson("Viggo", "Brunotte", 3, 19, 110);
	Console.WriteLine($"Object Viggo was created: {viggo}\n");
	Console.WriteLine($"Viggo initial age: {viggo.Age}");
	personHandler.SetAge(viggo, 4);
	Console.WriteLine($"New age changed to: {viggo.Age}");
	personHandler.SetWeightAndHeight(viggo, 25, 150);
	Console.WriteLine($"Weight changed to: {viggo.Weight}\nHeight changed to: {viggo.Height}");
}
catch (ArgumentException exp)
{
	throw new ArgumentException("Something went wrong", exp);
}