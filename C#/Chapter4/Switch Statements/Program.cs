using System;
using System.Diagnostics.CodeAnalysis;
using static System.Formats.Asn1.AsnWriter;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 25;

            switch (age)
            {
                case 15:
                    Console.WriteLine("You're too young to party");
                    break;
                case 25:
                    Console.WriteLine("Nice, good to go!");
                    break;
                default:
                    Console.WriteLine("Sooo, how old are you? :)");
                    break;
            }

            string userName = "Irgoo";
            switch (userName) 
            {
                case "Irgo":
                    Console.WriteLine("Aoba Irgo, c ta bão?");
                    break;
                default:
                    Console.WriteLine("Uai, ocê num é o Irgo :((");
                    break;
            }

            /* CHALLENGE 2
create an application with a score, highscore and a highscoreplayer.
Create a method which has two parameters, one for the score and one for the playerName.
When ever that method is called, it should be checked if the score of the player is higher than the highscore, if so, "New highscore is + " score" and in another line "New highscore holder is " + playerName - should be written onto the console, if not "The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer.
Consider which variables are required globally and which ones locally.
             */

            string highScorePlayer = "Irgo";
            int highScore = 123456;

            void highScoreChecker(int highScore)
            {
                int newScore = 0;
                Console.Write("Enter your score:");
                newScore = int.Parse(Console.ReadLine());

                if (newScore > highScore)
                {
                    Console.WriteLine("New highscore is {0}", newScore);
                    Console.WriteLine("What is your name, fellow competitor?");
                    string newCompetitor = Console.ReadLine();
                    Console.WriteLine("Incredible, you managed to beat the unbeatable {0}! Now all livings souls shall know our new player, {1}!", highScorePlayer, newCompetitor);
                }
                else
                {
                    Console.WriteLine("You didn't stand a chance! {0} stay unbeatable! MUAHAHAHA", highScorePlayer);
                }

            }

            highScoreChecker(highScore);

        }
    }
}