using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------- //
            // TODO: execute program here
            Console.WriteLine("What will it be? Rock, Paper, or Scissors?");
            Console.WriteLine("1) Rock");
            Console.WriteLine("2) Paper");
            Console.WriteLine("3) Scissors");

            string playerChoiceText = Console.ReadLine();
            int playerChoiceNum = int.Parse(playerChoiceText);
            Random random = new Random();
            int computerChoiceNum = random.Next(1, 4);

            if (playerChoiceNum == 1)
            {
                Console.WriteLine("ROCK!");
                Console.WriteLine();
                Console.WriteLine($@"    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)");
            }
            else if (playerChoiceNum == 2)
            {
                Console.WriteLine("PAPER!");
                Console.WriteLine();
                Console.WriteLine($@"     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)");
            }
            else if (playerChoiceNum == 3)
            {
                Console.WriteLine("SCISSORS!");
                Console.WriteLine();
                Console.WriteLine($@"    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)");
            }
            else {
                Console.WriteLine("Sorry, that was not a valid choice. Goodbye.");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("VS");
            Console.WriteLine();

            if (computerChoiceNum == 1)
            {
                Console.WriteLine("ROCK!");
                Console.WriteLine();
                Console.WriteLine($@"    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)");
            }
            else if (computerChoiceNum == 2)
            {
                Console.WriteLine("PAPER!");
                Console.WriteLine();
                Console.WriteLine($@"     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)");
            }
            else if (computerChoiceNum == 3)
            {
                Console.WriteLine("SCISSORS!");
                Console.WriteLine();
                Console.WriteLine($@"    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)");
            }
            else
            {
                Console.WriteLine("Sorry, that was not a valid choice. Goodbye.");
            }

            // ------------------------------------------------------------- //
        }
    }
}