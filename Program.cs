using System;

namespace Uppgift_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First one to 3p wins, Let's GO!");

            string inputPlayer = null;
            string inputComputer;
            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {
                int pointsPlayer = 0;
                int pointsComputer = 0;

                while (pointsPlayer < 3 && pointsComputer < 3)
                {
                    Console.WriteLine("Choose between ROCK (r), PAPER (p) and SCISSORS (s)");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rndm = new Random();

                    randomInt = rndm.Next(1 , 4);

                    switch (randomInt)
                    {
                        case 1:

                            inputComputer = "ROCK";
                            Console.WriteLine("I choose ROCK");

                            if (inputPlayer == "ROCK" || inputPlayer == "R" || inputPlayer == "r")
                            {
                                Console.WriteLine("Damnit! It'a a draw!");
                            }
                            else if (inputPlayer == "PAPER" || inputPlayer == "P" || inputPlayer == "p")
                            {
                                Console.WriteLine("YOU WON!");
                                pointsPlayer++;
                            }
                            else if(inputPlayer == "SCISSORS" || inputPlayer == "S" || inputPlayer == "s" )
                            {
                                Console.WriteLine("HA! I WON!");
                                pointsComputer++;
                            }
                            else
                            {
                                Console.WriteLine("Do not try to cheat. there is only three diffrent handformations you can do. Try again");
                            }
                            break;

                        case 2:

                            inputComputer = "PAPER";
                            Console.WriteLine("I choose PAPER");

                            if (inputPlayer == "PAPER" || inputPlayer == "P" || inputPlayer == "p")
                            {
                                 Console.WriteLine("Damnit! It'a a draw!");
                            }
                            else if (inputPlayer == "SCISSORS" || inputPlayer == "S" || inputPlayer == "s")
                            {
                                Console.WriteLine("YOU WON!");
                                pointsPlayer++;
                            }
                            else if (inputPlayer == "ROCK" || inputPlayer == "R" || inputPlayer == "r")
                            {
                                Console.WriteLine("HA! I WON!");
                                pointsComputer++;
                            }
                            else
                            {
                                Console.WriteLine("Do not try to cheat. there is only three diffrent handformations you can do. Try again");
                            }
                            break;

                        case 3:

                            inputComputer = "SCISSORS";
                            Console.WriteLine("I choose SCISSORS");
                            if (inputPlayer == "SCISSORS" || inputPlayer == "S" || inputPlayer == "s")
                            {
                                 Console.WriteLine("Damnit! It'a a draw!");
                            }
                            else if (inputPlayer == "ROCK" || inputPlayer == "R" || inputPlayer == "r")
                            {
                                Console.WriteLine("YOU WON!");
                                pointsPlayer++;
                            }
                            else if (inputPlayer == "PAPER" || inputPlayer == "P" || inputPlayer == "p")
                            {
                                Console.WriteLine("HA! I WON!");
                                pointsComputer++;
                            }
                            else
                            {
                                Console.WriteLine("Do not try to cheat. there is only three diffrent handformations you can do. Try again");
                            }
                            break;
                        
                        default:

                            break;



                    }
                    Console.WriteLine("\n Scoreboard:     Player: " + pointsPlayer + "p." + "     Computer: " + pointsComputer +"p.");
                    
                }
                if (pointsPlayer == 3)
                {
                    Console.WriteLine("Congratulations! YOU ARE THE WINNER!");
                }
                else if (pointsComputer == 3)
                {
                    Console.WriteLine("I WON!! *the wiinnneer taaakes iit aaall*");
                }


            }
            Console.WriteLine("Do you want to play again? (y/n)");
            string continueChar = Console.ReadLine();
            if (continueChar == "y" || continueChar == "Y")
            {
                playAgain = true;
                Console.Clear();
            }
            else if (continueChar == "n" || continueChar == "N")
            {
                playAgain = false;
                Console.WriteLine("Welcome back another time then!");
            }

            Console.ReadKey();
        }
    }
}
