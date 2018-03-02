using System;
using System.Collections.Generic;
using System.Text;

public class InvalidSongNameException : InvalidSongException
{
    private const int MIN_VALUE = 3;
    private const int MAX_VALUE = 30;

    public override string Message => $"Song name should be between {MIN_VALUE} and {MAX_VALUE} symbols";
}