/*
 1. Skapa den abstrakta klassen UserError
2. Skapa den abstrakta metoden UEMessage() som har returtypen string.
3. Skapa en vanlig klass NumericInputError som ärver från UserError
4. Skriv en override för UEMessage() så att den returerar “You tried to use a numeric input
in a text only field. This fired an error!”
5. Skapa en vanlig klass TextInputError som ärver från UserError
6. Skriv en override för UEMessage() så att den returerar “You tried to use a text input in a
numericonly field. This fired an error!”
7. I program.cs Main-metod: Skapa en lista med UserErrors och populera den med
instanser av NumericInputError och TextInputError.
8. Skriv ut samtliga UserErrors UEMessage() genom en foreach loop.
9. Skapa nu tre egna klasser med tre egna definitioner på UEMessage()
10. Testa och se så det fungerar.
11. F: Varför är polymorfism viktigt att behärska?
12. F: Hur kan polymorfism förändra och förbättra kod via en bra struktur?
13. F: Vad är det för en skillnad på en Abstrakt klass och ett Interface?
 */


/*
         * 11) Nör man behärskar polymorfism så kommer man att skriva mindre kod.
         * Vi behöver inte hitta på nya namn på metoder som i stort gör samma sak
         * men endast skiljer sig i små detaljer.
         *
         * 12) Om man bygger in bra struktur så gör polymorfismen att man kommer
         * skriva mindre kod eftersom man kan ändra de små detaljerna som skiljer
         * men behålla den initala egenskapen en metod skall implementera.
         *
         * En abstract klass skapar funktionalitet som subklasser kan implementera
         * eller skriva över (override).
         * Ett interface definierar endast funktionaliteten och man kan inte implementera
         * den som i den abstrakta klassen.
         */
using Exe_3_Polymorfism;

Console.WriteLine("--- 3.4 Polymorfism ---\n");

List<UserError> userErrors = new List<UserError>();

userErrors.Add(new NumericInputError());
userErrors.Add(new TextInputError());
userErrors.Add(new MyOwnClass1());
userErrors.Add(new MyOwnClass2());
userErrors.Add(new MyOwnClass3());

foreach(UserError error in userErrors)
{
    Console.WriteLine(error.UEMessage());
}