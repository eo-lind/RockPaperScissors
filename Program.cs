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

<<<<<<< HEAD
=======
            // ! couldn't get the ascii art to work
>>>>>>> 22fd17c3d036c5e52825b316dc6550fed24d8965
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