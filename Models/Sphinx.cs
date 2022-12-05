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
  }
  public class Queen
  {
    public int X {get;set;}
    public string Y {get;set;}
    public Queen()
    {
      Name = "Queen";
      X = 8;
      Y = "3";
    }
    public void MoveQueen(int X, string Y)
    {
      X = X;
      Y = Y;
    }
  }
}


