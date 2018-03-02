using System;
using System.Collections.Generic;
using System.Text;

public class InvalidSongException : Exception
{
    private string exceptionMessage = "Invalid song.";

    public virtual string ExceptionMessage
    {
        set => this.exceptionMessage = value;
    }

    public override string Message => exceptionMessage;
}