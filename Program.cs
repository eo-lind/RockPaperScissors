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

            string playerChoice = Console.ReadLine().ToLower();

            // ! couldn't get the ascii art to work
            if (playerChoice == "rock")
            {
                Console.WriteLine($@"    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)");
            }
            else if (playerChoice == "paper")
            {
                Console.WriteLine($@"     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)");
            }
            else if (playerChoice == "scissors")
            {
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

            // ------------------------------------------------------------- //
        }
    }
}