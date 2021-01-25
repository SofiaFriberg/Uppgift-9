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
                    Console.WriteLine("Choose between ROCK, PAPER and SCISSORS");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rndm = new Random();

                    randomInt = rndm.Next(1 , 4);

                    switch (randomInt)
                    {
                        case 1:

                            inputComputer = "ROCK";
                            Console.WriteLine("I choose ROCK");

                            if ()
                            {
                                
                            }
                            else if ()
                            {
                                
                            }
                            else if()
                            {

                            }
                            else
                            {
                                Console.WriteLine("Do not try to cheat. there is only three diffrent handformations you can do. Try again");
                            }
                            break;

                        case 2:

                            inputComputer = "PAPER";
                            Console.WriteLine("I choose PAPER");

                            if ()
                            {
                                
                            }
                            else if ()
                            {
                                
                            }
                            else if ()
                            {

                            }
                            else
                            {
                                Console.WriteLine("Do not try to cheat. there is only three diffrent handformations you can do. Try again");
                            }
                            break;

                        case 3:

                            inputComputer = "SCISSORS";
                            Console.WriteLine("I choose SCISSORS");
                            if ()
                            {
                                
                            }
                            else if ()
                            {
                                
                            }
                            else if ()
                            {
                                
                            }
                            else
                            {
                                Console.WriteLine("Do not try to cheat. there is only three diffrent handformations you can do. Try again");
                            }
                            break;
                        
                        default:

                            break;



                    }

                    


                }



            }



            Console.ReadKey();
        }
    }
}
