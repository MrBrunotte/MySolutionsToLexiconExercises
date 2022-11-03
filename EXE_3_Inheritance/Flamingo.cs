namespace Exe_3_Inheritance
{
    public class Flamingo : Bird
    {
        public int LenghtOfLegs { get; set; }

        public Flamingo(string type, double weight, string color, int wingSpan, int lengthOfLegs)
            : base(type, weight, color, wingSpan)
        {
            Type = type;
            Weight = weight;
            Color = color;
            WingSpan = wingSpan;
            LenghtOfLegs = lengthOfLegs;
        }

        public override void DoSound()
        {
            Console.WriteLine("Flap flap");
        }
    }
}
