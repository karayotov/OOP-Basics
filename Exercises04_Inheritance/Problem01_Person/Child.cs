using System;
using System.Collections.Generic;
using System.Text;
class Child:Person
{
    private const int MAX_VALUE = 15;

    public Child(string name, int age) : base(name, age)
    {

    }
    public override int Age
    {
        get => base.Age;

        protected set
        {
            if (value > MAX_VALUE)
            {
                throw new ArgumentException($"Child's age must be less than 15!");
            }

            base.Age = value;
        }
    }
}