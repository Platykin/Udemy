using System;

namespace Chapter3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate();
        }

        public static void Calculate()
        {
            Console.Write("Please, enter the first number number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Now enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int result = firstNumber + secondNumber;
            Console.WriteLine(result);
        }
    }
}