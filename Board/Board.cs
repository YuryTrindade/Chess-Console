

namespace board
{
    internal class Board
    {
        public int row {  get; set; }
        public int collumns { get; set; }
        private ChessPiece[,] pieces;

        public Board(int row, int col)
        {
            this.row = row;
            this.collumns = collumns;
            this.pieces = new ChessPiece[row, collumns];
        }
    }
}
