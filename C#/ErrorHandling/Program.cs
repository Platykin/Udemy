namespace ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter the first number: ");
            string userInput = Console.ReadLine();
            try
            {
                int userInputAsInt = int.Parse(userInput);
                Console.Write("Now enter the second number: ");
                string secondUserIput = Console.ReadLine();
                int secondNumber = int.Parse(secondUserIput);
                Console.WriteLine(userInputAsInt/secondNumber);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception: It is expected an integer, try again.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception: It is suported integers in the range of -2,147,483,648 to 2,147,483,647, try again.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Argument null exception: It is expected an integer, try again.");
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("We do not support division by 0, try other divisor!");
            }
            finally
            {
                Console.WriteLine("This is always called!");
            }
        }
    }
}