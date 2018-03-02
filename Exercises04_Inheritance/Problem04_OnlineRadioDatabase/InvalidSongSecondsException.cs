using System;
using System.Collections.Generic;
using System.Text;
public class InvalidSongSecondsException : InvalidSongLengthException
{
    private const int MIN_VALUE = 0;
    private const int MAX_VALUE = 59;

    public override string Message => $"Song seconds should be between {MIN_VALUE} and {MAX_VALUE}.";
}