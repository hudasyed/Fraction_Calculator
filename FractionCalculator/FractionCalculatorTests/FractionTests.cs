using FractionCalculator.Numbers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FractionCalculatorTests
{
    public class FractionTests
    {
        [Fact]
        public void GetValue_Should_Return_String_For_Simple_Fraction()
        {
            Fraction f = new Fraction(1, 2);
            Fraction h = new Fraction(2, 3);
            Fraction i = new Fraction(3, 4);

            Assert.Equal("1/2", f.GetValue());
            Assert.Equal("2/3", h.GetValue());
            Assert.Equal("3/4", i.GetValue());
        }

        [Fact]
        public void GetValue_Should_Return_String_For_Mixed_Fractoin()
        {
            Fraction f = new Fraction(20, 3);
            Fraction h = new Fraction(16, 5);
            Fraction i = new Fraction(10, 7);

            Assert.Equal("6_2/3", f.GetValue());
            Assert.Equal("3_1/5", h.GetValue());
            Assert.Equal("1_3/7", i.GetValue());
        }
    }
}
