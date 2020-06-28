//-----------------------------------------------------------------------
// <copyright file="IAddTwoValues.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
// <creater name="Sandhya Patil"/>
//-----------------------------------------------------------------------
namespace QuantityMeasurement.Interface
{
    /// <summary>
    /// interface for add two values
    /// </summary>
    public interface IAddTwoValues
    {
        /// <summary>
        /// Method declare for add two values
        /// </summary>
        /// <param name="firstValue">firstValue parameter</param>
        /// <param name="secondValue">secondValue parameter</param>
        /// <returns>return the added value</returns>
        public double AddTwoValue(double firstValue, double secondValue);
    }
}
