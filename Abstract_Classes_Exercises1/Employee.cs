using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Exercises1
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            base.SayName();
        }

        public void Quit(Employee employee)
        {
            Console.WriteLine(firstName + " " + lastName + " " + "has quit.");
        }
    }
}
