namespace Exe_3_Inheritance
{
    public class Dog : Animal
    {
        public string Breed { get; set; }
        public Dog(string type, double weight, string color, string breed)
            : base(type, weight, color)
        {
            Breed = breed;  // I dont need to instantiate the properties (string type, double weight, string color) from the base class again!
        }

        public override void DoSound()
        {
            Console.WriteLine("Woff woff..");
        }
        public override string Stats()
        {
            return $"{base.Stats()} {Breed}";
        }
        public string GenerateDogString()
        {
            return "A string about dogs";
        }
    }
}
