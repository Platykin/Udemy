using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    internal class Car
    {
        private string _name;
        private int _hp;
        public Car(string name, int hp = 0)
        {
            _name = name;
            Console.WriteLine("{0} was created!", _name);
            _hp = hp;
        }

        public void Drive() { Console.WriteLine("{0} is driving!", _name); }

        public void Stop() { Console.WriteLine("{0} stoped!", _name); }

        public void GetInfo() { Console.WriteLine("Model: {0}, Horse Power: {1}", _name, _hp); }

    }
}
