namespace Exe_3_Inheritance
{
    public class Dog : Animal
    {
        public string Breed { get; set; }
        public Dog(string type, double weight, string color, string breed)
            : base(type, weight, color)
        {
            Type = type;
            Weight = weight;
            Color = color;
            Breed = breed;
        }

        public override void DoSound()
        {
            Console.WriteLine("Woff woff..");
        }
    }
}
