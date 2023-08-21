using System.Numerics;

namespace Classes_and_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Car audi = new Car("audi", 198);
            audi.Drive();
            
            Car bmw = new Car("bmw", 120);

            string userInput = "";
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                audi.Stop();
                bmw.Stop();
            }
            else 
            {
                audi.Drive();
            }
            bmw.GetInfo();
            audi.GetInfo();
        }
    }
}