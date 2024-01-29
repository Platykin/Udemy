using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _07_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Code tha became comments.
            #region
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
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Foreach loop can't change the value of the matrix, since the values are passed as references
            //But nested for loops can alter the values

            //int[,] integers = new int[,]
            //{
            //    {1, 2, 3 },
            //    { 4, 5, 6 },
            //    { 7, 8, 9 },
            //};

            //for (int i = 0; i < integers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < integers.GetLength(1); j++)
            //    {
            //        if (integers[i, j] % 2 == 0)
            //        {
            //            Console.WriteLine(integers[i, j]);
            //        }
            //    }
            //}

            //string teste = "X";
            //teste = teste + "X";
            //Console.WriteLine(teste);
            //Jagged arrays are betters than multi dimensional arrays when some arrays don't have
            //the same size
            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[5];
            //jaggedArray[1] = new int[3];
            //jaggedArray[2] = new int[2];

            //jaggedArray[0] = new int[] { 8, 2, 6, 3, 10 };
            //jaggedArray[1] = new int[] { 81, 65, 99 };
            //jaggedArray[2] = new int[] { 115, 22 };

            //Console.WriteLine("The value in the middle is: {0}", jaggedArray[1][1]);





            //string[] igorFamily = new string[]
            //{
            //    "Socorro", "Rogerio", "Icaro"
            //};

            //string[] sarahFamily = new string[]
            //{
            //    "Alessandra", "Gilberto"
            //};

            //string[][] familyMembers = new string[2][]
            //{
            //    igorFamily, sarahFamily
            //};

            //foreach (string igorFamilyMember in igorFamily)
            //{
            //    foreach(string sarahFamilyMember in sarahFamily)
            //    {
            //        Console.WriteLine("{0} says hi to {1}", igorFamilyMember, sarahFamilyMember);
            //    }
            //}
            //int[] studentsGrades = new int[] { 5, 6, 8, 8, 1, 5, 3, 9, 2, 7, 4, 3, 8, 9, 5, 7, 4, 3, 6, 10, 10 };

            //Console.WriteLine(GetAvarage(studentsGrades));

            //int[] mood = new int[] { 5, 3, 6, 8, 1 };

            //int[] SunIsShining(int[] moodToImprove)
            //{
            //    for (int i = 0; i < moodToImprove.Length; i++)
            //    {
            //        mood[i] += 2;
            //    }
            //    return moodToImprove;
            //}

            //SunIsShining(mood);

            //foreach(int newMood in mood)
            //{
            //    Console.WriteLine("Before the improvement, the mood was {0}, now it is {1}!", newMood-2, newMood);

            //Console.WriteLine(Sum(numbers));

            //int soma1 = Sum(1, 2, 3, 4, 5, 6, 7, 8, 43, 66, 32, 32, 43, 54, 56, 4, 2);
            //int soma2 = Sum(6, 7, 8, 43, 66);
            //int soma3 = Sum(1, 2, 3, 4, 5, 6, 7);

            //Console.WriteLine(soma1);
            //Console.WriteLine(soma2);
            //Console.WriteLine(soma3);
            //}
            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 43, 66, 32, 32, 43, 54, 56, 4, 2 };
            //ArrayList myArrayList = new ArrayList();
            //ArrayList myArrayList2 = new ArrayList(100);

            //myArrayList.Add(25);
            //myArrayList.Add("Hello");
            //myArrayList.Add(13.37);
            //myArrayList.Add(13.37);
            //myArrayList.Add(11);
            //myArrayList.Add("Caviar");

            //myArrayList.Remove(25);
            //myArrayList.RemoveAt(1);

            //Console.WriteLine(myArrayList.Count);


            //double sum = 0;
            //foreach (object obj in myArrayList)
            //{
            //    if (obj is int)
            //    {
            //        sum += Convert.ToDouble(obj);
            //    }
            //    else if (obj is double)
            //    {
            //        sum += (double)obj;
            //    }
            //    else if (obj is string)
            //    {
            //        Console.WriteLine(obj);
            //    }
            //}
            //List<int> evenValues = new List<int> { };
            //Hashtable studentsTable = new Hashtable();

            //Student estudante1 = new Student(1, "Irgo", 3);
            //Student estudante2 = new Student(2, "Sarah", 4);
            //Student estudante3 = new Student(3, "Godofredo", 2);
            //Student estudante4 = new Student(4, "Burro", 1);

            //studentsTable.Add(estudante1.Id, estudante1);
            //studentsTable.Add(estudante2.Id, estudante2);
            //studentsTable.Add(estudante3.Id, estudante3);
            //studentsTable.Add(estudante4.Id, estudante4);

            //Student dadosEstudante1 = (Student)studentsTable[1];

            //foreach (DictionaryEntry entry in studentsTable)
            //{
            //    Student temp = (Student)entry.Value;
            //    Console.WriteLine("------------");
            //    Console.WriteLine("Numero de matricula: {0}", temp.Id);
            //    Console.WriteLine("Nome: {0}", temp.Name);
            //    Console.WriteLine("Media: {0}", temp.GPA);
            //    Console.WriteLine("------------\n");
            //}


            //Console.WriteLine("Numero da matricula: {0} Nome: {1} Media: {2}", dadosEstudante1.Id, dadosEstudante1.Name, dadosEstudante1.GPA);

            //Hashtable studentsTable = new Hashtable();

            //Student[] studentsArray = new Student[6];

            //studentsArray[0] = new Student(1, "Irgo", 7);
            //studentsArray[1] = new Student(2, "Sarah", 9);
            //studentsArray[2] = new Student(3, "Christian", 7);
            //studentsArray[3] = new Student(4, "Vermei", 4);
            //studentsArray[4] = new Student(2, "Carvas", 6);
            //studentsArray[5] = new Student(5, "Pozag", 1);

            //foreach (Student estudante in studentsArray)
            //{

            //    if(studentsTable.ContainsKey(estudante.Id))
            //    {
            //        Console.WriteLine("Sorry, a student with the same ID already exists\n");
            //    }

            //    else
            //    {
            //        studentsTable.Add(estudante.Id, estudante);
            //        Console.WriteLine("Student with ID {0} added.\n", estudante.Id);
            //    }

            //}
            //Dictionary<int, string> numeros = new Dictionary<int, string>();

            //numeros.Add(1, "one");
            //numeros.Add(2, "two");
            //numeros.Add(3, "three");
            //numeros.Add(4, "four");
            //numeros.Add(5, "five");

            //numeros.ContainsKey(0) ? Console.WriteLine(numeros[0]) : Console.WriteLine("nope");
            #endregion // Code that became comments.

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            Console.WriteLine("The element of the top is {0}", stack.Peek());

        }



        class Student
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public float GPA { get; set; }

            public Student(int id, string name, float gpa)
            {
                this.Id = id;
                this.Name = name;
                this.GPA = gpa;
            }


        }
    }
}
        //public static int Sum(params int[] numbers){
        //    int total = 0;
        //    for(int i = 0; i < numbers.Length; i++)
        //    {
        //        total += numbers[i];
        //    }

        //    return total;
        //}

        //static double GetAvarage(int[] gradesArray)
        //{
        //    double sum = 0;
        //    foreach (int grade in gradesArray)
        //    {
        //        sum += grade;
        //    }

        //    double avarage = (double)(sum/ gradesArray.Length);

        //    return avarage; 

        //}