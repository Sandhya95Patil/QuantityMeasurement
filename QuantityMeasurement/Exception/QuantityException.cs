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
            InvalidValue,
            QUANTITY_UNEQUALITY
        }

        public ExceptionType EType;
        public QuantityException(ExceptionType EType, string message) : base(message)
        {
            this.EType = EType;
        }

    }
}
