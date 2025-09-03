using board;
using System;
using chess;

namespace Chess_Console {
    class Program 
    {
    static void Main(string[] args) 
    {

            //ChessPosition pos = new ChessPosition('c', 7);
            //Console.WriteLine(pos.toPosition());
            //Console.ReadLine();
            try
            {
               ChessGame game = new ChessGame();


                Screen.PrintBoard(game.boarder);

            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}