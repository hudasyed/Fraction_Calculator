using System;
using System.Collections.Generic;
using System.Text;
using FractionCalculator.Numbers;

namespace FractionCalculator.Operators
{
    class Divide : Operator
    {
        public override INumber Calculate(INumber firstValue, INumber secondValue)
        {
            int firstNumerator = firstValue.GetNumerator();
            int secondNumerator = secondValue.GetNumerator();
            int firstDenominator = firstValue.GetDenomerator();
            int secondDenominator = firstValue.GetDenomerator();

            Fraction result;
            int newNumerator = firstNumerator * secondDenominator;
            int newDenominator = firstDenominator * secondNumerator;
            result = new Fraction(newNumerator, newDenominator);

            return NormalizeFraction(result);
        }
    }
}
