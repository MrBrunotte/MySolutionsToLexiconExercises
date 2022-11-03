namespace Exe_3_Inheritance
{
    public class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }
        public Hedgehog(string type, double weight, string color, int nrOfSpikes)
            : base(type, weight, color)
        {
            Type = type;
            Weight = weight;
            Color = color;
            NrOfSpikes = nrOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("No sound!!");
        }
    }
}
