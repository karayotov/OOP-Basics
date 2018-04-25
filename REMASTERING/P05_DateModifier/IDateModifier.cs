using System;
using System.Collections.Generic;
using System.Text;

public interface IDateModifier
{
    int DaysBetweenDates { get; }

    int GetDays(string firstDate, string secondDate);
}