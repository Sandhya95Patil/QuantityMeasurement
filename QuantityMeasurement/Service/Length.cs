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

        public override bool Equals(object obj)
        {
            return obj is Length length &&
                value == length.value &&
                quantityEnum ==length.quantityEnum;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(value, quantityEnum);
        }

        public bool Compare(Length length)
        {
            if (this.quantityEnum.Equals(length.quantityEnum))
            {
                return this.Equals(length);
            }

            if (this.quantityEnum.Equals(QuantityEnum.FEET) && length.quantityEnum.Equals(QuantityEnum.INCH))
            {
                return length.value.CompareTo(this.value * FeetToInch) == 0;
            }

            if (this.quantityEnum.Equals(QuantityEnum.INCH) && length.quantityEnum.Equals(QuantityEnum.FEET))
            {
                return length.value.CompareTo(this.value / InchToFeet) == 0;
            }

            return false;
        }

        public double ConvertValueInDifferentUnit(QuantityEnum quantityEnum, double length)
        {
            try
            {
                return length;
            }
            catch (QuantityException e)
            {
                throw new QuantityException(QuantityException.ExceptionType.InvalidValue, e.Message);
            }
        }
    }
}
