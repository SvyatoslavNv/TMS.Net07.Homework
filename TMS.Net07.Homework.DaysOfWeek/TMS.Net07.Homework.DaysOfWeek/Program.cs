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
            daysofweek dayofweek;
            DateTime data;
            int day, month, year;
            var input = "enter";
            while (input != "exit")
            {
                Console.WriteLine("enter the date \"dd.mm.yyyy\" (for exit enter \"exit\")");
                input = Console.ReadLine();
                bool result = DateTime.TryParse(input, out data);
                if (result == true)
                {
                    Console.WriteLine(data.DayOfWeek); //временнно
                    String[] number = input.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                    bool resultyear = int.TryParse(number[2], out year);
                    bool resultmonth = int.TryParse(number[1], out month);
                    bool resultday = int.TryParse(number[0], out day);
                    if (0001 <= year && year <= 2999)
                    {
                        int year4 = (year - 1) / 4;
                        int year100 = (year - 1) / 100;
                        int year400 = (year - 1) / 400;
                        int yearleap = year4 - year100 + year400;
                        int dayinyear = 366 * yearleap + 365 * (year - 1 - yearleap);
                        int[] nummonth;
                        if ((year) % 4 == 0 && ((year) % 100 != 0 || (year) % 400 == 0))
                        {
                            nummonth = new int[] {0, 0, 31, 60, 91, 121, 152, 182, 213, 244, 274, 305, 335};
                        }
                        else
                        {
                            nummonth = new int[] {0, 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334};
                        }
                        int dayinmonth = nummonth[month];
                        int numdays = (day + dayinmonth + dayinyear) % 7;
                        switch (numdays)
                        {
                            case 0:
                                {
                                    dayofweek = (daysofweek)0;
                                    Console.WriteLine(dayofweek);
                                    break;
                                }
                            case 1:
                                {
                                    dayofweek = (daysofweek)1;
                                    Console.WriteLine(dayofweek);
                                    break;
                                }
                            case 2:
                                {
                                    dayofweek = (daysofweek)2;
                                    Console.WriteLine(dayofweek);
                                    break;
                                }
                            case 3:
                                {
                                    dayofweek = (daysofweek)3;
                                    Console.WriteLine(dayofweek);
                                    break;
                                }
                            case 4:
                                {
                                    dayofweek = (daysofweek)4;
                                    Console.WriteLine(dayofweek);
                                    break;
                                }
                            case 5:
                                {
                                    dayofweek = (daysofweek)5;
                                    Console.WriteLine(dayofweek);
                                    break;
                                }
                            case 6:
                                {
                                    dayofweek = (daysofweek)6;
                                    Console.WriteLine(dayofweek);
                                    break;
                                }
                            default:
                                {
                                    break;
                                }
                        }
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
