namespace DesignPattern.Flyweight.SpreadSheet
{
    public class Cell
    {
        private int _row;
        private int _column;
        public string Content { get; set; }
        public Font Font { get; set; }

        public Cell(int row, int column)
        {
            _row = row;
            _column = column;
        }


        public void render()
        {
            System.Console.WriteLine($"{_row},{_column},{Content},{Font.ToString()}");

        }
    }
}