namespace Exe_3_Inheritance
{
    public class Wolf : Animal
    {
        public int NumberOfFangs { get; set; }

        public Wolf(string type, double weight, string color, int numberOfFangs)
            : base(type, weight, color)
        {
            NumberOfFangs = numberOfFangs;  // I dont need to instantiate the properties (string type, double weight, string color) from the base class again!
        }

        public override void DoSound()
        {
            Console.WriteLine("AOUUUUUU AAAOOOUUUUU");
        }
        public override string Stats()
        {
            return $"{base.Stats()} {NumberOfFangs}";
        }
    }
}
