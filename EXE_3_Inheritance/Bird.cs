namespace Exe_3_Inheritance
{
    public class Bird : Animal
    {
        public int WingSpan { get; set; }
        public Bird(string type, double weight, string color, int wingSpan)
            : base(type, weight, color)
        {
            Type = type;
            Weight = weight;
            Color = color;
            WingSpan = wingSpan;
        }

        public override void DoSound()
        {
            Console.WriteLine("KvittElIkvitt");
        }
    }
}
