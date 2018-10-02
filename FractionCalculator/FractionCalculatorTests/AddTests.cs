using FractionCalculator.Numbers;
using FractionCalculator.Operators;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FractionCalculatorTests
{
    public class AddTests
    {
        [Fact]
        public void Add_Should_Calculate_Fractions_That_Add_Up_To_Whole_Number()
        {
            Fraction first = new Fraction(1, 2);
            Fraction second = new Fraction(1, 2);

            var actual = Add.Calculate(first, second);
            Assert.Equal("1", actual.GetValue());
        }

        [Fact]
        public void Add_Should_Simplify_Fractions_While_Adding()
        {
            Fraction first = new Fraction(3, 6);
            Fraction second = new Fraction(7, 6);

            var actual = Add.Calculate(first, second);
            Assert.Equal("1_2/3", actual.GetValue());

        }

    }
}
