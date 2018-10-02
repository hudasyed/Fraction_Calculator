using System;
using System.Collections.Generic;
using System.Text;

namespace FractionCalculator.Numbers
{
    public class Whole : INumber
    {
        private readonly int value;

        public Whole(int value)
        {
            this.value = value;
        }

        public int GetDenomerator()
        {
            return 1;
        }

        public int GetNumerator()
        {
            return value;
        }

        public string GetValue()
        {
            return value.ToString();
        }
    }
}
