using System;

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
        }
    }
}