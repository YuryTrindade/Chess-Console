

using board;

namespace chess
{
    class ChessGame
    {
        public Board boarder {  get; set; }
        private int turn;
        private Color ActualPlayer;

        public ChessGame() 
        {
            boarder = new Board(8,8);
            turn = 1;
            ActualPlayer = Color.White;
            putPieces();
        }

        public void performMoviment(Position origin, Position target) 
        {
            ChessPiece p = boarder.removePiece( origin );
            p.incrementMoves();
            ChessPiece capturePiece = boarder.removePiece(target);
            boarder.putPiece(p, target);
        }

        private void putPieces()
        {
            boarder.putPiece(new Tower(boarder, Color.Black), new ChessPosition('c', 1).toPosition());

        }

    }
}
