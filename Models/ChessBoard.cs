using System;
using System.Collections.Generic;

namespace ChessGame.Model
{
  public class ChessBoard
  {
    public string[,] ChessField { get; set;}

    public ChessBoard()
    { 
      ChessField = new string[,] {
        {"0", "1", "2", "3", "4", "5", "6", "7"},
        {"0", "1", "2", "3", "4", "5", "6", "7"},
        {"0", "1", "2", "3", "4", "5", "6", "7"},
        {"0", "1", "2", "3", "4", "5", "6", "7"},
        {"0", "1", "2", "3", "4", "5", "6", "7"},
        {"0", "1", "2", "3", "4", "5", "6", "7"},
        {"0", "1", "2", "3", "4", "5", "6", "7"},
        {"0", "1", "2", "3", "4", "5", "6", "7"}
      };
    }
    //update the queen object (coordinates)
    // hori top
    public List<Coords> CheckHorizontalLeft(Queen queenPiece)
    {
      List<Coords> horizontalLeft = new List<Coords>() {};
      for (int i = queenPiece.X - 1; i > 0; i--)
      {
        // List<Coords> horizontalLeft = { queenPiece.X, i};
        Coords posOneLeft = new Coords(i, queenPiece.Y);
        horizontalLeft.Add(posOneLeft);
      }
      return horizontalLeft;
    }

    // hori bottom
    // write function to assign all vertical left coords
    // public void CheckVerticalUp()
    // {
      // queen x: 7 y: 3
      
      // for (int i = x; i < x; i--)
      // {
      // List coords = { {i, y} 
    //   }
    // }
    // vertical right
    // diag top left
    // diag top right
    // diag bottom left
    // diag bottom right
  }

  public class Coords
  {
    public int PosX { get; set; }
    public int PosY { get; set; }

    public Coords(int x, int y)
    {
      PosX = x;
      PosY = y;
    }
  }


  public class Queen
  {
    public string GamePiece {get;set;}
    public int X {get;set;}
    public int Y {get;set;}
    public List<Coords> movableCoords { get; set; }
    public Queen()
    {
      GamePiece = "Queen";
      X = 7;
      Y = 3;
      movableCoords = new List<Coords>() {};
    }

    public void MovePiece(int xCoordinate, int yCoordinate)
    {
      ChessField[xCoordinate, yCoordinate] = "Q";
      QueenPiece.X = xCoordinate;
      QueenPiece.Y = yCoordinate;
    }
  }
}