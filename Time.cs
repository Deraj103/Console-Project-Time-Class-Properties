using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Console_Project_Time_Class_Properties
{
    internal class Time
    {
        private int hours, minutes, seconds;

        public Time(int hrs, int mins, int sec)
        {
            this.hours = hrs;
            this.minutes = mins;
            this.seconds = sec;
        }

        public int Hours
        {
            get
            {
                if (hours >= 0 && hours <= 23)
                {
                    return hours;
                }
                else
                {
                    WriteLine($"The value of {hours} is invalid, setting hours to 0");
                    return 0;
                }

            }
            set
            {
                if (value >= 0 && value <= 23)
                {
                    hours = value;
                }
                else
                {
                    Write($"The value of {value} is invalid, ");
                    WriteLine("setting hours to 0");
                    hours = 0;
                }
            }
        }
        public int Minutes
        {
            get 
            { 
                if ( minutes >= 0 && minutes <= 59)
                {
                    return minutes;
                }
                else
                {
                    WriteLine($"The value of {minutes} is invalid, setting minutes to 0");
                    return 0;
                }
            }
            set
            {
                if (value >= 0 && value <= 59)
                {
                    minutes = value;
                }
                else
                {
                    Write($"The value of {value} is invalid, ");
                    WriteLine("setting minutes to 0");
                    minutes = 0;
                }
            }
        }
        public int Seconds
        {
            get
            {
                if (seconds >= 0 && seconds <= 59)
                {
                    return seconds;
                }
                else
                {
                    WriteLine($"The value of {seconds} is invalid, setting seconds to 0");
                    return 0;
                }
            }
            set
            {
                if (value >= 0 && value <= 59)
                {
                    seconds = value;
                }
                else
                {
                    Write($"The value of {value} is invalid, ");
                    WriteLine("setting seconds to 0");
                    seconds = 0;
                }
            }
        }
        // Partial Constructors
        public Time(int hrs) : this(hrs, 0, 0)
        {

        }
        public Time(int hrs, int mins) : this(hrs, mins, 0)
        {

        }
        public override string ToString()
        {
            return ($"Time: {Hours}:{Minutes}:{Seconds}");
        }
    }
}
