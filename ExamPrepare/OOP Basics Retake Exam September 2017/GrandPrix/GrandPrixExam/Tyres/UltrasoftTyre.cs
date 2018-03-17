using System;
using System.Collections.Generic;
using System.Text;

namespace GrandPrix.Tyres
{
    public class UltrasoftTyre : Tyre
    {
        public UltrasoftTyre(double hardness) : base(hardness)
        {
            this.Name = ULTRASOFT_NAME;
            base.Hardness = base.Hardness + this.Grip;
            base.Degradation = base.Degradation - ULTRASOFT_BLOW_EARLIER;
        }

        private const int ULTRASOFT_BLOW_INDEX = 30;

        private const string ULTRASOFT_NAME = "Ultrasoft";

        public string Name { get; }

        public double Grip { get; set; }
    }
}
