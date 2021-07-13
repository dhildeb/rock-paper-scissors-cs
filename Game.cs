using System;

namespace RockPaperScissors
{
  class Game
  {
    bool _play = true;
    public void Start()
    {
      while (_play)
      {
        Console.Clear();
        string compChoice = ComputerRPS();
        System.Console.WriteLine("Play Rock, Paper, Scissors?");
        string input = System.Console.ReadLine().ToLower();
        if (input == "q")
        {
          _play = false;
          break;
        }
        System.Console.WriteLine($"Computer Chose {compChoice}");
        if (input == compChoice)
        {
          System.Console.WriteLine("You Tied");
        }
        switch (input)
        {
          case "rock":
            switch (compChoice)
            {
              case "scissors":
                System.Console.WriteLine("You Win!");
                break;
              case "paper":
                System.Console.WriteLine("You Lose");
                break;
            }
            break;
          case "paper":
            switch (compChoice)
            {
              case "scissors":
                System.Console.WriteLine("You lose");
                break;
              case "rock":
                System.Console.WriteLine("You Win!");
                break;
            }
            break;
          case "scissors":
            switch (compChoice)
            {
              case "rock":
                System.Console.WriteLine("You Lose");
                break;
              case "paper":
                System.Console.WriteLine("You Win!");
                break;
            }
            break;
          default:
            System.Console.WriteLine("no cheating");
            break;
        }
        Console.ReadKey();
      }

      static string ComputerRPS()
      {
        Random random = new Random();
        int num = random.Next(1, 4);
        if (num == 1)
        {
          return "rock";
        }
        if (num == 2)
        {
          return "scissors";
        }
        if (num == 3)
        {
          return "paper";
        }
        return "";
      }
    }
  }
}