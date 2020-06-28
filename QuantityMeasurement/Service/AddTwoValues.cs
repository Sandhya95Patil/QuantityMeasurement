//-----------------------------------------------------------------------
// <copyright file="AddTwoValues.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
// <creater name="Sandhya Patil"/>
//-----------------------------------------------------------------------
namespace QuantityMeasurement.Service
{
    using QuantityMeasurement.Interface;

    /// <summary>
    /// class for add two values
    /// </summary>
    public class AddTwoValues : IAddTwoValues
    {
        /// <summary>
        /// Method to add two values
        /// </summary>
        /// <param name="firstValue">firstValue parameter</param>
        /// <param name="secondValue">secondValue parameter</param>
        /// <returns>return added value</returns>
        public double AddTwoValue(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
}
