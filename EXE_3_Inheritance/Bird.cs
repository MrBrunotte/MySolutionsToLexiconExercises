namespace Exe_3_Inheritance
{
    public class Bird : Animal
    {
        public int WingSpan { get; set; }
        public Bird(string type, double weight, string color, int wingSpan)
            : base(type, weight, color)
        {
            WingSpan = wingSpan; // I dont need to instantiate the properties (string type, double weight, string color) from the base class again!
        }

        public override void DoSound()
        {
            Console.WriteLine("KvittElIkvitt");
        }
        public override string Stats()
        {
            return $"{base.Stats()} {WingSpan}";
        }
    }
}
