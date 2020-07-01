//---------------------------------------------------------------------
// <copyright file="VolumeConverter.cs" company="BridgeLabz">
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
    /// Volume converter class
    /// </summary>
    public class VolumeConverter : IVolumeConverter
    {
        /// <summary>
        /// Method for volume convert
        /// </summary>
        /// <param name="quantityEnums">quantityEnums parameter</param>
        /// <param name="value">value parameter</param>
        /// <returns>return the converted volume</returns>
        public double VolumeComverter(QuantityEnum.QuantityEnums quantityEnums, double value)
        {
            try
            {
                if(quantityEnums.Equals(QuantityEnums.LITER) || quantityEnums.Equals(QuantityEnums.GALLON_TO_LETER) || quantityEnums.Equals(QuantityEnums.MILILITER_TO_LITER) || quantityEnums.Equals(QuantityEnums.LITER_TO_MILILITER))
                {
                    switch (quantityEnums)
                    {
                        case QuantityEnums.GALLON_TO_LETER:
                            return value * 3.78;
                        case QuantityEnums.LITER:
                            return value;
                        case QuantityEnums.MILILITER_TO_LITER:
                            return value / 1000;
                        case QuantityEnums.LITER_TO_MILILITER:
                            return value * 1000;
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
