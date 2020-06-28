//-----------------------------------------------------------------------
// <copyright file="QuantityException.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
// <creater name="Sandhya Patil"/>
//-----------------------------------------------------------------------
namespace QuantityMeasurement.Exception
{
    using System;

    /// <summary>
    /// Exception class
    /// </summary>
    [Serializable]
    public class QuantityException : SystemException
    {
        /// <summary>
        /// enum type exception
        /// </summary>
        public enum ExceptionType
        {
            InvalidValue
        }

        /// <summary>
        /// Exception type
        /// </summary>
        public ExceptionType type;

        /// <summary>
        /// Initializes the exception
        /// </summary>
        /// <param name="type">type parameter</param>
        /// <param name="message">message parameter</param>
        public QuantityException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }

    }
}
