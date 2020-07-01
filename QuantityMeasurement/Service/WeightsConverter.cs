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
                if (quantityEnums.Equals(QuantityEnums.KILOGRAM) || quantityEnums.Equals(QuantityEnums.KILOGRAM_TO_GRAM) || quantityEnums.Equals(QuantityEnums.TONNE_TO_KILOGRAM) || quantityEnums.Equals(QuantityEnums.GRAM))
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
