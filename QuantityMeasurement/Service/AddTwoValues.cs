using QuantityMeasurement.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement.Service
{
    public class AddTwoValues : IAddTwoValues
    {
        public double AddTwoValue(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
}
