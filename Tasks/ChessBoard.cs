using System.Collections.Generic;

namespace Tasks
{
    public class ChessBoard
    {
        public enum Column
        {
            A = 1,
            B = 2,
            C = 3,
            D = 4,
            E = 5,
            F = 6,
            G = 7,
            H = 8
        }

        public class Cell
        {
            public Cell(string position)
            {
                var cell = TextToCell(position);
                this.row = cell.row;
                this.column = cell.column;
            }

            public Cell(int row, int column, Piece piece = Piece.Knight)
            {
                this.row = row;
                this.column = (Column)column;
                this.Piece = piece;
            }
            public int row { get; set; }
            public Column column { get; set; }

            public string Notation
            {
                get { return column.ToString() + row; }
            }
            public Piece Piece { get; set; }

        }

        public static Cell TextToCell(string text)
        {
            if (text.Trim().Length != 2)
                return null;
            int row = text.ToUpper()[0] - 'A' + 1;
            int column;
            int.TryParse(text[1].ToString(), out column);
            return new Cell(row, column);
        }
        public bool IsValidPosition(string position)
        {
            var cell = TextToCell(position);
            if (cell != null)
                return IsValidCell(cell);
            return false;
        }

        public List<List<Cell>> Board;

        public ChessBoard()
        {
            Board = new List<List<Cell>>(8);
            for (int i = 0; i < 8; i++)
            {
                Board.Add(new List<Cell>(8));
            }

        }

        public List<Cell> PossibleMoves(Cell cell)
        {
            switch (cell.Piece)
            {
                case Piece.Knight:
                    return NightMoves(cell);
                default:
                    return null;
            }

        }

 
        private List<Cell> NightMoves(Cell cell)
        {
            List<Cell> result = new List<Cell>();


            foreach (Pair p in knightMoves.Moves)
            {
                int nRow = cell.row + p.x;
                int nCol = (int)cell.column + p.y;
                if (IsValidCell(nRow, nCol))
                    result.Add(new Cell(nRow, nCol, cell.Piece));
            }
            return result;
        }

        public bool IsValidCell(Cell cell)
        {
            return cell.row > 0 && cell.row <= 8 && (int)cell.column > 0 && (int)cell.column <= 8;
        }
        public bool IsValidCell(int row, int column)
        {
            return row > 0 && row <= 8 && column > 0 && column <= 8;
        }
    }
}
