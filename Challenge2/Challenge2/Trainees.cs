using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class Trainees : Employees
    {
        private int WorkingHours { get; set; }
        private int SchoolHours { get; set; }

        public Trainees()
        {
            WorkingHours = 0;
            SchoolHours = 0;
        }

        public Trainees(string name, string firstName, int salary, int workingHours, int schoolHours)
            : base(name, firstName, salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("Learning time");
        }

        public override void Work()
        {
            Console.WriteLine($"The trainee worked for {WorkingHours}h");
        }

    }
}
