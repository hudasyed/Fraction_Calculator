using FractionCalculator.Numbers;
using FractionCalculator.Operators;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FractionCalculatorTests
{
    public class DivideTests
    {
        [Fact]
        public void Divide_Should_Calculate_Numbers_That_Divide_To_Whole()
        {
            Fraction first = new Fraction(1, 3);
            Fraction second = new Fraction(1, 3);

            var actual = Divide.Calculate(first, second);
            Assert.Equal("1", actual.GetValue());
        }

        [Fact]
        public void Divide_Should_Calculate_Numbers_That_Divide_To_Fractions()
        {
            Fraction first = new Fraction(3, 7);
            Fraction second = new Fraction(1, 2);

            var actual = Divide.Calculate(first, second);
            Assert.Equal("6/7", actual.GetValue());
        }
    }
}
