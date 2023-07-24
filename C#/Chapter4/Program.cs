namespace Chapter4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //it works just like C++
            Console.Write("Enter the current temperature: ");
            string inputTemperature = Console.ReadLine();
            int temperature = 0;
            int tryParseTemperature;efe
            
            if (int.TryParse(inputTemperature, out tryParseTemperature))
            {
                temperature = tryParseTemperature;
            }
            else 
            {
                Console.WriteLine("Please, write a valide temperature value (We expect a integer number). 0 is considered as default");
            }

            if (temperature == 20)
            {
                Console.WriteLine("It's 10 degrees!");
            } else if (temperature < 20)
            {
                Console.WriteLine("Take a coat!");
            } else
            {
                Console.WriteLine("Shorts are enough for today");
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            //This is the standard pattern for if else statments? That's ugly
        }
    }
}