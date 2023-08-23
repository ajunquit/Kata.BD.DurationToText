using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.BD.DurationToText
{
    public class Kata
    { 
        public static string DurationToText(int duration)
        {
            if (duration <= 0)
                return "now"; 

            double days = (double) duration / 86400;
            int daysWithoutDecimal = (int)days;

            double decimalPart = days - daysWithoutDecimal;

            double hours = (double)decimalPart * 24;
            int hoursWithoutDecimal = (int)hours;

            decimalPart = hours - hoursWithoutDecimal;

            double minutes = (double)decimalPart * 60;
            int minutesWithoutDecimal = (int)minutes;

            decimalPart = minutes - minutesWithoutDecimal;

            double seconds = (double)decimalPart * 60;
            int secondssWithoutDecimal = (int) Math.Round(seconds);

            string response = string.Empty;

            if (daysWithoutDecimal > 0)
                response += string.Concat("{0} ", (daysWithoutDecimal > 1) ? "days, " : "day, ");

            if (hoursWithoutDecimal > 0)
                response += string.Concat("{1} ", (hoursWithoutDecimal > 1) ? "hours, " : "hour, ");

            if (minutesWithoutDecimal > 0)
                response += string.Concat("{2} ", (minutesWithoutDecimal > 1) ? "minutes and " : "minute and ");

            if (secondssWithoutDecimal > 0)
                response += string.Concat("{3} ", (secondssWithoutDecimal > 1) ? "seconds" : "second");


            return string.Format(response, daysWithoutDecimal, hoursWithoutDecimal, minutesWithoutDecimal, secondssWithoutDecimal);
        }
    }
}
