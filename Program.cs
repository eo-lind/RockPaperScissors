using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------- //
            // ! TODO: score is not updating
            for (int i = 0; i < 6; i++)
            {
                string rock = $@"    _______
-- - '   ____)
      (_____)
      (_____)
      (____)
-- -.__(___)";
                string paper = $@"     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)";
                string scissors = $@"    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)";
                int playerScore = 0;
                int computerScore = 0;
                Console.WriteLine("-------------------------------");
                Console.WriteLine($"|  Player: {playerScore}  |  Computer: {computerScore}  |");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("What will it be? Rock, Paper, or Scissors?");
                Console.WriteLine("1) Rock");
                Console.WriteLine("2) Paper");
                Console.WriteLine("3) Scissors");

                string playerChoiceText = Console.ReadLine();
                int playerChoiceNum = int.Parse(playerChoiceText);
                Random random = new Random();
                int computerChoiceNum = random.Next(1, 3);

                if (playerChoiceNum == 1 && computerChoiceNum == 2)
                {
                    computerScore += 1;
                    Console.WriteLine();
                    Console.WriteLine("ROCK");
                    Console.WriteLine();
                    Console.WriteLine($"{rock}");
                    Console.WriteLine();
                    Console.WriteLine("VS");
                    Console.WriteLine();
                    Console.WriteLine("PAPER");
                    Console.WriteLine();
                    Console.WriteLine($"{paper}");
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (playerChoiceNum == 1 && computerChoiceNum == 3)
                {
                    playerScore += 1;
                    Console.WriteLine();
                    Console.WriteLine("ROCK");
                    Console.WriteLine();
                    Console.WriteLine($"{rock}");
                    Console.WriteLine();
                    Console.WriteLine("VS");
                    Console.WriteLine();
                    Console.WriteLine("SCISSORS");
                    Console.WriteLine();
                    Console.WriteLine($"{scissors}");
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (playerChoiceNum == 2 && computerChoiceNum == 1)
                {
                    playerScore += 1;
                    Console.WriteLine();
                    Console.WriteLine("PAPER");
                    Console.WriteLine();
                    Console.WriteLine($"{paper}");
                    Console.WriteLine();
                    Console.WriteLine("VS");
                    Console.WriteLine();
                    Console.WriteLine("ROCK");
                    Console.WriteLine();
                    Console.WriteLine($"{rock}");
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (playerChoiceNum == 2 && computerChoiceNum == 3)
                {
                    computerScore += 1;
                    Console.WriteLine();
                    Console.WriteLine("PAPER");
                    Console.WriteLine();
                    Console.WriteLine($"{paper}");
                    Console.WriteLine();
                    Console.WriteLine("VS");
                    Console.WriteLine();
                    Console.WriteLine("SCISSORS");
                    Console.WriteLine();
                    Console.WriteLine($"{scissors}");
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (playerChoiceNum == 3 && computerChoiceNum == 1)
                {
                    computerScore += 1;
                    Console.WriteLine();
                    Console.WriteLine("SCISSORS");
                    Console.WriteLine();
                    Console.WriteLine($"{scissors}");
                    Console.WriteLine();
                    Console.WriteLine("VS");
                    Console.WriteLine();
                    Console.WriteLine("ROCK");
                    Console.WriteLine();
                    Console.WriteLine($"{rock}");
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (playerChoiceNum == 3 && computerChoiceNum == 2)
                {
                    playerScore += 1;
                    Console.WriteLine();
                    Console.WriteLine("SCISSORS");
                    Console.WriteLine();
                    Console.WriteLine($"{scissors}");
                    Console.WriteLine();
                    Console.WriteLine("VS");
                    Console.WriteLine();
                    Console.WriteLine("PAPER");
                    Console.WriteLine();
                    Console.WriteLine($"{paper}");
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (playerChoiceNum == 1 && computerChoiceNum == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("ROCK");
                    Console.WriteLine();
                    Console.WriteLine($"{rock}");
                    Console.WriteLine();
                    Console.WriteLine("VS");
                    Console.WriteLine();
                    Console.WriteLine("ROCK");
                    Console.WriteLine();
                    Console.WriteLine($"{rock}");
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (playerChoiceNum == 2 && computerChoiceNum == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("PAPER");
                    Console.WriteLine();
                    Console.WriteLine($"{paper}");
                    Console.WriteLine();
                    Console.WriteLine("VS");
                    Console.WriteLine();
                    Console.WriteLine("PAPER");
                    Console.WriteLine();
                    Console.WriteLine($"{paper}");
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (playerChoiceNum == 3 && computerChoiceNum == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("SCISSORS");
                    Console.WriteLine();
                    Console.WriteLine($"{scissors}");
                    Console.WriteLine();
                    Console.WriteLine("VS");
                    Console.WriteLine();
                    Console.WriteLine("SCISSORS");
                    Console.WriteLine();
                    Console.WriteLine($"{scissors}");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
            // ------------------------------------------------------------- //
        }
    }
}