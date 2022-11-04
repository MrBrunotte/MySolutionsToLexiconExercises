namespace Exe_3_Inheritance
{
    // 5 - 7 Subclasses that inherit from Animal
    public class Horse : Animal
    {
        public int NumberOfLegs { get; set; }
        public Horse(string type, double weight, string color, int numberOfLegs)
            : base(type, weight, color)
        {
            NumberOfLegs = numberOfLegs;    // I dont need to instantiate the properties (string type, double weight, string color) from the base class again!
        }
        public override void DoSound()
        {
            Console.WriteLine("Gnägg gnägg...");
        }
        public override string Stats()
        {
            return $"{base.Stats()} {NumberOfLegs}";
        }
    }
}
