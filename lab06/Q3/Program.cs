﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Dog dogs = new Dog();
            dogs.type();
            dogs.legs();

            Console.ReadLine();
        }

    }
}
