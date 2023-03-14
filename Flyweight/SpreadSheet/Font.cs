namespace DesignPattern.Flyweight.SpreadSheet
{
    public class Font
    {

        public string FontFamily { get; set; } = null!;
        public int FontSize { get; set; }
        public bool IsBold { get; set; }

        public override string ToString()
        {
            return $"FontFamily:{FontFamily}, FontSize:{FontSize},IsBold:{IsBold}";
        }
    }
}