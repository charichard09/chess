using System;
using ChessGame.Model;
// 

public class Program
{
  public static void Main()
  {
    ChessBoard chessBoard = new ChessBoard();
    Queen queenPiece = new Queen();
    chessBoard.MovePiece("Queen", 7, 3);
    for (int i = 0; i < chessBoard.ChessField.GetLength(0); i++) 
    {
      Console.Write((i + 1) + "| ");

      for (int j = 0; j < chessBoard.ChessField.GetLength(1); j++)
      {
        Console.Write(chessBoard.ChessField[i, j] + " ");
      }
      Console.WriteLine();
    }
  
    Console.WriteLine(chessBoard.CheckHorizontalLeft(queenPiece));
  }
}