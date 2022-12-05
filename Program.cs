using System;

// 

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter a number: ");
    string stringUserInputtedNumber = Console.ReadLine();
    int userInputtedNumber = Convert.ToInt32(stringUserInputtedNumber);

    for (int i = 1; i <= userInputtedNumber; i++)
    {
      if (i % 3 == 0 && i % 5 == 0)
      {
        Console.WriteLine("ping-pong");
      }
      else if (i % 3 == 0)
      {
        Console.WriteLine("ping");
      }
      else if (i % 5 == 0)
      {
        Console.WriteLine("pong");
      }
      else
      {
        Console.WriteLine(i);
      }
    }
  }
}