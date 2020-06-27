using QuantityMeasurement.Enum;
using QuantityMeasurement.Exception;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement.Service
{
    public class Length
    {
        public Length()
        {

        }
        public enum QuantityEnum 
        {
            FEET,
            INCH,
            YARD,
            FEETTOINCH,
            YARDTOINCH
        }

        private readonly QuantityEnums quantityEnum;
        private readonly double value;
        private const double FeetToInch = 12.0;
        private const double InchToFeet = 12.0;
        public Length(double value, QuantityEnums enums)
        {
            this.quantityEnum = enums;
            this.value = value;
        }

        public double ConvertValueInDifferentUnit(QuantityEnum quantityEnum, double length)
        {
            try
            {
                switch (quantityEnum)
                {
                    case QuantityEnum.FEET:
                        return length;
                    case QuantityEnum.INCH:
                        return length;
                    case QuantityEnum.FEETTOINCH:
                        return length * 12.0;
                    case QuantityEnum.YARD:
                        return length;
                    case QuantityEnum.YARDTOINCH:
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
