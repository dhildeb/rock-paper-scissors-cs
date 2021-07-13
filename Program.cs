using System;

namespace RockPaperScissors
{
  class Program
  {

    static void Main(string[] arg)
    {
      var game = new Game();
      game.Start();
      //   Random random = new Random();
      //   bool play = true;
      //   while (play)
      //   {
      //     Console.Clear();
      //     int num = random.Next(1, 4);
      //     System.Console.WriteLine("Rock, Paper, Scissors!");
      //     string input = System.Console.ReadLine().ToLower();
      //     if (input == "q")
      //     {
      //       play = false;
      //       break;
      //     }
      //     if (input != "rock" && input != "paper" && input != "scissors")
      //     {
      //       System.Console.WriteLine("no cheating");
      //       Console.ReadKey();
      //       continue;
      //     }
      //     if (num == 1)
      //     {
      //       System.Console.WriteLine("you Lose");
      //     }
      //     if (num == 2)
      //     {
      //       System.Console.WriteLine("you Tie");
      //     }
      //     if (num == 3)
      //     {
      //       System.Console.WriteLine("you Win!");
      //     }
      //     Console.ReadKey();
      //   }
    }
  }
}