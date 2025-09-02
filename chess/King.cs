using board;
using System.Security.Cryptography.X509Certificates;

namespace chess
{
     class King : ChessPiece
    {
        public King(Board boarder, Color color) : base(boarder, color)
        {
      
        }
        public override string ToString()
        {
            return "R";
        }
    }
}
