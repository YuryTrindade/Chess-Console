

using System.Data;

namespace board
{
    internal class Board
    {
        public int rows {  get; set; }
        public int columns { get; set; }
        private ChessPiece[,] pieces;

        public Board(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            this.pieces = new ChessPiece[rows, columns];
        }

        public ChessPiece piece(int column, int row)
        {
            return pieces[row, column];
        }

        public ChessPiece piece(Position pos)
        {
            return pieces[pos.row, pos.column];
        }

        public bool findPiece(Position pos)
        {
            validatePosition(pos);
            return piece(pos) != null;
        }

        public void putPiece(ChessPiece p, Position pos)
        {
            if(findPiece(pos))
            {
                throw new BoardException("Já existe uma peça nessa posição");
            }
            pieces[pos.row, pos.column] = p;
            p.position = pos;
        }

        public ChessPiece removePiece(Position pos)
        {
            if(piece(pos) == null)
            {
                return null;
            }
            ChessPiece aux = piece(pos);
            aux.position = null;
            pieces[pos.row, pos.column] = null;
            return aux;
        }

        public bool validPosition(Position pos)
        {
            if (pos.row < 0 || pos.row >= rows || pos.column < 0 || pos.column >= columns)
            {
                return false;
            }
            return true;
        }

        public void validatePosition(Position pos) 
        {
            if (!validPosition(pos))
            {
                throw new BoardException("Posição inválida!");
            }
        }
    }
}
