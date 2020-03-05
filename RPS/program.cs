using System;
using System.Collections.Generic;
using RPS.Models;

namespace RPS
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Lets Play Rock, Paper, Scissors!");
      Console.WriteLine("Would you like to:");
      Console.WriteLine("[PLAY] [QUIT]");
      string starter = Console.ReadLine();
      if (starter.ToLower() == "play")
      {
        PlayerMove();
      }
      else
      {
        Console.WriteLine("You have forsaken yourself and therfore your all of humanity.");
      }

    }
    public static void PlayerMove()
    {
            Console.WriteLine("[ROCK] [PAPER] [SCISSORS]");
      string choice = Console.ReadLine();
      if(choice.ToLower() == "rock")
      {
        int userChoice = 1;
      }
      else if (choice.ToLower() == "paper")
      {
        int userChoice = 2;
      }
      else if (choice.ToLower() == "scissors")
      {
        int userChoice = 3;
      }
      else
      {
        Console.WriteLine("Okay, Bud, let's try this again...");
        Main();
      }
    }    
  }
}