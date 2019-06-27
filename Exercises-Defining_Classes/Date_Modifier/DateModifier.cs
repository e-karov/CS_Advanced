using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Date_Modifier                             // 100 / 100
{
    public class DateModifier
    {

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public TimeSpan TimeSpan { get; set; }

        public DateModifier(string startDate, string endDate)
        {
            StartDate = DateTime.ParseExact(startDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            EndDate = DateTime.ParseExact(endDate, "yyyy MM dd", CultureInfo.InvariantCulture);

            TimeSpan = EndDate - StartDate;
        }

        public int  DaysDifference()
        {
            int result = Math.Abs (TimeSpan.Days);

            return result;
        }

    }
}
