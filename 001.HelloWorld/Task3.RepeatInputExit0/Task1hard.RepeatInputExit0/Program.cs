using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1hard.RepeatInputExit0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool isNumber;
            do
            {
                Console.Write("insert the number (0 - exit):");
                string input = Console.ReadLine();
                isNumber = int.TryParse(input, out number);
                if (isNumber)
                {
                    Console.WriteLine(input);
                }
                else
                {
                    Console.WriteLine($"\"{input}\" is not a number");
                }
            }
            while ((number != 0) || (!isNumber));
        }
    }
}
