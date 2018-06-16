using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Exercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";

            employee.SayName();

            // this works
            employee.Quit(employee: employee);
            
            // this doesn't:
            //Employee quit = new IQuittable();
            //quit.Quit(employee: employee);

            Console.ReadLine();
        }
    }
}
