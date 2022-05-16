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
            bool playAgain = true;

            while (playAgain)
            {
                int userScore = 0;
                int computerScore = 0;

                while (userScore < 3 && computerScore < 3)
                {

                    Console.Write("Enter your choice - ROCK, PAPER or SCISSORS: ");

                    userInput = Console.ReadLine().ToUpper();

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

                    Console.WriteLine("\n\nSCORES: \tPLAYER\t{0}\tCOMPUTER:\t{1}", userScore, computerScore);
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
                if (userScore == 3)
                {
                    Console.WriteLine("Player WON!!");
                }
                else if (computerScore == 3)
                {
                    Console.WriteLine("Computer WON !!");
                }
                else
                {
                    Console.WriteLine("It's a DRAW!! ");
                }

                Console.WriteLine("Do you want to play again? (y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
            }
        }
    }
}
