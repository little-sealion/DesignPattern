using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Flyweight.SpreadSheet
{
    public class SpreadSheet
    {
        private const int MAX_ROWS = 3;
        private const int MAX_COLS = 3;
        private Cell[,] cells = new Cell[MAX_ROWS, MAX_COLS];
        private FontFactory _fontFactory;
        public SpreadSheet(FontFactory fontFactory)
        {
            _fontFactory = fontFactory;
            generateCells();

        }
        public void SetContent(int row, int col, String content)
        {
            ensureCellExists(row, col);

            cells[row, col].Content = content;
        }
        public void SetFontFamily(int row, int col, FontType fontType)
        {
            ensureCellExists(row, col);
            var cell = cells[row, col];
            cells[row, col].Font = _fontFactory.GetFont(fontType);
        }
        private void ensureCellExists(int row, int col)
        {
            if (row < 0 || row >= MAX_ROWS)
                throw new ArgumentOutOfRangeException();

            if (col < 0 || col >= MAX_COLS)
                throw new ArgumentOutOfRangeException();
        }
        private void generateCells()
        {
            for (var row = 0; row < MAX_ROWS; row++)
            {
                for (var col = 0; col < MAX_COLS; col++)
                {
                    var cell = new Cell(row, col);
                    cell.Font = _fontFactory.GetFont(FontType.BODY);
                    cells[row, col] = cell;
                }
            }

        }
        public void Render()
        {
            for (var row = 0; row < MAX_ROWS; row++)
                for (var col = 0; col < MAX_COLS; col++)
                    cells[row, col].render();
        }
    }
}