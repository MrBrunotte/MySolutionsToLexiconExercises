namespace Exe_3_Inheritance
{
    public class Swan : Bird
    {
        public string BeekColor { get; set; }
        public Swan(string type, double weight, string color, int wingSpan, string beekColor)
            : base(type, weight, color, wingSpan)
        {
            Type = type;
            Weight = weight;
            Color = color;
            WingSpan = wingSpan;
            BeekColor = beekColor;
        }
    }
}
