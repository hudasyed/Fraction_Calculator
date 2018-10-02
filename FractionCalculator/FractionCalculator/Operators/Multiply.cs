using System;
using System.Collections.Generic;
using System.Text;
using FractionCalculator.Numbers;

namespace FractionCalculator.Operators
{
    public static class Multiply
    {
        public static INumber Calculate(INumber firstValue, INumber secondValue)
        {
            int firstNumerator = firstValue.GetNumerator();
            int secondNumerator = secondValue.GetNumerator();
            int firstDenominator = firstValue.GetDenomerator();
            int secondDenominator = secondValue.GetDenomerator();
            Fraction result;

            if (firstNumerator == 0 || secondNumerator == 0) return new Whole(0);

            int newNumerator = firstNumerator * secondNumerator;
            int newDenominator = firstDenominator * secondDenominator;
            result = new Fraction(newNumerator, newDenominator);

            return MathHelper.NormalizeFraction(result);
        }
    }
}
