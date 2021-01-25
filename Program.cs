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

                while (pointsPlayer < 3 && pointsComputer < 3) //först till 3p
                {
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("Choose between ROCK (r), PAPER (p) and SCISSORS (s)");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper(); //gör användarens svar till versaler

                    Random rndm = new Random();

                    randomInt = rndm.Next(1 , 4); //slumpar en siffra av 1, 2 och 3 (för att ge datorn en "hand")

                    switch (randomInt)
                    {
                        case 1: //sten för datorn

                            inputComputer = "ROCK";
                            Console.WriteLine("I choose ROCK");

                            if (inputPlayer == "ROCK" || inputPlayer == "R")
                            {
                                Console.WriteLine("Damnit! It'a a draw!");
                            }
                            else if (inputPlayer == "PAPER" || inputPlayer == "P")
                            {
                                Console.WriteLine("YOU WON!");
                                pointsPlayer++;    //adderar 1 poäng till användaren
                            }
                            else if(inputPlayer == "SCISSORS" || inputPlayer == "S")
                            {
                                Console.WriteLine("HA! I WON!");
                                pointsComputer++;   //adderar 1 poäng till datorn
                            }
                            else
                            {
                                Console.WriteLine("Do not try to cheat. there is only three diffrent handformations you can do. Try again");
                            }
                            break;

                        case 2: //papper för datorn

                            inputComputer = "PAPER";
                            Console.WriteLine("I choose PAPER");

                            if (inputPlayer == "PAPER" || inputPlayer == "P")
                            {
                                 Console.WriteLine("Damnit! It'a a draw!");
                            }
                            else if (inputPlayer == "SCISSORS" || inputPlayer == "S")
                            {
                                Console.WriteLine("YOU WON!");
                                pointsPlayer++;
                            }
                            else if (inputPlayer == "ROCK" || inputPlayer == "R")
                            {
                                Console.WriteLine("HA! I WON!");
                                pointsComputer++;
                            }
                            else
                            {
                                Console.WriteLine("Do not try to cheat. there is only three diffrent handformations you can do. Try again");
                            }
                            break;

                        case 3: //sax för datorn

                            inputComputer = "SCISSORS";
                            Console.WriteLine("I choose SCISSORS");
                            if (inputPlayer == "SCISSORS" || inputPlayer == "S")
                            {
                                 Console.WriteLine("Damnit! It'a a draw!");
                            }
                            else if (inputPlayer == "ROCK" || inputPlayer == "R")
                            {
                                Console.WriteLine("YOU WON!");
                                pointsPlayer++;
                            }
                            else if (inputPlayer == "PAPER" || inputPlayer == "P")
                            {
                                Console.WriteLine("HA! I WON!");
                                pointsComputer++;
                            }
                            else
                            {
                                Console.WriteLine("Do not try to cheat. there is only three diffrent handformations you can do. Try again");
                            }
                            break;
                        
                       

                    }
                    System.Threading.Thread.Sleep(300);
                    Console.WriteLine("\n Scoreboard:     Player: " + pointsPlayer + "p." + "     Computer: " + pointsComputer +"p."); //poängtavla, visas efter varje "slag"
                    
                }
                if (pointsPlayer == 3) // om användaren fått 3 poäng vinner den
                {
                    System.Threading.Thread.Sleep(300);
                    Console.WriteLine("Congratulations! YOU ARE THE WINNER!");
                }
                else if (pointsComputer == 3) // om datorn har fått 3 poäng så vinner den
                { 
                    System.Threading.Thread.Sleep(300);
                    Console.WriteLine("I WON!! *the wiinnneer taaakes iit aaall*");
                }
                
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Do you want to play again? (y/n)"); // öppnar upp för en ny runda
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

            }
            

            Console.ReadKey();
        }
    }
}
