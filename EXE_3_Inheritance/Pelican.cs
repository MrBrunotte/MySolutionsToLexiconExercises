namespace Exe_3_Inheritance
{
    // 8 skapa subklasser till Bird
    public class Pelican : Bird
    {
        public int PelicanSize { get; set; }
        public Pelican(string type, double weight, string color, int wingSpan, int pelicanSize)
            : base(type, weight, color, wingSpan)
        {
            Type = type;
            Weight = weight;
            Color = color;
            WingSpan = wingSpan;
            PelicanSize = pelicanSize;
        }
    }
}
