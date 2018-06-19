using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Exercises1
{
    class Employee<T> : Person //, IQuittable
    {
        public override void SayName()
        {
            base.SayName();
        }

        public int Id { get; set; }
        public List<T> Things { get; set; }

        //public static bool operator== (Id n1,Id n2)
        //{
        //    if (n1 == n2)
        //        return true;
        //    else
        //        return false;
        //}

        //public static bool operator!= (Id n1, Id n2)
        //{
        //    if (n1 != n2)
        //        return true;
        //    else
        //        return false;
        //}

        //public void Quit(Employee employee)
        //{
        //    Console.WriteLine(FirstName + " " + LastName + " has quit.");
        //}
    }
}
