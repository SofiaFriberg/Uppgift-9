using System;

namespace Uppgift_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First one to 3p wins, Let's GO!");

            string inputPlayer = null;
    

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

                    




                }



            }



            Console.ReadKey();
        }
    }
}
