using System;
using System.Collections.Generic;
using System.Text;

namespace FractionCalculator.Numbers
{
    public class Fraction : INumber
    {
        private readonly int numerator;
        private readonly int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public int GetDenomerator()
        {
            return denominator;
        }

        public int GetNumerator()
        {
            return numerator;
        }

        public string GetValue()
        {
            if (numerator > denominator) return GetMixedValue();
            else return GetSimpleValue();
        }

        private string GetSimpleValue()
        {
            return $"{numerator}/{denominator}";
        }

        private string GetMixedValue()
        {
            int wholeNumber = numerator / denominator;
            int newNumerator = numerator % denominator;
            return $"{wholeNumber}_{newNumerator}/{denominator}";
        }
    }
}
