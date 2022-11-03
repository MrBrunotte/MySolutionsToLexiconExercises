namespace Exe_3_Inheritance
{
    public class Wolf : Animal
    {
        public int NumberOfFangs { get; set; }

        public Wolf(string type, double weight, string color, int numberOfFangs)
            : base(type, weight, color)
        {
            Type = type;
            Weight = weight;
            Color = color;
            NumberOfFangs = numberOfFangs;
        }

        public override void DoSound()
        {
            Console.WriteLine("AOUUUUUU AAAOOOUUUUU");
        }
    }
}
