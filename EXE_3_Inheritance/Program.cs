/*
 3.2) Arv
1. Skapa abstrakta klassen Animal
2. Fyll klassen Animal med egenskaper (properties) som alla djur bör ha. Tex namn, vikt, ålder.
3. Skapa en abstrakt metod som heter DoSound().
4. Skapa en konstruktor för att skapa ett Animal.
5. Skapa Subklasserna (ärver från Animal): Horse, Dog, Hedgehog, Worm och Bird, Wolf.
6. Ge dessa minst en unik egenskap var. Vilken egenskap det är är inte det viktiga här.
Exempel Worm IsPoisonous, Hedgehog NrOfSpikes , Bird WingSpan osv.
7. Implementera så att DoSound() metoden skriver ut hur djuret låter..
8. Skapa nu följande tre klasser: Pelican, Flamingo och Swan. Dessa ska ärva från Bird.
9. Ge dessa minst en unik egenskap var.
10. Skapa gränssnittet Person med en metod deklaration Talk();
11. Skapa Klassen Wolfman som ärver från Wolf och implementerar Person gränssnittet.
12. Implementera Talk() som skriver ut vad Wolfman säger.
13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i
vilken klass bör vi lägga det?
14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
3.3) Polymorfism
1. Skapa metoden Stats() i klassen Animal som har returtypen string. Metoden ska
kunna overridas i dess Subklasser. Metoden ska returnera alla egenskaper (properties) som
djuret har.
2. Skriv en override för Stats() i Subklasserna för Animal så den returnerar alla properties för
det djuret.
3. Skapa en lista Animals i program.cs som tar emot djur.
4. Skapa några djur (av olika typ) i din lista.
5. Skriv ut vilka djur som finns i listan med hjälp av en foreach-loop
6. Anropa även Animals Sound() metod i foreach-loopen.
7. Gör en check i For-loopen ifall animal även är av typen Person, om den är det typ-casta till
Person och anropa dess Talk() metod.
8. Skapa en lista för hundar.
9. F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
10. F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
11. Skriv ut samtliga Animals Stats() genom en foreach loop.
12. Testa och se så det fungerar.
13. F: Förklara vad det är som händer.
14. Skriv ut Stats() metoden enbart för alla hundar genom en foreach på Animals.
15. Skapa en ny metod med valfritt namn i klassen Dog som endast returnerar en valfri sträng.
16. Kommer du åt den metoden från Animals listan?
17. F: Varför inte?
18. Hitta ett sätt att skriva ut din nya metod för dog genom en foreach på Animals.
 */

/* FRÅGOR ARV:
         * 13) Om vi under utveckling kommer fram till att alla fåglar behöver samma attribut så'
         * lägger vi dem i klassen --- Bird --- eftersom det är basklassen och alla andra fråglar ärver
         * från den klassen.
         * 14) Om alla djur behöver nya attribut så lägger vi dom i basklassen --- Animal --- eftersom alla
         * ärver från den.
*/

using Exe_3_Inheritance;
// Instantiate new objects with properties from constructor
Bird bird = new Bird("Duck", 12, "white", 88);
Dog dog = new Dog("Dog", 15, "Black&White", "Boston Terrier");
Flamingo flamingo = new Flamingo("Pinky", 8, "Pink", 2, 3);
Hedgehog hedgehog = new Hedgehog("Spiky", 5, "Black&White", 20000);
Horse horse = new Horse("Indian", 250, "White", 4);
Pelican pelican = new Pelican("Sea living", 5, "Gray", 3, 25);
Wolf wolf = new Wolf("Wild", 35, "Black", 4);
Swan swan = new Swan("Black swan", 25, "Black", 3, "Red");
Worm worm = new Worm("Daggmask", 1, "Red", "Not poisonous");

Wolfman wolfman = new Wolfman("Wildman", 97, "Gray", 4);

Console.WriteLine("\nWhat do all the animal sound like??\n");
bird.DoSound();
dog.DoSound();
flamingo.DoSound();
hedgehog.DoSound();
horse.DoSound();
pelican.DoSound();
wolf.DoSound();

wolfman.Talk();

// Polymorfism section
Console.WriteLine("\n----- Polymorfism section -----\n");
List<Animal> animals = new List<Animal>();
animals.Add(dog);
animals.Add(horse);
animals.Add(pelican);
animals.Add(wolf);
animals.Add(wolfman);
Console.WriteLine($"Print the dog from the animals list: {dog.Breed}, {dog.Type}, {dog.Weight}\n");

Console.WriteLine("----- 3.3 5) Print all anaimals in the animals list -----\n");
foreach (Animal animal in animals)
{
    Console.WriteLine($"\nAnimal stats: {animal.Stats()}");
    Console.Write($"Animal sound: ");
    animal.DoSound();
}
Console.WriteLine("\n----- 3.3 7) CASTING (casting video 4 12:44) -----\n");
// casting video 4 12:44
foreach (Animal animal in animals)
{
    if (animal is IPerson person)
    {
        Console.WriteLine("Talk() method from IPerson interface:");
        person.Talk();
        Console.WriteLine("\n");
    }
    Console.WriteLine($"\nAnimal stats: {animal.Stats()}");
    Console.Write($"Animal sound: ");
    animal.DoSound();
}

Console.WriteLine("\n----- 3.3 8) List of dogs -----");
List<Dog> dogList = new List<Dog>();
//dogList.Add(Horse);
Console.WriteLine("Cannot add type Horse to type Dog, they are not the same type, dogList only takes type Dog");

Console.WriteLine("\n----- 3.3 9) What type takes all animals? -----");
List<Animal> animalList = new List<Animal>();
animalList.Add(dog);
animalList.Add(horse);
Console.WriteLine("Animal is the base class so it takes all types!");
Console.WriteLine("--- animalList ---");
foreach (Animal animal1 in animalList)
{
    Console.WriteLine($"\nAnimal type: {animal1.Type} and it's stats: {animal1.Stats()}");

}


Console.WriteLine("\n----- 3.3 11) skriv ut samtliga Animals Stats() genom en foreach loop -----");

List<Animal> allAnimals = new List<Animal>();

allAnimals.Add(bird);
allAnimals.Add(dog);
allAnimals.Add(flamingo);
allAnimals.Add(hedgehog);
allAnimals.Add(horse);
allAnimals.Add(pelican);
allAnimals.Add(swan);
allAnimals.Add(wolf);
allAnimals.Add(wolfman);
allAnimals.Add(worm);

foreach(Animal animal2 in allAnimals)
{
    Console.WriteLine($"\t{animal2.Stats()}");
}

Console.WriteLine("\n----- 3.3 14) skriv Stats() för Dogs på Animals genom en foreach loop -----");

foreach(Animal myDog in animalList)
{
    Console.WriteLine($"Dog: {dog.Stats()}");
}

Console.WriteLine("\n----- 3.3 15) skapa en metod i klassen Dog som returnerar en sträng -----");

Console.WriteLine(dog.GenerateDogString());

foreach(Animal animal3 in allAnimals)
{
    if(animal3 is Dog doggie)
    {
        Console.WriteLine("Dogs in Animal");
        Console.WriteLine($"Dog stats: {animal3.Stats()}");
    }
}
