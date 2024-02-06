using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section9
{
    internal class Animal
    {
        public string name { get; set; }

        public int age { get; set; }

        public bool isHungry { get; set; }
        public Animal(string animal_name, int animal_age)
        {
            name = animal_name;
            age = animal_age;
            isHungry = true;
        }

        public virtual void MakeSound() 
        {
            Console.WriteLine("The");
        }

        public virtual void Eat()
        {
            if (isHungry)
            {
                Console.WriteLine($"{name} is eating");
            }
            else
            {
                Console.WriteLine($"{name} is not hungry");
            }
        }

        public virtual void Play()
        {
            Console.WriteLine($"{name} is playing!");
        }



    }
}
