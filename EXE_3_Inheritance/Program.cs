/* FRÅGOR ARV:
         * 13) Om vi under utveckling kommer fram till att alla fåglar behöver samma attribut så'
         * lägger vi dem i klassen --- Bird --- eftersom det är basklassen och alla andra fråglar ärver
         * från den klassen.
         * 14) Om alla djur behöver nya attribut så lägger vi dom i basklassen --- Animal --- eftersom alla
         * ärver från den.
*/

using Exe_3_Inheritance;
// Instantiate new objects with properties from constructor
Bird bird = new Bird("Donald duck", 12, "white", 88);
Dog dog = new Dog("Hedda", 15, "Black&White", "Boston Terrier");
Flamingo flamingo = new Flamingo("Pinky", 8, "Pink", 2, 3);
Hedgehog hedgehog = new Hedgehog("Spiky", 5, "Black&White", 20000);
Horse horse = new Horse("Indian", 250, "White", 4);
Pelican pelican = new Pelican("Sea living", 5, "Gray", 3, 25);
Wolf wolf = new Wolf("Wild", 35, "Black", 4);

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