namespace Exe_3_Inheritance
{
    public class Worm : Animal
    {
        public string IsPoisonous { get; set; }
        public Worm(string type, double weight, string color, string isPoisonous)
            : base(type, weight, color)
        {
            IsPoisonous = isPoisonous;  // I dont need to instantiate the properties (string type, double weight, string color) from the base class again!
        }

        public override void DoSound()
        {
            Console.WriteLine("Worms don't make sounds!");
        }
        public override string Stats()
        {
            return $"{base.Stats()} {IsPoisonous}";
        }
    }
}
