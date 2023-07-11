using System;
using System.Globalization;
namespace _2_1_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringForFloat = "0.85"; // datatype should be float
            float floatParsing = float.Parse(stringForFloat, CultureInfo.InvariantCulture);
            string stringForInt = "12345"; // datatype should be int
            int integerParsing = int.Parse(stringForInt);
            float result = floatParsing + integerParsing;
            Console.WriteLine("Float number: " + floatParsing + "\nInteger number: " + integerParsing + "\nSum: " + result);

            string userName;
            Console.WriteLine("Please, write your name and last name: ");
            userName = Console.ReadLine();
            string userNameUpper = userName.ToUpper();
            Console.WriteLine(userNameUpper);
            string userNameLower = userName.ToLower();
            Console.WriteLine(userNameLower);
            string userNameTrim = userName.Trim();
            Console.WriteLine(userNameTrim);
            string userNameSub = userName.Substring(2);
            Console.WriteLine(userNameSub);
        }
    }
}