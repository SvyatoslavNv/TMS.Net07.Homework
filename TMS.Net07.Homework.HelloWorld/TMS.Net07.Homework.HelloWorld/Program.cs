﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("insert the number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
