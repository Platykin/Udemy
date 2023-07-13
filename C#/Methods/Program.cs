namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstMethod();
            Console.WriteLine("Enter 2 float numbers: ");
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            float firstNumber = float.Parse(firstInput);
            float secondNumber = float.Parse(secondInput);
            Console.WriteLine("The multiplications of {0} and {1} is {2}", firstNumber, secondNumber , MultiplyMethod(firstNumber, secondNumber));
            string s = "HeY ThErE !";
            s = LowUpper(s);
            Console.WriteLine(s);
            Count(s);
        }


        public static void FirstMethod() //good practice to use PascalCase on methods names and classes names
        {
            Console.WriteLine("Called by a method");
        }

        public static string LowUpper(string lowUpperString)
        {
            string temp1 = lowUpperString.ToLower();
            string temp2 = lowUpperString.ToUpper();
            string result = temp1 + temp2;
            return result;
        }


        public static float MultiplyMethod(float num1, float num2)
        { 
            return (num1 * num2);
        }

        public static void CountCharacter(string count)
        {
            Console.WriteLine("The amount of characters is {0}", count.Length);
        }
    }
}