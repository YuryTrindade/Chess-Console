using System;
using board;

namespace Chess_Console
{
     class Screen
    {
        public static void PrintBoard(Board boarder)
        {
            for (int i = 0; i<boarder.rows; i++) {
                for (int j = 0; j < boarder.columns; j++)
                {
                    if (boarder.piece(i, j)==null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(boarder.piece(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
