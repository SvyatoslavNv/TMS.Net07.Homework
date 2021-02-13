using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2middle.DateTimeExit0
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data;
            var input = "enter";
            while (input != "exit")
            {
                Console.WriteLine("enter the date \"dd.mm.yyyy\" (for exit enter \"exit\")");
                input = Console.ReadLine();
                bool result = DateTime.TryParse(input, out data);
                if (result == true)
                {
                    Console.WriteLine(data.DayOfWeek);
                }
                else
                {
                    Console.WriteLine($"\"{input}\" incorrect data entry");
                }
            }
        }
    }
}
