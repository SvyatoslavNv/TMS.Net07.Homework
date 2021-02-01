using System;
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
            int number = 1;
            while (number != 0)
            {
                Console.Write("insert the number (0 - exit):");
                string input = Console.ReadLine();
                bool result = int.TryParse(input, out number);
                if (result == true)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"\"{input}\" is not a number");
                    number = 1;
                }
            }
        }
    }
}
