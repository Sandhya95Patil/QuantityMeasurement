using NUnit.Framework;
using QuantityMeasurement.Exception;
using QuantityMeasurement.Service;

namespace QuantityMeasurementTest
{
    public class Tests
    {
        public Length length;

        [SetUp]
        public void Setup()
        {
            this.length = new Length();

        }

        [Test]
        public void Zero_Feet_And_Zero_Feet_Should_Return_Equal()
        {
            try
            {
                double feetOne = length.ConvertValueInDifferentUnit(Length.QuantityEnum.FEET, 0.0);
                double feetTwo = length.ConvertValueInDifferentUnit(Length.QuantityEnum.FEET, 0.0);
                Assert.AreEqual(feetOne, feetTwo);
            }
            catch (QuantityException e)
            {
                throw new QuantityException(QuantityException.ExceptionType.InvalidValue, e.Message);
            }
        }

        [Test]
        public void Null_Check_For_Equality()
        {
            try
            {
                double feetOne = length.ConvertValueInDifferentUnit(Length.QuantityEnum.FEET, 0.0);
                Length feetTwo = null;
                Assert.AreNotEqual(feetOne, feetTwo);
            }
            catch (QuantityException e)
            {
                throw new QuantityException(QuantityException.ExceptionType.InvalidValue, e.Message);
            }
        }
    }
}