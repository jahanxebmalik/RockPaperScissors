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
            int userScore = 0;
            int computerScore = 0;

            Console.Write("Enter your choice - ROCK, PAPER or SCISSORS: ");

            userInput = Console.ReadLine();

            //Generate random number
            Random random = new Random();
            randomInt = random.Next(1, 4);

            switch (randomInt)
            {
                case 1:
                    computerInput = "ROCK";
                    Console.WriteLine("Computer chose {0}", computerInput);
                    if (userInput == "ROCK")
                    {
                        Console.WriteLine("DRAW !!\n\n");
                    }
                    else if (userInput == "PAPER")
                    {
                        Console.WriteLine("PLAYER WINS !!\n\n");
                        userScore++;
                    }
                    else if (userInput == "SCISSORS")
                    {
                        Console.WriteLine("COMPUTER WINS !!\n\n");
                        computerScore++;
                    }
                    break;
                case 2:
                    computerInput = "PAPER";
                    Console.WriteLine("Computer chose {0}", computerInput);
                    if (userInput == "PAPER")
                    {
                        Console.WriteLine("DRAW !!\n\n");
                    }
                    else if (userInput == "ROCK")
                    {
                        Console.WriteLine("COMPUTER WINS !! \n\n");
                        computerScore++;
                    }
                    else if (userInput == "SCISSORS")
                    {
                        Console.WriteLine("PLAYER WINS !!\n\n");
                        userScore++;
                    }
                    break;
                case 3:
                    computerInput = "SCISSORS";
                    Console.WriteLine("Computer chose {0}", computerInput);
                    if (userInput == "SCISSORS")
                    {
                        Console.WriteLine("DRAW !!\n\n");
                    }
                    else if (userInput == "ROCK")
                    {
                        Console.WriteLine("PLAYER WINS !!\n\n");
                        userScore++;
                    }
                    else if (userInput == "PAPER")
                    {
                        Console.WriteLine("COMPUTER WINS !!\n\n");
                        computerScore++;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
            //     public void gameRules()
            //     {
            //         if (userInput == "ROCK" && computerInput == "PAPER")
            //         {
            //             Console.WriteLine("PLAYER WINS!!!");
            //             userScore++;
            //         }
            //         else if (userInput == "ROCK")
            // }
        }
    }
}
