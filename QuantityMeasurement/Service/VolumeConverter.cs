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
                switch (quantityEnums)
                {
                    case QuantityEnums.GALLON_TO_LETER:
                        return value * 3.78;
                    case QuantityEnums.LITER:
                        return value;
                    case QuantityEnums.MILILITER_TO_LITER:
                        return 1000 / value;
                    case QuantityEnums.LITER_TO_MILILITER:
                        return value * 1000;
                }
                return value;
            }
            catch(QuantityException e)
            {
                throw new QuantityException(QuantityException.ExceptionType.InvalidValue, e.Message);
            }
            
        }
    }
}
