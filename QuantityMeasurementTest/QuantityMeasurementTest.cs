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
        public void One_Feet_And_Two_Feet_Should_Return_Not_Equal()
        {
            try
            {
                double feetOne = length.ConvertValueInDifferentUnit(Length.QuantityEnum.FEET, 1);
                double feetTwo = length.ConvertValueInDifferentUnit(Length.QuantityEnum.FEET, 2);
                Assert.AreNotEqual(feetOne, feetTwo);
            }
            catch (QuantityException e)
            {
                throw new QuantityException(QuantityException.ExceptionType.InvalidValue, e.Message);
            }
        }
    }
}