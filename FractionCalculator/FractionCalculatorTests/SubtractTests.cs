﻿using FractionCalculator.Numbers;
using FractionCalculator.Operators;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FractionCalculatorTests
{
    public class SubtractTests
    {
        [Fact]
        public void Subtract_Should_Calculate_Numbers_That_Subtract_To_Whole()
        {
            Fraction first = new Fraction(1, 3);
            Fraction second = new Fraction(1, 3);

            var actual = Subtract.Calculate(first, second);
            Assert.Equal("0", actual.GetValue());
        }

        [Fact]
        public void Subtract_Should_Calculate_Numbers_That_Subtract_To_Fractions()
        {
            Fraction first = new Fraction(5, 7);
            Fraction second = new Fraction(2, 7);

            var actual = Subtract.Calculate(first, second);
            Assert.Equal("3/7", actual.GetValue());
        }
    }
}
