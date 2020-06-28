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
            }
            return value;
        }
    }
}
