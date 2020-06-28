using QuantityMeasurement.Enum;
using QuantityMeasurement.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using static QuantityMeasurement.Enum.QuantityEnum;

namespace QuantityMeasurement.Service
{
    public class WeightsConverter : IWeightsConverter
    {
        public double WeightConverter(QuantityEnums quantityEnums, double value)
        {
            switch (quantityEnums)
            {
                case QuantityEnums.KILOGRAM:
                    return value;
                case QuantityEnums.KILOGRAM_TO_GRAM:
                    return value * 1000;
                case QuantityEnums.TONNE_TO_KILOGRAM:
                    return value * 1000;
                case QuantityEnums.GRAM:
                    return value;
            }
            return value;
        }
    }
}
