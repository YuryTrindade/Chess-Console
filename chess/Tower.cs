using board;
using System;


namespace chess
{
    class Tower : ChessPiece
    {

        public Tower(Board boarder, Color color) : base(boarder, color)
            {

        }
        public override string ToString()
        {
          return "T";
        }
     }

}
