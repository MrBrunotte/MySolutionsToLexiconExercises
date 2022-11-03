namespace Exe_3_Inheritance
{
    // 5 - 7 Subclasses that inherit from Animal
    public class Horse : Animal
    {
        public int NumberOfLegs { get; set; }
        public Horse(string type, double weight, string color, int numberOfLegs)
            : base(type, weight, color)
        {
            Type = type;
            Weight= weight;
            Color= color;
            NumberOfLegs = numberOfLegs;
        }
        public override void DoSound()
        {
            Console.WriteLine("Gnägg gnägg...");
        }
    }
}
