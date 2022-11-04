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

Console.WriteLine("--- 3.4 Polymorfism ---\n");

