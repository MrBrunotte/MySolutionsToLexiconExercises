namespace Exe_3_Inheritance
{
    public class Swan : Bird
    {
        public string BeekColor { get; set; }
        public Swan(string type, double weight, string color, int wingSpan, string beekColor)
            : base(type, weight, color, wingSpan)
        {
            BeekColor = beekColor;  // I dont need to instantiate the properties (string type, double weight, string color) from the base class again!
        }
        public override string Stats()
        {
            return $"{base.Stats()} {BeekColor}";
        }
    }
}
