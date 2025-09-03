using board;
using System;
using chess;

namespace Chess_Console {
    class Program 
    {
    static void Main(string[] args) 
    {
            try
            {
                Board boarder = new Board(8, 8);

                boarder.putPiece(new Tower(boarder, Color.Black), new Position(0, 0));
                boarder.putPiece(new Tower(boarder, Color.Black), new Position(1, 3));
                boarder.putPiece(new King(boarder, Color.Black), new Position(3, 6));

                Screen.PrintBoard(boarder);

                Console.ReadLine();

            }
            catch (BoardException e) {
                Console.WriteLine(e.Message);
            }
    }
    }
}