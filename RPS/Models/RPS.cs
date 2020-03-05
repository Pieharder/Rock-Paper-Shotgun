using System;

namespace RPS.Models
{
  public class RPShotgun
  {
    public int Rock = 1;
    public int Paper = 2;
    public int Scissors = 3; 

    public int CompChoice()
    {
      Random rand = new Random();
      int compRandom = rand.Next(1, 4);
      
      if (compRandom == 1)
      {
        Console.WriteLine("Computer Chooses Rock!");
        return 1;
      }
      else if (compRandom == 2)
      {
        Console.WriteLine("Computer Chooses Paper!");
        return 2;
      }
      else
      {
        Console.WriteLine("Computer Chooses Scissors!");
        return 3;
      }
    }
  }
}