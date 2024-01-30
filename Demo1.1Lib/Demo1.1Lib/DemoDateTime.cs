using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo11Lib
{
    public class ClassDateTime
    {

        public static TimeSpan BetweenDT(DateTime date1, DateTime date2) 
        {
            TimeSpan diff = date1.Subtract(date2);
            return diff;
        }

        public static bool IsLeapYear(int year) 
        {
            return (year % 4 == 0) && (year % 100 != 0 || year % 400 == 0);
        }

        public static void FormDT() 
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToLongDateString());
            Console.WriteLine(date.ToShortTimeString());
        }

        public static String TimesDay(DateTime time)
        {
            if (time.Hour >= 4 && time.Hour <= 11)
            {
                return "Morning";
            }
            else if (time.Hour >= 12 && time.Hour <= 17)
            {
                return"Day";
            }
            else if (time.Hour >= 18 && time.Hour <= 23)
            {
                return"Evening";
            }
            else
            {
                return"Night";
            }


        }

    }
}