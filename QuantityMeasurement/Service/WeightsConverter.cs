//-----------------------------------------------------------------------
// <copyright file="WeightsConverter.cs" company="BridgeLabz">
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
    /// Weight converter class
    /// </summary>
    public class WeightsConverter : IWeightsConverter
    {
        /// <summary>
        /// Method for convert weight
        /// </summary>
        /// <param name="quantityEnums">quantityEnums parameter</param>
        /// <param name="value">value parameter</param>
        /// <returns>return the conerted weight</returns>
        public double WeightConverter(QuantityEnums quantityEnums, double value)
        {
            try
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
                    case QuantityEnums.TONNE:
                        return value;
                    case QuantityEnums.KILOGRAM_TO_TONNE:
                        return value / 1000;
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
