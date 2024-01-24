using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] grades = new int[5];
            //grades[0] = 20;
            //grades[1] = 15;
            //grades[2] = 60;
            //grades[3] = 90;
            //grades[4] = 8;

            //Console.WriteLine("Grades at index 0: {0}", grades[0]);

            //string input = Console.ReadLine();
            //grades[0] = int.Parse(input);

            //Console.WriteLine("Grades at index 0: {0}", grades[0]);

            //int[] nums = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    nums[i] = i + 13;
            //}

            //for(int j = 0; j < nums.Length; j++)
            //{
            //    Console.WriteLine("Element{0} = {1}", j, nums[j]);
            //}
            //int counter = 0;
            //foreach (int k in nums)
            //{
            //    Console.WriteLine("Element{0} = {1}", counter, k);
            //    counter++;
            //}

            //string[] migus = new string[10];

            //for(int i = 0; i < migus.Length; i++)
            //{
            //    Console.WriteLine("Qual o nome do seu migu?");
            //    migus[i] = Console.ReadLine() + "\n";      
            //}

            //for (int j = 0; j < migus.Length; j++)
            //{
            //    Console.WriteLine("Olá, {0}", migus[j]);
            int[] numbers = { 1, 2, 3, 4, 5 };

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }    
}