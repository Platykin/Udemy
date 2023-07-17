namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3, num2 = 5, num3;
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool taChovendo = false;
            Console.WriteLine("ta chovendo? {0}", taChovendo);

            //increment looks just like C++
            num3++;
            Console.WriteLine("num3 is {0}", num3);
            Console.Read();

            // Other operators look the same as in C++ (+, -, /, *, %, >, <, >=, <=, ==, &&, ||);
        }
    }
}