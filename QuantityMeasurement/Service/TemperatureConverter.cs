using QuantityMeasurement.Enum;
using QuantityMeasurement.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using static QuantityMeasurement.Enum.QuantityEnum;

namespace QuantityMeasurement.Service
{
    public class TemperatureConverter : ITemperatureConverter
    {
        public double TempConverter(QuantityEnum.QuantityEnums quantityEnums, double value)
        {
            switch (quantityEnums)
            {
                case QuantityEnums.FARENHIET_TO_CELSIUS:
                    //return (value /212) *100;
                    return (value - 32) * 5 / 9;
                case QuantityEnums.CELSIUS_TO_FARENHIET:
                    return value * 1.8 + 32;
            }
            return value;
        }
    }
}
