using System;
using System.Collections.Generic;
using System.Text;

namespace FractionCalculator.Numbers
{
    public interface INumber
    {
        int GetNumerator();
        int GetDenomerator();
        string GetValue();
    }
}
