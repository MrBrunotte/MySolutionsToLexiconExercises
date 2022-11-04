namespace Exe_3_Inheritance
{
    public class Flamingo : Bird
    {
        public int LenghtOfLegs { get; set; }

        public Flamingo(string type, double weight, string color, int wingSpan, int lengthOfLegs)
            : base(type, weight, color, wingSpan)
        {
            LenghtOfLegs = lengthOfLegs;    // I dont need to instantiate the properties (string type, double weight, string color) from the base class again!
        }

        public override void DoSound()
        {
            Console.WriteLine("Flap flap");
        }
        public override string Stats()
        {
            return $"{base.Stats()} {LenghtOfLegs}";
        }
    }
}
