// I really wanted to skip this part, since I already know about variables and data types... But let's stay into the course

namespace Variables
{
    public class Variables
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 15;
            b = 28;
            int sum = a + b;
            //Unlike C++, we can't just separate integer number from strings with commas while printing on the console, we have to concatanate
            // with a "+" when trying to print the statement into the screen
            Console.WriteLine(a + " + " + b + " is " + sum);

            double d1, d2;
            d1 = 0.82643855;
            d2 = 3.77729433;
            Console.WriteLine("Double precision division: " + (d2 / d1));

            float f1, f2;
            f1 = 0.82643855f;
            f2 = 3.77729433f;
            Console.WriteLine("Float precision division: " + (f2 / f1));


            string myName = "Irgo";
            Console.WriteLine(myName);

            Console.Write("Please, enter your name: ");
            string userNameInput = Console.ReadLine();
            Console.WriteLine("User name is " + userNameInput);

            Console.WriteLine("Please, press any key to see it ASCII form. ");
            int userKeyInput = Console.Read();
            Console.WriteLine(userKeyInput + " is the ASCII code for the key that you've just pressed");

            double myDouble = 52.26;
            int myInt;

            myInt = (int)myDouble;
            Console.WriteLine(myInt);

            //Parsing strings into integers

            string myString = "52";
            string secondString = "26";
            int result = Int32.Parse(myString) + Int32.Parse(secondString);

            Console.WriteLine(result);    


        }
    }
}