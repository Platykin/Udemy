using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section9
{
    class Dog : Animal
    {

        public bool isHappy { get; set; }
        public Dog(string animal_name, int age) : base(animal_name, age) 
        {
            isHappy = true;
        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Au? 🙃"); ;
        }

        public override void Play()
        {
            if (isHappy)
            {
                base.Play();
            }
        }

    }
}
