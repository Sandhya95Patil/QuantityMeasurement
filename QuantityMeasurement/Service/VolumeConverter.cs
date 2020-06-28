using QuantityMeasurement.Enum;
using QuantityMeasurement.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using static QuantityMeasurement.Enum.QuantityEnum;

namespace QuantityMeasurement.Service
{
    public class VolumeConverter : IVolumeConverter
    {
        public double VolumeComverter(QuantityEnum.QuantityEnums quantityEnums, double value)
        {
            switch (quantityEnums)
            {
                case QuantityEnums.GALLON_TO_LETER:
                    return value * 3.78;
                case QuantityEnums.LITER:
                    return value;
                case QuantityEnums.MILILITER_TO_LITER:
                    return 1000 / value;
                case QuantityEnums.LITER_TO_MILILITER:
                    return value * 1000;
            }
            return value;
        }
    }
}
