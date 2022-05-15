using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Store user and computer inputs
            string userInput, computerInput;
            int randomInt;

            Console.Write("Enter your choice - ROCK, PAPER or SCISSORS: ");

            userInput = Console.ReadLine();

            Random random = new Random();
            randomInt = random.Next(1, 4);

            switch (randomInt)
            {
                case 1:
                    computerInput = "ROCK";
                    break;
                case 2:
                    computerInput = "PAPER";
                    break;
                case 3:
                    computerInput = "SCISSORS";
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }

        }
    }
}
