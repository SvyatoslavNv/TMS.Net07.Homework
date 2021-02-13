using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1middle.InputValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("insert the number:");
            string input = Console.ReadLine();
            bool result = int.TryParse(input, out number);
            if (result == true)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.Write($"\"{input}\" is not a number");
            }
            Console.ReadKey();
        }
    }
}
