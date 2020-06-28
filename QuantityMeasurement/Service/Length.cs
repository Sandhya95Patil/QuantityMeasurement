using QuantityMeasurement.Enum;
using QuantityMeasurement.Exception;
using QuantityMeasurement.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using static QuantityMeasurement.Enum.QuantityEnum;

namespace QuantityMeasurement.Service
{
    public class Length: IConvertValue, IAddTwoValues
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
                    case QuantityEnums.CM:
                        return length;
                    case QuantityEnums.INCH_TO_CENTIMETER:
                        return length * 2.5;
                    case QuantityEnums.CENTIMETER_TO_INCH:
                        return length /2.5;
                }
                return length;
            }
            catch (QuantityException e)
            {
                throw new QuantityException(QuantityException.ExceptionType.InvalidValue, e.Message);
            }
        }


        public double AddTwoValue(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
}
