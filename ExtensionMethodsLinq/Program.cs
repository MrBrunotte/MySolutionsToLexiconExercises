using ExtensionMethodsLinq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

Console.WriteLine("--- Extension Methods & LINQ ---\n");

Console.WriteLine("What is an Extension method?");

Console.WriteLine("\n It is a way for us to add functionality to current classes without inheriting the code.\n" +
                  "All extension methods are static." +
                  "Vi kanske vill modifiera string str genom att lägga till en Add() metod." +
                  "Vi skapar en ny klass Extensions" +
                  "Denna måste vara static\n" +
                  "På alla instentions kommer metoderna finna.");

string str = "Hej";

var res = str.Add("Banan");
Console.WriteLine(res);

var emp = new Employee("Kalle", 10000);
Console.WriteLine("\nPrint employee name ToUpper");
var nameToUpper = emp.NameToUpper();

Console.WriteLine(nameToUpper);


var employees = new List<Employee>
{
    new Employee("Millan", 5000),
    new Employee("Maria", 7000),
    new Employee("Fia", 3000),
    new Employee("Manga", 5000),
    new Employee("Johan", 8000),
};

// skapa tre listor av typen int från 1 - 10
int[ ] num = Enumerable.Range(1, 10).ToArray();
List<int> num2 = Enumerable.Range(1, 10).ToList();
IEnumerable<int> num3 = Enumerable.Range(1, 10).ToArray();

var ints = new[ ] { 1, 23, 56, 45, 12, 25, 44, 99 };
int[] ints2 = new[ ] { 1, 23, 56, 45, 12, 25, 44, 99 };

num.PrintAll<int>();
num2.PrintAll();
num3.PrintAll();
ints.PrintAll();

employees.PrintAll<Employee>();


/*################## LINQ ####################*/

/*
 * method-syntax används här finns även Query-syntax (som SQL)
 *
 * Transformering av resultatet - Select()
 *
 * Returns an IEnumerable<Person>
 *      var adults = people
 *          .Where(p => p.Age > 30);
 *
 * Returns an Ienumerable<int>
 *      var ages = people
 *          .where(p => p.Age >30)
 *          .Select(p => p.ID);
 *
 * Returns an IEnumerable<string>
 *      var names = people
 *          .Where(p => p.Age > 30)
 *          .Select(p => p.Names);
 */

Console.WriteLine("\nUse LINQ to find employees with a salary above 5500");
var highSalary = employees.Where(e => e.Salary > 5500);
highSalary.PrintAll();

Console.WriteLine("\nUse LINQ to sort (OrderBy) employees by name");
var sortEmp = employees.OrderBy(e => e.Name);
sortEmp.PrintAll();

// Console.WriteLine("\nUse LINQ to sort all emp starting with s");
var nameStartWithS = employees
    .Where(e => e.Name.StartsWith("M"))
    .Select(e => e.Salary)
    .Sum();

var namesLength = employees
    .Where(e => e.Salary > 5001)
    .Select(e => new EmpDto
    {
        Name = e.Name.ToUpper(),
        NamesLength = e.Name.Length
    })
    .ToArray();


