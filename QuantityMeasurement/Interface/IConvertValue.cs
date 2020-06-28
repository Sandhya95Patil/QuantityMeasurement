//-----------------------------------------------------------------------
// <copyright file="IConvertValue.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
// <creater name="Sandhya Patil"/>
//-----------------------------------------------------------------------
namespace QuantityMeasurement.Interface
{
    using static QuantityMeasurement.Enum.QuantityEnum;

    /// <summary>
    /// interface for length value 
    /// </summary>
    interface IConvertValue
    {
        /// <summary>
        /// Method declare for convert length
        /// </summary>
        /// <param name="quantityEnums">quantityEnums parameter</param>
        /// <param name="value">value parameter</param>
        /// <returns>return the length converted value</returns>
        double ConvertValueInDifferentUnit(QuantityEnums quantityEnums, double value);
    }
}
