﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Exercises1
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

    }
}
