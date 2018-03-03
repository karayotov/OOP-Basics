using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Smartphone : ICallable, IBrowsable
{

    private string number;
    private string site;

    public string Number
    {
        get { return this.number; }
        set
        {
            if (value.Any(a => !Char.IsDigit(a)))
            {
                throw new ArgumentException("Invalid number!");
            }
            number = value;
        }
    }

    public string Site
    {
        get { return this.site; }
        set
        {
            if (value.Any(a => Char.IsDigit(a)))
            {
                throw new ArgumentException("Invalid URL!");
            }

            site = value;
        }
    }

    public string Calling()
    {
        return $"Calling... {this.number}";
    }

    public string Browsing()
    {
        return $"Browsing: {this.site}!";
    }
}