using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.DaysOfWeek
{
    class Program
    {
        enum daysofweek
        {
            понедельник,
            вторник,
            среда,
            четверг,
            пятница,
            суббота,
            воскресенье
        }
        static void Main(string[] args)
        {
            daysofweek day;
            string input = "enter";
            while (input != "exit")
            {
                Console.WriteLine("enter the day of the week (for exit enter \"exit\")");
                input = Console.ReadLine();
                switch (input)
                {
                    case "monday":
                    {
                        day = (daysofweek)0;
                        Console.WriteLine(day);
                        break;
                    }
                    case "tuesday":
                    {
                        day = (daysofweek)1;
                        Console.WriteLine(day);
                        break;
                    }
                    case "wednes­day":
                    {
                        day = (daysofweek)2;
                        Console.WriteLine(day);
                        break;
                    }
                    case "thursday":
                    {
                        day = (daysofweek)3;
                        Console.WriteLine(day);
                        break;
                    }
                    case "friday":
                    {
                        day = (daysofweek)4;
                        Console.WriteLine(day);
                        break;
                    }
                    case "saturday":
                    {
                        day = (daysofweek)5;
                        Console.WriteLine(day);
                        break;
                    }
                    case "sunday":
                    {
                        day = (daysofweek)6;
                        Console.WriteLine(day);
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("incorrect data entry");
                        break;
                    }
                }
            }
        }
    }
}
