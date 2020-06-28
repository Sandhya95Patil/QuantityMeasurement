//-----------------------------------------------------------------------
// <copyright file="IVolumeConverter.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
// <creater name="Sandhya Patil"/>
//-----------------------------------------------------------------------
namespace QuantityMeasurement.Interface
{
    using static QuantityMeasurement.Enum.QuantityEnum;

    /// <summary>
    /// interface for volume convert
    /// </summary>
    public interface IVolumeConverter
    {
        /// <summary>
        /// Method declare for convert volume
        /// </summary>
        /// <param name="quantityEnums">quantityEnums parameter</param>
        /// <param name="value">value parameter</param>
        /// <returns></returns>
        public double VolumeComverter(QuantityEnums quantityEnums, double value);
    }
}
