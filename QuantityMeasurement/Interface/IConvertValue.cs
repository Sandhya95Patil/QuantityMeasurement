using System;
using System.Collections.Generic;
using System.Text;
using static QuantityMeasurement.Enum.QuantityEnum;

namespace QuantityMeasurement.Interface
{
    interface IConvertValue
    {
        double ConvertValueInDifferentUnit(QuantityEnums quantityEnums, double value);
    }
}
