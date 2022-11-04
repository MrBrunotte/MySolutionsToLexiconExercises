namespace Exe_3_Inheritance
{
    public class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }
        public Hedgehog(string type, double weight, string color, int nrOfSpikes)
            : base(type, weight, color)
        {
            NrOfSpikes = nrOfSpikes;    // I dont need to instantiate the properties (string type, double weight, string color) from the base class again!
        }

        public override void DoSound()
        {
            Console.WriteLine("No sound!!");
        }
        public override string Stats()
        {
            return $"{base.Stats()} {NrOfSpikes}";
        }
    }
}
