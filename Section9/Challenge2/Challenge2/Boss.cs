using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class Boss : Employees
    {
        private string CompanyCar {  get; set; }

        public Boss() { }
        public Boss(string name, string firstName, int salary, string companyCar)
            : base(name, firstName, salary)
        {
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("Am I leading or looking for a lead??");
        }


    }
}
