namespace Exe_3_Inheritance
{
    // 8 skapa subklasser till Bird
    public class Pelican : Bird
    {
        public int PelicanSize { get; set; }
        public Pelican(string type, double weight, string color, int wingSpan, int pelicanSize)
            : base(type, weight, color, wingSpan)
        {
            PelicanSize = pelicanSize;  // I dont need to instantiate the properties (string type, double weight, string color) from the base class again!
        }
        public override string Stats()
        {
            return $"{base.Stats()} {PelicanSize}";
        }
    }
}
