using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Console_Project_Time_Class_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Console Project: Time Class by Jared Tims\n");

            WriteLine("Part 1: Creating objects with 3 valid parameters");
            WriteLine("then changing one value to invalid value\n");

            WriteLine("Assigning time with 9, 10, and 58");
            Time validMorningTime = new Time(9, 10, 58);
            WriteLine(validMorningTime);
            WriteLine("Changing hours to 99");
            validMorningTime.Hours = 99;
            WriteLine($"{validMorningTime}\n");

            WriteLine("Assigning time with 14, 30, and 17");
            Time validAfternoonTime = new Time(14, 30, 17);
            WriteLine(validAfternoonTime);
            WriteLine("Changing minutes to 130");
            validAfternoonTime.Minutes = 130;
            WriteLine($"{validAfternoonTime}\n");

            WriteLine("Assigning time with 20, 24, 40");
            Time validEveningTime = new Time(20, 24, 40);
            WriteLine(validEveningTime);
            WriteLine("Changing seconds to 123");
            validEveningTime.Seconds = 123;
            WriteLine($"{validEveningTime}\n");

            WriteLine("Instantiating Invalid Objects\n");

            WriteLine("Creating 3-parameter object with invalid hours: 25, 15, 30");
            Time invalidMorningTime = new Time(25, 15, 30);
            WriteLine($"{invalidMorningTime}\n");

            WriteLine("Creating 3-parameter object with invalid minutes: 18, 105, 45");
            Time invalidAfternoonTime = new Time(18, 105, 45);
            WriteLine($"{invalidAfternoonTime}\n");

            WriteLine("Creating 3-parameter object with invalid seconds: 11, 5, 99");
            Time invalidEveningTime = new Time(11, 5, 99);
            WriteLine($"{invalidEveningTime}\n");

            WriteLine("Creating 3-parameter object with all invalid data: 100, 100, 100");
            Time invalidDataTime = new Time(100, 100, 100);
            WriteLine($"{invalidDataTime}\n");

            WriteLine("Changing hours to 5, minutes to 12, and seconds to 34");
            invalidDataTime.Hours = 5;
            invalidDataTime.Minutes = 12;
            invalidDataTime.Seconds = 34;
            WriteLine(invalidDataTime);

            WriteLine("\nPart 2: Instantiating Incomplete Objects using THIS constructor\n");

            WriteLine("Instantiating 1-parameter object with hours of 11");
            Time singleParameter = new Time(11, 0, 0);
            WriteLine($"{singleParameter}\n");

            WriteLine("Instantiating 2-parameter object with hour 5 and minutes 25");
            Time doubleParameter = new Time(5, 25, 0);
            WriteLine($"{doubleParameter}\n");

            WriteLine("Instantiating 1-parameter object with hour of 30");
            Time invalidSingleParameter = new Time(30, 0, 0);
            WriteLine(invalidSingleParameter);
            WriteLine("Changing hours to 2");
            invalidSingleParameter.Hours = 2;
            WriteLine($"{invalidSingleParameter}\n");

            WriteLine("Instantiating 2-parameter object with hour 48 and minute 120");
            Time invalidDoubleParameter = new Time(48, 120, 0);
            WriteLine(invalidDoubleParameter);
            WriteLine("Chaning hours to 4 and minutes to 45");
            invalidDoubleParameter.Hours = 4;
            invalidDoubleParameter.Minutes = 45;
            WriteLine($"{invalidDoubleParameter}");

            Write("\nPress any key to continue...");
            ReadKey();
        }
    }
}
