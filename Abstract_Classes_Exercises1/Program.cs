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
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>() { "TV", "Radio", "CD Player" };

            Employee<int> numbers = new Employee<int>();
            numbers.Things = new List<int>() { 13, 32, 41, 50 };
            

            //Employee employee = new Employee();
            //employee.FirstName = "Sample";
            //employee.LastName = "Student";

            //employee.SayName();


            //IQuittable quit = new Employee() { FirstName = "Student", LastName = "Employee" };
            //quit.Quit(employee: employee);

            Console.ReadLine();
        }
    }
}
