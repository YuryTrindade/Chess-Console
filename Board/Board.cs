

namespace board
{
    internal class Board
    {
        public int row {  get; set; }
        public int columns { get; set; }
        private ChessPiece[,] pieces;

        public Board(int row, int collumns)
        {
            this.row = row;
            this.columns = collumns;
            this.pieces = new ChessPiece[row, collumns];
        }

        public ChessPiece piece(int column, int row)
        {
            return pieces[row, column];
        }

        public void putPiece(ChessPiece p, Position pos)
        {
            pieces[pos.row, pos.column] = p;
            p.position = pos;
        }
    }
}
