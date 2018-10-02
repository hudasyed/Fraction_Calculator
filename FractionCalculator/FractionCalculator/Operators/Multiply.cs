using System;
using System.Collections.Generic;
using System.Text;
using FractionCalculator.Numbers;

namespace FractionCalculator.Operators
{
    class Multiply : Operator
    {
        public override INumber Calculate(INumber firstValue, INumber secondValue)
        {
            int firstNumerator = firstValue.GetNumerator();
            int secondNumerator = secondValue.GetNumerator();
            int firstDenominator = firstValue.GetDenomerator();
            int secondDenominator = firstValue.GetDenomerator();

            Fraction result;
            int newNumerator = firstNumerator * secondNumerator;
            int newDenominator = firstDenominator * secondDenominator;
            result = new Fraction(newNumerator, newDenominator);

            return NormalizeFraction(result);
        }
    }
}
