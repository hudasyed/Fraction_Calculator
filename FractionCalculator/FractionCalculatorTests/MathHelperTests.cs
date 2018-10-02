using FractionCalculator.Operators;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit; 

namespace FractionCalculatorTests
{
    public class MathHelperTests
    {
        [Fact]
        public void GCD_Should_Return_Greatest_Common_Denominator()
        {
            int one = MathHelper.GreatestCommonDenominator(3, 5);
            int two = MathHelper.GreatestCommonDenominator(2, 0);
            int three = MathHelper.GreatestCommonDenominator(0, 3);
            int four = MathHelper.GreatestCommonDenominator(4, 8);

            Assert.Equal(1, one);
            Assert.Equal(2, two);
            Assert.Equal(3, three);
            Assert.Equal(4, four);
        }

        [Fact]
        public void LCM_Should_Return_Lowest_Common_Multiple()
        {
            int eight = MathHelper.LowestCommonMultiple(4, 8);
            int fifteen = MathHelper.LowestCommonMultiple(3, 5);

            Assert.Equal(8, eight);
            Assert.Equal(15, fifteen);
        }
    }
}
