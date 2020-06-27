using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement.Interface
{
    interface IConvertValue
    {
        double ConvertValueInDifferentUnit(Enum.QuantityEnums quantityEnums, double value);
    }
}
