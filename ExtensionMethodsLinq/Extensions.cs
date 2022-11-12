using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsLinq
{

    /*
    What is an Extension method?");

        It is a way for us to add functionality to current classes without inheriting the code.
        All extension methods are static.
        Vi kanske vill modifiera string str genom att lägga till en Add() metod.
        Vi skapar en ny klass Extensions
        Denna måste vara static
     */
    public static class Extensions
    {
        public static string Add(this string str, string input)
        {
            return $"Org string: {str}, input: {input}";
        }

        public static string NameToUpper(this Employee employee)
        {
            return employee.Name.ToUpper();
        }

        //public static void PrintAll(this List<Employee> emplopyeeList)
        //{
        //    Console.WriteLine("\nPrint Employee list");
        //    emplopyeeList.ForEach(employee => Console.WriteLine(employee));
        //}

        // Generisk PrintAll metod
        // Extension metod på IEnumerable<T>
        public static void PrintAll<T>(this IEnumerable<T> collection)
        {
            Console.WriteLine("\nPrint Generic collection");
            foreach(T item in collection)
            {
                Console.Write($"{item}, ");
            }
        }
    }
}
