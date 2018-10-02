﻿using FractionCalculator.Numbers;
using System;
using System.Collections.Generic;
using System.Text;

namespace FractionCalculator.Operators
{
    public abstract class Operator
    {
        public abstract INumber Calculate(INumber firstValue, INumber secondValue);

        public INumber NormalizeFraction(Fraction f)
        {
            int numerator = f.GetNumerator();
            int denominator = f.GetDenomerator();
            if (numerator % denominator == 0)
            {
                return new Whole(numerator / denominator);
            }
            else
            {
                return ReduceFraction(f);
            }
        }

        public Fraction ReduceFraction(Fraction f)
        {
            int numerator = f.GetNumerator();
            int denominator = f.GetDenomerator();
            int gcd = GreatestCommonDenominator(Math.Abs(numerator), Math.Abs(denominator));

            return gcd > 1 ?  new Fraction(numerator / gcd, denominator / gcd) :  f;
        }

        public int GreatestCommonDenominator(int a, int b)
        {
            if (a == 0)
                return b;
            if (b == 0)
                return a;
            if (a > b)
                return GreatestCommonDenominator(a % b, b);
            else
                return GreatestCommonDenominator(a, b % a);
        }
    }
}
