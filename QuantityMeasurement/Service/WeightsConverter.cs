

namespace QuantityMeasurement.Service
{
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
        /// <returns></returns>
        public double WeightConverter(QuantityEnums quantityEnums, double value)
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
            return value;
        }
    }
}
