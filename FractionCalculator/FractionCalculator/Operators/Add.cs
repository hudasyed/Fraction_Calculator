using System;
using System.Collections.Generic;
using System.Text;
using FractionCalculator.Numbers;

namespace FractionCalculator.Operators
{
    class Add : Operator
    {
        public override INumber Calculate(INumber firstValue, INumber secondValue)
        {
            int firstNumerator = firstValue.GetNumerator();
            int secondNumerator = secondValue.GetNumerator();
            int firstDenominator = firstValue.GetDenomerator();
            int secondDenominator = firstValue.GetDenomerator();
            Fraction result;

            if(firstDenominator == secondDenominator)
            {
                result = new Fraction(firstNumerator + secondNumerator, firstDenominator);
            }
            else
            {
                int newDenominator = GreatestCommonDenominator(firstDenominator, secondDenominator);
                result = new Fraction((firstNumerator + secondNumerator) * newDenominator, newDenominator);
            }
            
            return NormalizeFraction(result);
        }
    }
}
