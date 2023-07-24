namespace EnhancedIfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature = -52;
            string stateOfMatter;

            if (temperature < 0)
            {
                stateOfMatter = "Solid";
            }
            else
            {
                stateOfMatter = "Liquid";
            }

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            temperature += 104;

            //shorter way:
            stateOfMatter = temperature < 0 ? "Solid" : "Liquid";
            Console.WriteLine("State of matter is {0}", stateOfMatter);

            //Unreadable way:
            temperature += 52;
            stateOfMatter = temperature > 100 ? "Gas" : temperature < 0 ? "Solid" : "Liquid";
            Console.WriteLine("State of matter is {0}", stateOfMatter);
        }
    }
}