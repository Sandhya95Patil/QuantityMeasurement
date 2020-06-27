using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement.Interface
{
    interface IConvertValue
    {
        double ConvertValueInDifferentUnit(Enum.QuantityEnum quantityEnums, double value);
    }
}
