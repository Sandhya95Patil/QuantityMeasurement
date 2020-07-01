//-----------------------------------------------------------------------
// <copyright file="LengthConverter.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
// <creater name="Sandhya Patil"/>
//-----------------------------------------------------------------------
namespace QuantityMeasurement.Service
{
    using QuantityMeasurement.Exception;
    using QuantityMeasurement.Interface;
    using static QuantityMeasurement.Enum.QuantityEnum;

    /// <summary>
    /// Length converter class
    /// </summary>
    public class Length: IConvertValue
    {
        /// <summary>
        /// initializes the memory
        /// </summary>
        public Length()
        {

        }

        /// <summary>
        /// quantity enums
        /// </summary>
        private readonly Enum.QuantityEnum quantityEnum;
        private readonly double value;

        /// <summary>
        /// Method for converte length
        /// </summary>
        /// <param name="quantityEnum">quantityEnum parameter</param>
        /// <param name="length">length parameter</param>
        /// <returns>return the converted length</returns>
        public double ConvertValueInDifferentUnit(QuantityEnums quantityEnum, double length)
        {
            try
            {
                if (quantityEnum.Equals(QuantityEnums.FEET) || quantityEnum.Equals(QuantityEnums.INCH) || quantityEnum.Equals(QuantityEnums.FEET_TO_INCH) || quantityEnum.Equals(QuantityEnums.YARD) || quantityEnum.Equals(QuantityEnums.YARD_TO_INCH) || quantityEnum.Equals(QuantityEnums.CM) || quantityEnum.Equals(QuantityEnums.CENTIMETER_TO_INCH) || quantityEnum.Equals(QuantityEnums.INCH_TO_CENTIMETER))
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
                else
                {
                    throw new QuantityException(QuantityException.ExceptionType.QUANTITY_UNEQUALITY, "This is not allowed");
                }
                return length;
            }
            catch (QuantityException e)
            {
                throw new QuantityException(QuantityException.ExceptionType.QUANTITY_UNEQUALITY, e.Message);
            }
        }
    }
}
