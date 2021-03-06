﻿using System;
using System.Collections.Generic;
using System.Text;
using FractionCalculator.Numbers;

namespace FractionCalculator.Operators
{
    public static class Add
    {
        public static INumber Calculate(INumber firstValue, INumber secondValue)
        {
            int firstNumerator = firstValue.GetNumerator();
            int secondNumerator = secondValue.GetNumerator();
            int firstDenominator = firstValue.GetDenomerator();
            int secondDenominator = secondValue.GetDenomerator();
            Fraction result;

            if(firstDenominator == secondDenominator)
            {
                result = new Fraction(firstNumerator + secondNumerator, firstDenominator);
            }
            else
            {
                int newDenominator = MathHelper.LowestCommonMultiple(firstDenominator, secondDenominator);
                firstNumerator = (firstNumerator) * (newDenominator / firstDenominator);
                secondNumerator = (secondNumerator) * (newDenominator / secondDenominator);

                result = new Fraction((firstNumerator  + secondNumerator), newDenominator);
            }
            
            return MathHelper.NormalizeFraction(result);
        }
    }
}
