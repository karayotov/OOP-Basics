using System;
using System.Collections.Generic;
using System.Text;

public class DateModifier : IDateModifier
{
    private int daysBetweenDates;

    public int DaysBetweenDates
    {
        get { return daysBetweenDates; }
        set { daysBetweenDates = value; }
    }


    public int GetDays(string firstDateStr, string secondDateStr)
    {
        DateTime first = DateTime.ParseExact(firstDateStr, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);
        DateTime second = DateTime.ParseExact(secondDateStr, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);

        return (int)Math.Abs((second - first).TotalDays);
    }
}