﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat("ho",20);
            Console.WriteLine(cat.NumberOfLegs);
        }
    }
}
