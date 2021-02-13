using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1hard.DateTimeOff
{
    class Program
    {
        enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main(string[] args)
        {
            DaysOfWeek dayOfWeek;
            DateTime data;
            int day, month, year;
            var input = "enter";
            while (input != "exit")
            {
                Console.WriteLine("enter the date \"dd.mm.yyyy\" (for exit enter \"exit\")");
                input = Console.ReadLine();
                bool isValidDate = DateTime.TryParse(input, out data);
                if (isValidDate == true)
                {
                    Console.WriteLine(data.DayOfWeek); //для сверки
                    String[] number = input.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                    bool resultYear = int.TryParse(number[2], out year);
                    bool resultMonth = int.TryParse(number[1], out month);
                    bool resultDay = int.TryParse(number[0], out day);
                    if (0001 <= year && year <= 2999)
                    {
                        int year4 = (year - 1) / 4;
                        int year100 = (year - 1) / 100;
                        int year400 = (year - 1) / 400;
                        int yearLeap = year4 - year100 + year400;
                        int dayInYear = 366 * yearLeap + 365 * (year - 1 - yearLeap);
                        int[] numMonth;
                        if ((year) % 4 == 0 && ((year) % 100 != 0 || (year) % 400 == 0))
                        {
                            numMonth = new int[] { 0, 0, 31, 60, 91, 121, 152, 182, 213, 244, 274, 305, 335 };
                        }
                        else
                        {
                            numMonth = new int[] { 0, 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334 };
                        }
                        int dayInMonth = numMonth[month];
                        int numDays = (day + dayInMonth + dayInYear) % 7;
                        dayOfWeek = (DaysOfWeek)numDays;
                        Console.WriteLine(dayOfWeek);
                    }
                    else
                        Console.WriteLine("the year must be within 0001-2999");
                }
                else
                    Console.WriteLine($"\"{input}\" incorrect data entry");

            }
        }
    }
}
