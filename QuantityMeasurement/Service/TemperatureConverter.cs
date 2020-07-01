//-----------------------------------------------------------------------
// <copyright file="TemperatureConverter.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
// <creater name="Sandhya Patil"/>
//-----------------------------------------------------------------------
namespace QuantityMeasurement.Service
{
    using QuantityMeasurement.Enum;
    using QuantityMeasurement.Exception;
    using QuantityMeasurement.Interface;
    using static QuantityMeasurement.Enum.QuantityEnum;

    /// <summary>
    /// Temperature converter class
    /// </summary>
    public class TemperatureConverter : ITemperatureConverter
    {
        /// <summary>
        /// Method for temperature convert 
        /// </summary>
        /// <param name="quantityEnums">quantityEnums parameter</param>
        /// <param name="value">value parameter</param>
        /// <returns>return the converted temperature</returns>
        public double TempConverter(QuantityEnum.QuantityEnums quantityEnums, double value)
        {
            try
            {
                if (quantityEnums.Equals(QuantityEnums.CELSIUS_TO_FARENHIET) || quantityEnums.Equals(QuantityEnums.FARENHIET_TO_CELSIUS))
                {
                    switch (quantityEnums)
                    {
                        case QuantityEnums.FARENHIET_TO_CELSIUS:
                            return (value - 32) * 5 / 9;
                        case QuantityEnums.CELSIUS_TO_FARENHIET:
                            return value * 1.8 + 32;
                    }
                }
                else
                {
                    throw new QuantityException(QuantityException.ExceptionType.QUANTITY_UNEQUALITY, "This is not allowed");
                }
      
                return value;
            }
            catch(QuantityException e)
            {
                throw new QuantityException(QuantityException.ExceptionType.QUANTITY_UNEQUALITY, e.Message);
            }
        }
    }
}
