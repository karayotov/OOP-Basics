using System;
using System.Collections.Generic;
using System.Text;

class DateModifierStore
{
    private DateTime startDate;

    public DateTime StartDate
    {
        get { return startDate; }
        set { startDate = value; }
    }
    private DateTime endDate;

    public DateTime EndDate
    {
        get { return endDate; }
        set { endDate = value; }
    }

    public DateModifierStore(string start, string end)
    {
        this.StartDate = DateTime.Parse(start);
        this.EndDate = DateTime.Parse(end);
    }

    public void PrintDays()
    {
        Console.WriteLine(Math.Abs((EndDate - StartDate).TotalDays));
    }
}