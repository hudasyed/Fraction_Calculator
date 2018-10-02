using System;
using System.Collections.Generic;
using System.Text;
using FractionCalculator.Numbers;

namespace FractionCalculator.Operators
{
    public static class Divide
    {
        public static INumber Calculate(INumber firstValue, INumber secondValue)
        {
            int firstNumerator = firstValue.GetNumerator();
            int secondNumerator = secondValue.GetNumerator();
            int firstDenominator = firstValue.GetDenomerator();
            int secondDenominator = secondValue.GetDenomerator();
            Fraction result;

            if (firstNumerator == 0) return new Whole(0);
            else if (secondNumerator == 0) throw new DivideByZeroException("You cannot divide a number by zero.");

            int newNumerator = firstNumerator * secondDenominator;
            int newDenominator = firstDenominator * secondNumerator;
            result = new Fraction(newNumerator, newDenominator);

            return MathHelper.NormalizeFraction(result);
        }
    }
}
