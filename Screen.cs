using System;
using board;

namespace Chess_Console
{
     class Screen
    {
        public static void PrintBoard(Board boarder)
        {
            for (int i = 0; i<boarder.rows; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < boarder.columns; j++)
                {
                    if (boarder.piece(i, j)==null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        PrintPiece(boarder.piece(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void PrintPiece(ChessPiece piece) 
        {
            if(piece.color == Color.White)
            {
                Console.Write(piece);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;

            }
        }
    }
}
