using QuantityMeasurement.Enum;
using QuantityMeasurement.Exception;
using System;
using System.Collections.Generic;
using System.Text;
using static QuantityMeasurement.Enum.QuantityEnum;

namespace QuantityMeasurement.Service
{
    public class Length
    {
        public Length()
        {

        }

        private readonly Enum.QuantityEnum quantityEnum;
        private readonly double value;

        public Length(double value, Enum.QuantityEnum enums)
        {
            this.quantityEnum = enums;
            this.value = value;
        }

        public double ConvertValueInDifferentUnit(QuantityEnums quantityEnum, double length)
        {
            try
            {
                switch (quantityEnum)
                {
                    case QuantityEnums.FEET:
                        return length;
                    case QuantityEnums.INCH:
                        return length;
                    case QuantityEnums.FEET_TO_INCH:
                        return length * 12.0;
                    case QuantityEnums.YARD:
                        return length;
                    case QuantityEnums.YARD_TO_INCH:
                        return length * 36.0;
                }
                return length;
            }
            catch (QuantityException e)
            {
                throw new QuantityException(QuantityException.ExceptionType.InvalidValue, e.Message);
            }
        }
    }
}
