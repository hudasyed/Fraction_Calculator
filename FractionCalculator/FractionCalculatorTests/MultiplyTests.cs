using FractionCalculator.Numbers;
using FractionCalculator.Operators;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FractionCalculatorTests
{
    public class MultiplyTests
    {
        [Fact]
        public void Multiply_Should_Calculate_Numbers_That_Multiply_To_Whole()
        {
            Fraction first = new Fraction(1, 3);
            Fraction second = new Fraction(3, 1);

            var actual = Multiply.Calculate(first, second);
            Assert.Equal("1", actual.GetValue());
        }

        [Fact]
        public void Multiply_Should_Calculate_Numbers_That_Multiply_To_Fractions()
        {
            Fraction first = new Fraction(3, 7);
            Fraction second = new Fraction(1, 2);

            var actual = Multiply.Calculate(first, second);
            Assert.Equal("3/14", actual.GetValue());
        }

        [Fact]
        public void Multiplying_By_Zero_Should_Return_Zero()
        {
            Whole first = new Whole(0);
            Whole second = new Whole(20);

            var actual = Multiply.Calculate(first, second);
            Assert.Equal("0", actual.GetValue());
        }
    }
}
