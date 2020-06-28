//-----------------------------------------------------------------------
// <copyright file="ITemperatureConverter.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
// <creater name="Sandhya Patil"/>
//-----------------------------------------------------------------------
namespace QuantityMeasurement.Interface
{
    using static QuantityMeasurement.Enum.QuantityEnum;

    /// <summary>
    /// interface for temperature converter
    /// </summary>
    public interface ITemperatureConverter
    {
        /// <summary>
        /// Method declare for temperature converter
        /// </summary>
        /// <param name="quantityEnums">quantityEnums parameter</param>
        /// <param name="value">value parameter</param>
        /// <returns>return the converted value</returns>
        public double TempConverter(QuantityEnums quantityEnums, double value);
    }
}
