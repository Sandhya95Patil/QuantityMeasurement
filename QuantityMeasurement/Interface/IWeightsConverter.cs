//-----------------------------------------------------------------------
// <copyright file="IWeightsConverter.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
// <creater name="Sandhya Patil"/>
//-----------------------------------------------------------------------
namespace QuantityMeasurement.Interface
{
    using static QuantityMeasurement.Enum.QuantityEnum;

    /// <summary>
    /// interface for convert weight
    /// </summary>
    public interface IWeightsConverter
    {
        /// <summary>
        /// Method declare for weight convert
        /// </summary>
        /// <param name="quantityEnums">quantityEnums parameter</param>
        /// <param name="value">value parameter</param>
        /// <returns>return the converted value</returns>
        public double WeightConverter(QuantityEnums quantityEnums, double value);
    }
}
