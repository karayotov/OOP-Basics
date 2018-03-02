using System;
using System.Collections.Generic;
using System.Text;

public class InvalidSongMinutesException : InvalidSongLengthException
{
    private const int MIN_VALUE = 0;
    private const int MAX_VALUE = 14;

    public override string Message => $"Song minutes should be between {MIN_VALUE} and {MAX_VALUE}.";
}