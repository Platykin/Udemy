using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Challenge2
{
    class Employees
    {
        protected string Name {  get; set; }
        protected string FirstName { get; set; }
        protected int Salary { get; set; }

        public Employees() 
        {
            Name = string.Empty;
            FirstName = string.Empty;
            Salary = 0;
        }
        public Employees(string name, string firstName, int salary) 
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine("Working");
        }

        public virtual void Pause()
        {
            Console.WriteLine("Coffee pause!");
        }

        public override string ToString()
        {
            return $"Name: {Name}\nSalary: {Salary}";
        }

    }
}
