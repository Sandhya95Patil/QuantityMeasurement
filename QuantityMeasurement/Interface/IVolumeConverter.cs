using QuantityMeasurement.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using static QuantityMeasurement.Enum.QuantityEnum;

namespace QuantityMeasurement.Interface
{
    public interface IVolumeConverter
    {
        public double VolumeComverter(QuantityEnums quantityEnums, double value);
    }
}
