namespace board
{
    internal class ChessPiece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int moves { get; protected set; }
        public Board boarder { get; protected set; }

        public ChessPiece( Board boarder, Color color)
        {
            this.position = null;
            this.boarder = boarder;
            this.color = color;
            this.moves = 0;
        }

        public void incrementMoves() 
        {
            moves++;
        }
    }
}
