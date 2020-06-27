using Polly;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement.Exception
{
    [Serializable]
    public class QuantityException : SystemException
    {
        public enum ExceptionType
        {
            InvalidValue
        }

        public ExceptionType type;
        public QuantityException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }

    }
}
