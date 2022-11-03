namespace Exe_3_Inheritance
{
    public class Worm : Animal
    {
        public bool IsPoisonous { get; set; }
        public Worm(string type, double weight, string color, bool isPoisonous)
            : base(type, weight, color)
        {
            Type = type;
            Weight = weight;
            Color = color;
            IsPoisonous = isPoisonous;
        }

        public override void DoSound()
        {
            Console.WriteLine("Worms don't make sounds!");
        }
    }
}
